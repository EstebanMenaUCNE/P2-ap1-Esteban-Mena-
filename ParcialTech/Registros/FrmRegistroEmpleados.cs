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
    public partial class FrmRegistroEmpleados : Form
    {
        Entidades.Empleados empleado;
        Entidades.Retenciones retencionSeleccionada;
        Entidades.EmpleadosEmails detalle;

        public FrmRegistroEmpleados()
        {
            InitializeComponent();
        }
        
        private void FrmRegistroEmpleados_Load(object sender, EventArgs e)
        {
            empleado = new Entidades.Empleados();
            detalle = new Entidades.EmpleadosEmails("");
        }

        private void Limpiar()
        {
            empleado = new Entidades.Empleados();
            retencionSeleccionada = null;
            detalle = new Entidades.EmpleadosEmails("");
            retencionesDataGridView.DataSource = null;
            emailsDataGridView.DataSource = null;
            empleadoIdTextBox.Clear();
            nombresTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            sueldoTextBox.Clear();
            retencionIdTextBox.Clear();
            retencionDescripcionTextBox.Clear();
            retencionValorTextBox.Clear();
            emailIdTextBox.Clear();
            emailTipoTextBox.Clear();
            emailEmailTextBox.Clear();
            nombresTextBox.Focus();
        }

        private bool Validar()
        {
            bool flag = true;
            if (nombresTextBox.Text == "")
            {
                errorProvider.SetError(nombresTextBox, "Digite el nombre");
                flag = false;
            }
            if (sueldoTextBox.Text == "")
            {
                errorProvider.SetError(sueldoTextBox, "Digite el sueldo");
                flag = false;
            }

            return flag;
        }

        private void LlenarCamposEmpleado()
        {
            empleado.Nombres = nombresTextBox.Text;
            empleado.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
            empleado.Sueldo = Utilidad.ToDouble(sueldoTextBox.Text);
        }

        private void LlenarGridRetenciones()
        {
            retencionesDataGridView.DataSource = null;
            retencionesDataGridView.DataSource = empleado.Retenciones;
        }

        private void LlenarGridEmails()
        {
            emailsDataGridView.DataSource = null;
            emailsDataGridView.DataSource = empleado.EmpleadosEmails.ToList();

            this.emailsDataGridView.Columns["Id"].Visible = false;
            this.emailsDataGridView.Columns["EmpleadoId"].Visible = false;
            this.emailsDataGridView.Columns["TipoId"].Visible = false;
        }

        private void retencionIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int id = Utilidad.ToInt(retencionIdTextBox.Text);

            if (e.KeyChar == (char)Keys.Enter)
            {
                Entidades.Retenciones retencion = BLL.RetencionBLL.Buscar(id);
                if (retencion != null)
                {
                    retencionDescripcionTextBox.Text = retencion.Descripcion;
                    retencionValorTextBox.Text = retencion.Valor.ToString();
                    retencionSeleccionada = retencion;
                }
                else
                {
                    MessageBox.Show("Retencion no encontrada...");
                }
                  
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (retencionSeleccionada != null)
            {
                empleado.Retenciones.Add(retencionSeleccionada);
                LlenarGridRetenciones();
            }
            else
            {
                MessageBox.Show("Ninguna retencion seleccionada...");
            }
            
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposEmpleado();
                if (BLL.EmpleadoBLL.Guardar(empleado))
                {
                    MessageBox.Show("Guardado con éxito!");
                }
                else
                {
                    MessageBox.Show("Algo salió mal...");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (empleadoIdTextBox.Text != "")
            {
                if (BLL.EmpleadoBLL.Eliminar(empleado))
                {
                    MessageBox.Show("Eliminado con éxito");
                }
                else
                {
                    MessageBox.Show("Algo salió mal...");
                }
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (empleadoIdTextBox.Text != "")
            {
                empleado = BLL.EmpleadoBLL.Buscar(Utilidad.ToInt(empleadoIdTextBox.Text));
                if (empleado != null)
                {
                    nombresTextBox.Text = empleado.Nombres;
                    fechaNacimientoDateTimePicker.Value = empleado.FechaNacimiento;
                    sueldoTextBox.Text = empleado.Sueldo.ToString();
                    LlenarGridRetenciones();
                    LlenarGridEmails();
                }
                else
                {
                    MessageBox.Show("No encontrado...");
                }
            }
        }

        private void emailIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int id = Utilidad.ToInt(emailIdTextBox.Text);

            if (e.KeyChar == (char)Keys.Enter)
            {
                detalle.TiposEmails = BLL.TipoEmailBLL.Buscar(id);
                if (detalle.TiposEmails != null)
                {
                    emailTipoTextBox.Text = detalle.TiposEmails.Descripcion;
                }
                else
                {
                    MessageBox.Show("TipoEmail no encontrado...");
                }

            }
        }

        private void agregarEmailButton_Click(object sender, EventArgs e)
        {
            if (emailEmailTextBox.Text != "")
            {
                detalle.Email = emailEmailTextBox.Text;
                empleado.AgregarDetalleTipoEmail(detalle);
                LlenarGridEmails();
            }
        }
    }
}
