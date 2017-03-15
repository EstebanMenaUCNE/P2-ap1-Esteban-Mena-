namespace ParcialTech.Consultas
{
    partial class FrmConsultaTiposEmail
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
            this.tiposEmailDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tiposEmailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(384, 45);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 23);
            this.filtrarButton.TabIndex = 10;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Location = new System.Drawing.Point(204, 47);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(174, 20);
            this.filtrarTextBox.TabIndex = 9;
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Location = new System.Drawing.Point(15, 50);
            this.filtrarLabel.Name = "filtrarLabel";
            this.filtrarLabel.Size = new System.Drawing.Size(50, 13);
            this.filtrarLabel.TabIndex = 8;
            this.filtrarLabel.Text = "Filtrar por";
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Sin filtro",
            "Descripcion"});
            this.filtrarComboBox.Location = new System.Drawing.Point(77, 47);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarComboBox.TabIndex = 7;
            // 
            // tiposEmailDataGridView
            // 
            this.tiposEmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tiposEmailDataGridView.Location = new System.Drawing.Point(18, 85);
            this.tiposEmailDataGridView.Name = "tiposEmailDataGridView";
            this.tiposEmailDataGridView.Size = new System.Drawing.Size(441, 131);
            this.tiposEmailDataGridView.TabIndex = 6;
            // 
            // FrmConsultaTiposEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 261);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.filtrarTextBox);
            this.Controls.Add(this.filtrarLabel);
            this.Controls.Add(this.filtrarComboBox);
            this.Controls.Add(this.tiposEmailDataGridView);
            this.Name = "FrmConsultaTiposEmail";
            this.Text = "FrmConsultaTiposEmail";
            this.Load += new System.EventHandler(this.FrmConsultaTiposEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiposEmailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.DataGridView tiposEmailDataGridView;
    }
}