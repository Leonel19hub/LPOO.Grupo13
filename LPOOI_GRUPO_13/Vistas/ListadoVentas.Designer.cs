namespace Vistas
{
    partial class ListadoVentas
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
            this.lbListadoVentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListadoVentas
            // 
            this.lbListadoVentas.FormattingEnabled = true;
            this.lbListadoVentas.ItemHeight = 16;
            this.lbListadoVentas.Location = new System.Drawing.Point(45, 50);
            this.lbListadoVentas.Margin = new System.Windows.Forms.Padding(4);
            this.lbListadoVentas.Name = "lbListadoVentas";
            this.lbListadoVentas.Size = new System.Drawing.Size(769, 180);
            this.lbListadoVentas.TabIndex = 0;
            this.lbListadoVentas.SelectedIndexChanged += new System.EventHandler(this.lbListadoVentas_SelectedIndexChanged);
            // 
            // ListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 417);
            this.Controls.Add(this.lbListadoVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListadoVentas";
            this.Text = "ListadoVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListadoVentas;


    }
}