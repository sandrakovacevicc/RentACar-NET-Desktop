using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Server
{
    public partial class FrmServer : Form
    {
        Server server;
        public FrmServer()
        {
            InitializeComponent();
            
        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblServerStatus.Text = "Server is up and running...";
            lblServerStatus.ForeColor = Color.Black;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblServerStatus.Text = "Server is down";
            lblServerStatus.ForeColor = Color.DarkRed;
            server.Stop();
        }


        private void FrmServer_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
