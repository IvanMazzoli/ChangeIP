using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeIP
{
    public partial class MainForm : Form
    {
        // Variabili classe
        List<IpConfiguration> ipConfigurations = new List<IpConfiguration>();
        List<NetworkAdapter> networkAdapters = new List<NetworkAdapter>();

        public MainForm()
        {
            // Inizializzo i componenti grafici
            InitializeComponent();

            // Centro il form a schermo
            this.CenterToParent();

            // Creo la lista di definizioni indirizzi IP
            CreateNetworkAddresses();

            // Popolo la lista di adattatori di rete
            SetupNetworkAdapters();
        }

        // Metodo per popolare le definizioni di indirizzi IP
        public void CreateNetworkAddresses()
        {
            ipConfigurations.Add(new IpConfiguration() { Name = "Mitsubishi", IpAddress = "192.168.3.200" });
            ipConfigurations.Add(new IpConfiguration() { Name = "Siemens/Lenze", IpAddress = "192.168.254.200" });
            ipConfigurations.Add(new IpConfiguration() { Name = "Lenze 1° Avvio", IpAddress = "192.168.5.200" });
            ipConfigurations.Add(new IpConfiguration() { Name = "Siemens Comar", IpAddress = "192.168.0.200" });
        }

        // Metodo per popolare la lista di adattatori di rete presenti sul PC
        public void SetupNetworkAdapters()
        {
            // Ottengo gli adattatori di rete
            networkAdapters = GetNetworkAdapters();

            // Configuro il ComboBox con gli adattatori appena ottenuti
            AdaptersComboBox.DataSource = networkAdapters;
            AdaptersComboBox.DisplayMember = "Name";
            AdaptersComboBox.ValueMember = "Value";

            // Imposto il ComboBox come sola lettura
            AdaptersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Aggiorno le info con IP e info configurazione
            DisplayNetworkAdapterInformations(0);

            // TODO: CHECK SE HO UN SALVA ADATTATORE
        }

        // Metodo per ottenere una lista di adattatori di rete
        private List<NetworkAdapter> GetNetworkAdapters()
        {
            // Creo una lista di elementi
            List<NetworkAdapter> results = new List<NetworkAdapter>();

            // Ottengo gli adattatori di rete
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            // Itero la lista di adattatori di rete
            foreach (NetworkInterface adapter in adapters)
            {
                // Ottengo il nome dell'adattatore
                var adapterName = adapter.Description;

                // Se l'adattatore non è di tipo Ethernet passo al prossimo adattatore 
                if (adapter.NetworkInterfaceType != NetworkInterfaceType.Ethernet)
                    continue;

                // Aggiungo l'adattatore alla lista degli adapters
                results.Add(new NetworkAdapter() { Name = adapterName, Value = adapter });
            }

            // Restituisco la lista
            return results;
        }

        // Metodo per mostare a video IP e configurazione di un adattatore di rete
        public void DisplayNetworkAdapterInformations(int adapterIndex)
        {
            // Setto il cursore di caricamento
            Cursor.Current = Cursors.WaitCursor;

            // Ottengo l'adattatore dalla lista
            NetworkInterface adapter = networkAdapters[adapterIndex].Value;

            // Ottengo gli adattatori da Windows
            List<NetworkAdapter> adapters = GetNetworkAdapters();

            // Aggiorno nella lista di NetworkAdapters l'adattatore
            IEnumerable<NetworkAdapter> winAdapter = GetNetworkAdapters().Where(adp => adp.Name == networkAdapters[adapterIndex].Name);
            adapter = winAdapter.First().Value;

            // Ottengo le informazioni sull'IP
            IPInterfaceProperties properties = adapter.GetIPProperties();

            // Itero gli UnicastAddresses
            String ipAddress = "SCOLLEGATO";
            foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses)
            {
                // Se l'Address Family dell'indirizzo è InterNetwork leggo l'IP address
                if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress = ip.Address.ToString();
                }
            }

            // Imposto l'IP Address
            LblIpAddress.Text = ipAddress;

            // Cerco nella lista di definizioni IP se c'è quello appena letto
            IEnumerable<IpConfiguration> query = ipConfigurations.Where(ip => ip.IpAddress == ipAddress);

            // Se non ho risultati vuol dire che sono in indirizzo statico custom
            if (query.Count() == 0)
            {
                LblConfigType.Text = "Custom / DHCP";
                Cursor.Current = Cursors.Default;
                return;
            }

            // Ottengo il primo elemento dell'array, lo stampo a video e resetto il cursore
            LblConfigType.Text = query.First().Name;
            Cursor.Current = Cursors.Default;
        }

        // Metodo per impostare un IP statico su un adattatore di rete
        public void SetStaticIP(string ipAddress)
        {
            // Setto il cursore di caricamento
            Cursor.Current = Cursors.WaitCursor;

            // Ottengo le info sull'adattatore di rete scelto
            NetworkInterface networkInterface = networkAdapters[AdaptersComboBox.SelectedIndex].Value;

            // Creo un processo netsh per configurare l'IP in statico e lo avvio
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo("netsh", $"interface ip set address \"{networkInterface.Name}\" static {ipAddress}") { Verb = "runas" }
            };
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();

            // Ottengo l'exit code del processo - 0 = OK
            bool successful = process.ExitCode == 0;
            process.Dispose();

            // Se sono uscito dal processo in modo anomalo mi fermo
            if (!successful)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Impossibile impostare l'IP per l'adattatore di rete scelto", "Errore netsh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creo un processo netsh per configurare i DNS in DHCP e lo avvio
            process = new Process
            {
                StartInfo = new ProcessStartInfo("netsh", $"interface ip set dns \"{networkInterface.Name}\" dhcp") { Verb = "runas" }
            };
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();

            // Ottengo l'exit code del processo
            successful = process.ExitCode == 0;
            process.Dispose();

            // Se sono uscito dal processo in modo anomalo mi fermo
            if (!successful)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Impossibile impostare l'IP per l'adattatore di rete scelto", "Errore netsh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aggiorno le info mostrare a video
            DisplayNetworkAdapterInformations(AdaptersComboBox.SelectedIndex);

            // Mostro popup di avviso IP modificato
            MessageBox.Show("Scheda \"" + networkAdapters[AdaptersComboBox.SelectedIndex].Name + "\" modificata con indirizzo IP statico " 
                + ipAddress, "Modifica indirizzo IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Callback per il cambio di index mostrato
        private void AdaptersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cancello le info sull'adattatore
            LblIpAddress.Text = "";
            LblConfigType.Text = "";

            // Aggiorno le info sull' adattatore
            DisplayNetworkAdapterInformations(AdaptersComboBox.SelectedIndex);
        }

        // Metodo per aggiornare l'IP a Mitsubishi
        private void BtnMitsubishi_Click(object sender, EventArgs e)
        {
            // Ottengo l'indirizzo IP da impostare
            IpConfiguration config = ipConfigurations.Where(i => i.Name.ToLower().Contains("mitsubishi")).FirstOrDefault();

            // Imposto l'indirizzo IP statico
            SetStaticIP(config.IpAddress);
        }

        // Metodo per aggiornare l'IP a Siemens e Lenze (sono uguali)
        private void BtnLenzeSiemens_Click(object sender, EventArgs e)
        {
            // Ottengo l'indirizzo IP da impostare
            IpConfiguration config = ipConfigurations.Where(i => i.Name.ToLower().Contains("siemens")).FirstOrDefault();

            // Imposto l'indirizzo IP statico
            SetStaticIP(config.IpAddress);
        }

        // Metodo per aggiornare l'IP a Siemens per COMAR
        private void BtnSiemensComar_Click(object sender, EventArgs e)
        {
            // Ottengo l'indirizzo IP da impostare
            IpConfiguration config = ipConfigurations.Where(i => i.Name.ToLower().Contains("comar")).FirstOrDefault();

            // Imposto l'indirizzo IP statico
            SetStaticIP(config.IpAddress);
        }

        // Metodo per aggiornare l'IP a Lenze per PLC vergine
        private void BtnLenzeFirst_Click(object sender, EventArgs e)
        {
            // Ottengo l'indirizzo IP da impostare
            IpConfiguration config = ipConfigurations.Where(i => i.Name.ToLower().Contains("avvio")).FirstOrDefault();

            // Imposto l'indirizzo IP statico
            SetStaticIP(config.IpAddress);
        }

        // Metodo per impostare un indirizzo IP custom specificato dall'utente
        private void BtnCustomIP_Click(object sender, EventArgs e)
        {
            // Creo il match pattern per il regex
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            
            // Creo una Regular Expression
            Regex check = new(pattern);

            // Ottengo l'indirizzo IP inserito
            string ipAddress = TxtCustomIP.Text;

            // Se non ho nulla inserito mi fermo
            if (ipAddress == "")
            {
                MessageBox.Show("Inserire un indirizzo IP da impostare", "Errore IP custom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se non posso validare mi fermo
            if (!check.IsMatch(ipAddress, 0))
            {
                MessageBox.Show("L'indirizzo IP inserito non è valido, controlla e riprova", "Errore IP custom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Imposto l'indirizzo IP statico scelto
            SetStaticIP(ipAddress);
        }
    }
}
