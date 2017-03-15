using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech.Registros
{
    public partial class FrmRegistroRetenciones : Form
    {
        public FrmRegistroRetenciones()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            retencionIdTextBox.Clear();
            descripcionTextBox.Clear();
            valorTextBox.Clear();
            descripcionTextBox.Focus();
        }

        private bool Validar()
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                errorProvider.SetError(descripcionTextBox, "Digite la descripcion");
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(valorTextBox.Text))
            {
                errorProvider.SetError(valorTextBox, "Digite el valor");
                flag = false;
            }
            return flag;
        }

        private Retenciones GetRetencionCampos()
        {
            return new Retenciones(Utilidad.ToInt(retencionIdTextBox.Text), descripcionTextBox.Text, Utilidad.ToInt(valorTextBox.Text));
        }

        private void FrmRegistroRetenciones_Load(object sender, EventArgs e)
        {
            
        }

        private void retencionIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(retencionIdTextBox.Text))
            {
                Retenciones retencion = RetencionBLL.Buscar(Utilidad.ToInt(retencionIdTextBox.Text));
                if (retencion != null)
                {
                    descripcionTextBox.Text = retencion.Descripcion;
                    valorTextBox.Text = retencion.Valor.ToString();
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }

        private void retencionIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorLabel_Click(object sender, EventArgs e)
        {

        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (RetencionBLL.Guardar(GetRetencionCampos()))
                {
                    MessageBox.Show("Guardado con éxito!");
                }
                else
                {
                    MessageBox.Show("Algo salió mal...");
                }
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(retencionIdTextBox.Text))
            {
                if (RetencionBLL.Eliminar(GetRetencionCampos()))
                {
                    MessageBox.Show("Eliminado con éxito!");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Algo salió mal...");
                }
            }
        }
    }
}
