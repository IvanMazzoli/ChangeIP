using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChangeIP
{
    class NetworkAdapter
    {
        // Metodi per ottenere e settare il nome
        public string Name { get; set; }

        // Metodi per ottenere e settare il valore
        public NetworkInterface Value { get; set; }
    }
}
