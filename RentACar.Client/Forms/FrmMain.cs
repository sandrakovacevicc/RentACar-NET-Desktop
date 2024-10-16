using RentACar.Client.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Client.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            KlijentToolStripMenuItem.Click += (s, a) => MainCoordinator.Instance.ShowKlijenti();
            VozilaToolStripMenuItem.Click += (s, a) => MainCoordinator.Instance.ShowVozila();
            ZakazivanjaToolStripMenuItem1.Click += (s, a) => MainCoordinator.Instance.ShowZakazivanja();
            odjaviSeToolStripMenuItem.Click += (s, a) => MainCoordinator.Instance.ShowOdjava();

        }


        public void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               MainCoordinator.Instance.ShowOdjava();
            }
        }
    }
    }

