﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Start Stop Buttons ausgrauen
            BtnStartServer.Enabled = false;
            BtnStopServer.Enabled = false;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (ServerMonitor.IsProcessRunning())
            {
                RdbServerAn.Checked = true;
                RdbServerAus.Checked = false;

            }
            else
            {
                RdbServerAn.Checked = false;
                RdbServerAus.Checked = true;
            }
            ServerMonitor.UpdateDatabaseServerStatus();
        }

        private void RdbServerAn_CheckedChanged(object sender, EventArgs e)
        {
            ServerMonitor.StartServer();
        }

        private void BtnStartServer_Click(object sender, EventArgs e)
        {
            ServerMonitor.StartServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string host =        TxtHost.Text;
            string user =        TxtUser.Text;
            string password =    TxtPasswort.Text;
            string database =    TxtDatenbank.Text;
            if (host == string.Empty || user == string.Empty || password == string.Empty || database == string.Empty)
            {
                MessageBox.Show("Fülle alle Felder der Datenbank aus");
            }
            else
            {
                ServerMonitor.CreateConnectionString(host, user, password, database);
            }
        }

        private void BtnCreateString_Click(object sender, EventArgs e)
        {
            string host = TxtHost.Text;
            string user = TxtUser.Text;
            string password = TxtPasswort.Text;
            string database = TxtDatenbank.Text;
            string table = TxtTable.Text;
            string col = TxtColumn.Text;
            ServerMonitor.processName = TxtProcess.Text;
            ServerMonitor.col = col;
            ServerMonitor.table = table;
            ServerMonitor.CreateConnectionString(host, user, password, database);
        }
    }
}

