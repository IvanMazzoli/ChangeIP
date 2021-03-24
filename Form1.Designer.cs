
namespace ChangeIP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AdaptersComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSiemensComar = new System.Windows.Forms.Button();
            this.BtnDHCP = new System.Windows.Forms.Button();
            this.BtnSiemens = new System.Windows.Forms.Button();
            this.BtnLenzeFirst = new System.Windows.Forms.Button();
            this.BtnLenze = new System.Windows.Forms.Button();
            this.BtnMitsubishi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtCustomIP = new System.Windows.Forms.TextBox();
            this.BtnCustomIP = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblConfigType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblIpAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LblAbout = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.AdaptersComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adattatore di rete";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Ricorda adattatore di rete";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AdaptersComboBox
            // 
            this.AdaptersComboBox.FormattingEnabled = true;
            this.AdaptersComboBox.Location = new System.Drawing.Point(7, 23);
            this.AdaptersComboBox.Name = "AdaptersComboBox";
            this.AdaptersComboBox.Size = new System.Drawing.Size(264, 23);
            this.AdaptersComboBox.TabIndex = 0;
            this.AdaptersComboBox.SelectedIndexChanged += new System.EventHandler(this.AdaptersComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSiemensComar);
            this.groupBox2.Controls.Add(this.BtnDHCP);
            this.groupBox2.Controls.Add(this.BtnSiemens);
            this.groupBox2.Controls.Add(this.BtnLenzeFirst);
            this.groupBox2.Controls.Add(this.BtnLenze);
            this.groupBox2.Controls.Add(this.BtnMitsubishi);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurazione di rete";
            // 
            // BtnSiemensComar
            // 
            this.BtnSiemensComar.Location = new System.Drawing.Point(169, 51);
            this.BtnSiemensComar.Name = "BtnSiemensComar";
            this.BtnSiemensComar.Size = new System.Drawing.Size(102, 23);
            this.BtnSiemensComar.TabIndex = 5;
            this.BtnSiemensComar.Text = "Siemens Comar";
            this.BtnSiemensComar.UseVisualStyleBackColor = true;
            this.BtnSiemensComar.Click += new System.EventHandler(this.BtnSiemensComar_Click);
            // 
            // BtnDHCP
            // 
            this.BtnDHCP.Location = new System.Drawing.Point(7, 51);
            this.BtnDHCP.Name = "BtnDHCP";
            this.BtnDHCP.Size = new System.Drawing.Size(75, 23);
            this.BtnDHCP.TabIndex = 4;
            this.BtnDHCP.Text = "DHCP";
            this.BtnDHCP.UseVisualStyleBackColor = true;
            this.BtnDHCP.Click += new System.EventHandler(this.BtnDHCP_Click);
            // 
            // BtnSiemens
            // 
            this.BtnSiemens.Location = new System.Drawing.Point(88, 51);
            this.BtnSiemens.Name = "BtnSiemens";
            this.BtnSiemens.Size = new System.Drawing.Size(75, 23);
            this.BtnSiemens.TabIndex = 3;
            this.BtnSiemens.Text = "Siemens";
            this.BtnSiemens.UseVisualStyleBackColor = true;
            this.BtnSiemens.Click += new System.EventHandler(this.BtnLenzeSiemens_Click);
            // 
            // BtnLenzeFirst
            // 
            this.BtnLenzeFirst.Location = new System.Drawing.Point(169, 22);
            this.BtnLenzeFirst.Name = "BtnLenzeFirst";
            this.BtnLenzeFirst.Size = new System.Drawing.Size(102, 23);
            this.BtnLenzeFirst.TabIndex = 2;
            this.BtnLenzeFirst.Text = "Lenze 1° avvio";
            this.BtnLenzeFirst.UseVisualStyleBackColor = true;
            this.BtnLenzeFirst.Click += new System.EventHandler(this.BtnLenzeFirst_Click);
            // 
            // BtnLenze
            // 
            this.BtnLenze.Location = new System.Drawing.Point(88, 22);
            this.BtnLenze.Name = "BtnLenze";
            this.BtnLenze.Size = new System.Drawing.Size(75, 23);
            this.BtnLenze.TabIndex = 1;
            this.BtnLenze.Text = "Lenze";
            this.BtnLenze.UseVisualStyleBackColor = true;
            this.BtnLenze.Click += new System.EventHandler(this.BtnLenzeSiemens_Click);
            // 
            // BtnMitsubishi
            // 
            this.BtnMitsubishi.Location = new System.Drawing.Point(7, 23);
            this.BtnMitsubishi.Name = "BtnMitsubishi";
            this.BtnMitsubishi.Size = new System.Drawing.Size(75, 23);
            this.BtnMitsubishi.TabIndex = 0;
            this.BtnMitsubishi.Text = "Mitsubishi";
            this.BtnMitsubishi.UseVisualStyleBackColor = true;
            this.BtnMitsubishi.Click += new System.EventHandler(this.BtnMitsubishi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtCustomIP);
            this.groupBox3.Controls.Add(this.BtnCustomIP);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configurazione custom";
            // 
            // TxtCustomIP
            // 
            this.TxtCustomIP.Location = new System.Drawing.Point(7, 21);
            this.TxtCustomIP.Name = "TxtCustomIP";
            this.TxtCustomIP.Size = new System.Drawing.Size(156, 23);
            this.TxtCustomIP.TabIndex = 6;
            // 
            // BtnCustomIP
            // 
            this.BtnCustomIP.Location = new System.Drawing.Point(169, 21);
            this.BtnCustomIP.Name = "BtnCustomIP";
            this.BtnCustomIP.Size = new System.Drawing.Size(102, 23);
            this.BtnCustomIP.TabIndex = 5;
            this.BtnCustomIP.Text = "Applica";
            this.BtnCustomIP.UseVisualStyleBackColor = true;
            this.BtnCustomIP.Click += new System.EventHandler(this.BtnCustomIP_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LblConfigType);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.LblIpAddress);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(299, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 126);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurazione attuale";
            // 
            // LblConfigType
            // 
            this.LblConfigType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblConfigType.Location = new System.Drawing.Point(6, 88);
            this.LblConfigType.Name = "LblConfigType";
            this.LblConfigType.Size = new System.Drawing.Size(140, 23);
            this.LblConfigType.TabIndex = 3;
            this.LblConfigType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Configurazione";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblIpAddress
            // 
            this.LblIpAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIpAddress.Location = new System.Drawing.Point(6, 42);
            this.LblIpAddress.Name = "LblIpAddress";
            this.LblIpAddress.Size = new System.Drawing.Size(140, 23);
            this.LblIpAddress.TabIndex = 1;
            this.LblIpAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indirizzo IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LblAbout);
            this.groupBox5.Location = new System.Drawing.Point(299, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 92);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "About";
            // 
            // LblAbout
            // 
            this.LblAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAbout.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblAbout.Location = new System.Drawing.Point(7, 19);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(139, 64);
            this.LblAbout.TabIndex = 0;
            this.LblAbout.Text = "© Ivan Mazzoli\r\n2020 - 2021\r\nSource on GitHub.com";
            this.LblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 246);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ChangeIP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox AdaptersComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSiemens;
        private System.Windows.Forms.Button BtnLenzeFirst;
        private System.Windows.Forms.Button BtnLenze;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnDHCP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCustomIP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LblConfigType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblIpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.Button BtnMitsubishi;
        private System.Windows.Forms.TextBox TxtCustomIP;
        private System.Windows.Forms.Button BtnSiemensComar;
    }
}

