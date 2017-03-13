using ParcialTech.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void retenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistroRetenciones().Show();
        }

        private void tiposEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistroTiposEmails().Show();
        }
    }
}
