using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech.Consultas
{
    public partial class FrmConsultaTiposEmail : Form
    {
        public FrmConsultaTiposEmail()
        {
            InitializeComponent();
        }

        private void FrmConsultaTiposEmail_Load(object sender, EventArgs e)
        {
            filtrarComboBox.Text = "Sin filtro";
        }

        private void Filtrar()
        {
            if (filtrarComboBox.Text == "Descripcion")
            {
                tiposEmailDataGridView.DataSource = BLL.TipoEmailBLL.GetList(R => R.Descripcion == filtrarTextBox.Text);
            }
            else
            {
                tiposEmailDataGridView.DataSource = BLL.TipoEmailBLL.GetList(R => R.TipoId > 0);
            }
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
