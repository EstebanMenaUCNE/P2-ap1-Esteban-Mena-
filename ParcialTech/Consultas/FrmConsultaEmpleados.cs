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
    public partial class FrmConsultaEmpleados : Form
    {
        public FrmConsultaEmpleados()
        {
            InitializeComponent();
        }

        private void Filtrar()
        {
            if (filtrarComboBox.Text == "Nombre")
            {
                empleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetList(R => R.Nombres == filtrarTextBox.Text);
            }
            else if (filtrarComboBox.Text == "Fecha Nacimiento")
            {
                empleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetList(R => R.FechaNacimiento >= desdeDateTimePicker.Value.Date && R.FechaNacimiento <= hastaDateTimePicker.Value.Date);
            }
            else if (filtrarComboBox.Text == "Ambos")
            {
                empleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetList(R => R.Nombres == filtrarTextBox.Text && R.FechaNacimiento >= desdeDateTimePicker.Value.Date && R.FechaNacimiento <= hastaDateTimePicker.Value.Date);
            }
            else
            {
                empleadosDataGridView.DataSource = BLL.EmpleadoBLL.GetList(R => R.EmpleadoId > 0);
            }
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void FrmConsultaEmpleados_Load(object sender, EventArgs e)
        {
            filtrarComboBox.Text = "Sin filtro";
        }
    }
}
