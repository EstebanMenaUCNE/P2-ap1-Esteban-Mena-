namespace ParcialTech.Registros
{
    partial class FrmRegistroEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sueldoLabel;
            this.empleadoIdTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarRetencionButton = new System.Windows.Forms.Button();
            this.retencionValorTextBox = new System.Windows.Forms.TextBox();
            this.retencionDescripcionTextBox = new System.Windows.Forms.TextBox();
            this.retencionIdTextBox = new System.Windows.Forms.TextBox();
            this.retencionesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agregarEmailButton = new System.Windows.Forms.Button();
            this.emailEmailTextBox = new System.Windows.Forms.TextBox();
            this.emailTipoTextBox = new System.Windows.Forms.TextBox();
            this.emailIdTextBox = new System.Windows.Forms.TextBox();
            this.emailsDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            empleadoIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retencionesDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Location = new System.Drawing.Point(25, 39);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(69, 13);
            empleadoIdLabel.TabIndex = 1;
            empleadoIdLabel.Text = "Empleado Id:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(25, 65);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 3;
            nombresLabel.Text = "Nombres:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(25, 92);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 5;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(25, 117);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(43, 13);
            sueldoLabel.TabIndex = 7;
            sueldoLabel.Text = "Sueldo:";
            // 
            // empleadoIdTextBox
            // 
            this.empleadoIdTextBox.Location = new System.Drawing.Point(127, 36);
            this.empleadoIdTextBox.Name = "empleadoIdTextBox";
            this.empleadoIdTextBox.Size = new System.Drawing.Size(83, 20);
            this.empleadoIdTextBox.TabIndex = 2;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(127, 62);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 4;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(127, 88);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 6;
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.Location = new System.Drawing.Point(127, 114);
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoTextBox.TabIndex = 8;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(215, 34);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 14;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(242, 480);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 13;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Location = new System.Drawing.Point(80, 480);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 23);
            this.nuevoButton.TabIndex = 12;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(161, 480);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 11;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agregarRetencionButton);
            this.groupBox1.Controls.Add(this.retencionValorTextBox);
            this.groupBox1.Controls.Add(this.retencionDescripcionTextBox);
            this.groupBox1.Controls.Add(this.retencionIdTextBox);
            this.groupBox1.Controls.Add(this.retencionesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(28, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 142);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retenciones del Empleado";
            // 
            // agregarRetencionButton
            // 
            this.agregarRetencionButton.Location = new System.Drawing.Point(306, 26);
            this.agregarRetencionButton.Name = "agregarRetencionButton";
            this.agregarRetencionButton.Size = new System.Drawing.Size(41, 23);
            this.agregarRetencionButton.TabIndex = 16;
            this.agregarRetencionButton.Text = "+";
            this.agregarRetencionButton.UseVisualStyleBackColor = true;
            this.agregarRetencionButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // retencionValorTextBox
            // 
            this.retencionValorTextBox.Location = new System.Drawing.Point(214, 28);
            this.retencionValorTextBox.Name = "retencionValorTextBox";
            this.retencionValorTextBox.Size = new System.Drawing.Size(86, 20);
            this.retencionValorTextBox.TabIndex = 3;
            // 
            // retencionDescripcionTextBox
            // 
            this.retencionDescripcionTextBox.Location = new System.Drawing.Point(55, 28);
            this.retencionDescripcionTextBox.Name = "retencionDescripcionTextBox";
            this.retencionDescripcionTextBox.Size = new System.Drawing.Size(153, 20);
            this.retencionDescripcionTextBox.TabIndex = 2;
            // 
            // retencionIdTextBox
            // 
            this.retencionIdTextBox.Location = new System.Drawing.Point(6, 28);
            this.retencionIdTextBox.Name = "retencionIdTextBox";
            this.retencionIdTextBox.Size = new System.Drawing.Size(43, 20);
            this.retencionIdTextBox.TabIndex = 1;
            this.retencionIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.retencionIdTextBox_KeyPress);
            // 
            // retencionesDataGridView
            // 
            this.retencionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.retencionesDataGridView.Location = new System.Drawing.Point(6, 54);
            this.retencionesDataGridView.Name = "retencionesDataGridView";
            this.retencionesDataGridView.Size = new System.Drawing.Size(341, 82);
            this.retencionesDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agregarEmailButton);
            this.groupBox2.Controls.Add(this.emailEmailTextBox);
            this.groupBox2.Controls.Add(this.emailTipoTextBox);
            this.groupBox2.Controls.Add(this.emailIdTextBox);
            this.groupBox2.Controls.Add(this.emailsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(28, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 142);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emails del Empleado";
            // 
            // agregarEmailButton
            // 
            this.agregarEmailButton.Location = new System.Drawing.Point(306, 26);
            this.agregarEmailButton.Name = "agregarEmailButton";
            this.agregarEmailButton.Size = new System.Drawing.Size(41, 23);
            this.agregarEmailButton.TabIndex = 16;
            this.agregarEmailButton.Text = "+";
            this.agregarEmailButton.UseVisualStyleBackColor = true;
            this.agregarEmailButton.Click += new System.EventHandler(this.agregarEmailButton_Click);
            // 
            // emailEmailTextBox
            // 
            this.emailEmailTextBox.Location = new System.Drawing.Point(214, 28);
            this.emailEmailTextBox.Name = "emailEmailTextBox";
            this.emailEmailTextBox.Size = new System.Drawing.Size(86, 20);
            this.emailEmailTextBox.TabIndex = 3;
            // 
            // emailTipoTextBox
            // 
            this.emailTipoTextBox.Location = new System.Drawing.Point(55, 28);
            this.emailTipoTextBox.Name = "emailTipoTextBox";
            this.emailTipoTextBox.Size = new System.Drawing.Size(153, 20);
            this.emailTipoTextBox.TabIndex = 2;
            // 
            // emailIdTextBox
            // 
            this.emailIdTextBox.Location = new System.Drawing.Point(6, 28);
            this.emailIdTextBox.Name = "emailIdTextBox";
            this.emailIdTextBox.Size = new System.Drawing.Size(43, 20);
            this.emailIdTextBox.TabIndex = 1;
            this.emailIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailIdTextBox_KeyPress);
            // 
            // emailsDataGridView
            // 
            this.emailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailsDataGridView.Location = new System.Drawing.Point(6, 54);
            this.emailsDataGridView.Name = "emailsDataGridView";
            this.emailsDataGridView.Size = new System.Drawing.Size(341, 82);
            this.emailsDataGridView.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmRegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoTextBox);
            this.Name = "FrmRegistroEmpleados";
            this.Text = "FrmRegistroEmpleados";
            this.Load += new System.EventHandler(this.FrmRegistroEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retencionesDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox empleadoIdTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox sueldoTextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agregarRetencionButton;
        private System.Windows.Forms.TextBox retencionValorTextBox;
        private System.Windows.Forms.TextBox retencionDescripcionTextBox;
        private System.Windows.Forms.TextBox retencionIdTextBox;
        private System.Windows.Forms.DataGridView retencionesDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button agregarEmailButton;
        private System.Windows.Forms.TextBox emailEmailTextBox;
        private System.Windows.Forms.TextBox emailTipoTextBox;
        private System.Windows.Forms.TextBox emailIdTextBox;
        private System.Windows.Forms.DataGridView emailsDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}