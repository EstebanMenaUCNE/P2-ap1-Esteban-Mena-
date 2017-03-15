namespace ParcialTech.Consultas
{
    partial class FrmConsultaRetenciones
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
            this.retencionesDataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarComboBox = new System.Windows.Forms.ComboBox();
            this.filtrarLabel = new System.Windows.Forms.Label();
            this.filtrarTextBox = new System.Windows.Forms.TextBox();
            this.filtrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.retencionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // retencionesDataGridView
            // 
            this.retencionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.retencionesDataGridView.Location = new System.Drawing.Point(34, 73);
            this.retencionesDataGridView.Name = "retencionesDataGridView";
            this.retencionesDataGridView.Size = new System.Drawing.Size(441, 131);
            this.retencionesDataGridView.TabIndex = 1;
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Sin filtro",
            "Descripcion",
            "Valor"});
            this.filtrarComboBox.Location = new System.Drawing.Point(93, 35);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarComboBox.TabIndex = 2;
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Location = new System.Drawing.Point(31, 38);
            this.filtrarLabel.Name = "filtrarLabel";
            this.filtrarLabel.Size = new System.Drawing.Size(50, 13);
            this.filtrarLabel.TabIndex = 3;
            this.filtrarLabel.Text = "Filtrar por";
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Location = new System.Drawing.Point(220, 35);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(174, 20);
            this.filtrarTextBox.TabIndex = 4;
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(400, 33);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 23);
            this.filtrarButton.TabIndex = 5;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // FrmConsultaRetenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 230);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.filtrarTextBox);
            this.Controls.Add(this.filtrarLabel);
            this.Controls.Add(this.filtrarComboBox);
            this.Controls.Add(this.retencionesDataGridView);
            this.Name = "FrmConsultaRetenciones";
            this.Text = "FrmConsultaRetenciones";
            this.Load += new System.EventHandler(this.FrmConsultaRetenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.retencionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView retencionesDataGridView;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.Button filtrarButton;
    }
}