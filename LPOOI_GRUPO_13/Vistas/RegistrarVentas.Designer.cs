namespace Vistas
{
    partial class RegistrarVentas
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
            this.cmbRegistVCli = new System.Windows.Forms.ComboBox();
            this.lblRegistVCli = new System.Windows.Forms.Label();
            this.dateTimePickerRegistV = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbRegistVCli
            // 
            this.cmbRegistVCli.FormattingEnabled = true;
            this.cmbRegistVCli.Location = new System.Drawing.Point(181, 39);
            this.cmbRegistVCli.Name = "cmbRegistVCli";
            this.cmbRegistVCli.Size = new System.Drawing.Size(121, 21);
            this.cmbRegistVCli.TabIndex = 0;
            // 
            // lblRegistVCli
            // 
            this.lblRegistVCli.AutoSize = true;
            this.lblRegistVCli.Location = new System.Drawing.Point(39, 42);
            this.lblRegistVCli.Name = "lblRegistVCli";
            this.lblRegistVCli.Size = new System.Drawing.Size(39, 13);
            this.lblRegistVCli.TabIndex = 1;
            this.lblRegistVCli.Text = "Cliente";
            // 
            // dateTimePickerRegistV
            // 
            this.dateTimePickerRegistV.Location = new System.Drawing.Point(69, 87);
            this.dateTimePickerRegistV.Name = "dateTimePickerRegistV";
            this.dateTimePickerRegistV.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRegistV.TabIndex = 2;
            // 
            // RegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 555);
            this.Controls.Add(this.dateTimePickerRegistV);
            this.Controls.Add(this.lblRegistVCli);
            this.Controls.Add(this.cmbRegistVCli);
            this.Name = "RegistrarVentas";
            this.Text = "Registrar Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRegistVCli;
        private System.Windows.Forms.Label lblRegistVCli;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistV;
    }
}