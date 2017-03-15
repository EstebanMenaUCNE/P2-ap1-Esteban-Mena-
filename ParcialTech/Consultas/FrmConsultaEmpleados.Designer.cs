namespace ParcialTech.Consultas
{
    partial class FrmConsultaEmpleados
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
            this.filtrarButton = new System.Windows.Forms.Button();
            this.filtrarTextBox = new System.Windows.Forms.TextBox();
            this.filtrarLabel = new System.Windows.Forms.Label();
            this.filtrarComboBox = new System.Windows.Forms.ComboBox();
            this.empleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(424, 45);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 23);
            this.filtrarButton.TabIndex = 15;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Location = new System.Drawing.Point(244, 47);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(174, 20);
            this.filtrarTextBox.TabIndex = 14;
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Location = new System.Drawing.Point(55, 50);
            this.filtrarLabel.Name = "filtrarLabel";
            this.filtrarLabel.Size = new System.Drawing.Size(50, 13);
            this.filtrarLabel.TabIndex = 13;
            this.filtrarLabel.Text = "Filtrar por";
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Sin filtro",
            "Nombre",
            "Fecha Nacimiento",
            "Ambos"});
            this.filtrarComboBox.Location = new System.Drawing.Point(117, 47);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarComboBox.TabIndex = 12;
            // 
            // empleadosDataGridView
            // 
            this.empleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataGridView.Location = new System.Drawing.Point(58, 100);
            this.empleadosDataGridView.Name = "empleadosDataGridView";
            this.empleadosDataGridView.Size = new System.Drawing.Size(441, 131);
            this.empleadosDataGridView.TabIndex = 11;
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(117, 74);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.desdeDateTimePicker.TabIndex = 16;
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDateTimePicker.Location = new System.Drawing.Point(297, 74);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.hastaDateTimePicker.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hasta";
            // 
            // FrmConsultaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.filtrarTextBox);
            this.Controls.Add(this.filtrarLabel);
            this.Controls.Add(this.filtrarComboBox);
            this.Controls.Add(this.empleadosDataGridView);
            this.Name = "FrmConsultaEmpleados";
            this.Text = "FrmConsultaEmpleado";
            this.Load += new System.EventHandler(this.FrmConsultaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.DataGridView empleadosDataGridView;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}