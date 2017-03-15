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
    public partial class FrmConsultaRetenciones : Form
    {
        public FrmConsultaRetenciones()
        {
            InitializeComponent();
        }

        private void FrmConsultaRetenciones_Load(object sender, EventArgs e)
        {
            filtrarComboBox.Text = "Sin filtro";
        }

        private void Filtrar()
        {
            if (filtrarComboBox.Text == "Descripcion")
            {
                retencionesDataGridView.DataSource = BLL.RetencionBLL.GetList(R => R.Descripcion == filtrarTextBox.Text);
            }
            else if (filtrarComboBox.Text == "Valor")
            {
                retencionesDataGridView.DataSource = BLL.RetencionBLL.GetList(R => R.Valor == Utilidad.ToInt(filtrarTextBox.Text));
            }
            else
            {
                retencionesDataGridView.DataSource = BLL.RetencionBLL.GetList(R => R.RetencionId > 0);
            }
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
