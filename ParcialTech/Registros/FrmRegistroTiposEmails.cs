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
    public partial class FrmRegistroTiposEmails : Form
    {
        public FrmRegistroTiposEmails()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            tipoIdTextBox.Clear();
            descripcionTextBox.Clear();
            descripcionTextBox.Focus();
        }
        
        private bool Validar()
        {
            if (descripcionTextBox.Text == "")
            {
                errorProvider.SetError(descripcionTextBox, "Digite la descripción");
                return false;
            }
            return true;
        }

        private Entidades.TipoEmail GetInstanceCampos()
        {
            return new Entidades.TipoEmail(Utilidad.ToInt(tipoIdTextBox.Text), descripcionTextBox.Text);
        }

        private void FrmRegistroTiposEmails_Load(object sender, EventArgs e)
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
                if (BLL.TipoEmailBLL.Guardar(GetInstanceCampos()))
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
            if (!(tipoIdTextBox.Text == ""))
            {
                if (BLL.TipoEmailBLL.Eliminar(GetInstanceCampos()))
                {
                    MessageBox.Show("Eliminado con éxito!");
                }
                else
                {
                    MessageBox.Show("Algo salió mal...");
                }
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (!(tipoIdTextBox.Text == ""))
            {
                Entidades.TipoEmail tipoEmail = BLL.TipoEmailBLL.Buscar(Utilidad.ToInt(tipoIdTextBox.Text));
                if (tipoEmail != null)
                {
                    descripcionTextBox.Text = tipoEmail.Descripcion;
                }
                else
                {
                    MessageBox.Show("No encotrado...");
                }
            }
        }
    }
}
