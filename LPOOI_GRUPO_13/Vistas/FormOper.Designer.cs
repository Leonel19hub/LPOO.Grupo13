namespace Vistas
{
    partial class FormOper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msSistInquilinos = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.msSistInquilinos,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(626, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.principalToolStripMenuItem.Text = "Inicio";
            // 
            // msSistInquilinos
            // 
            this.msSistInquilinos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeClientesToolStripMenuItem});
            this.msSistInquilinos.Name = "msSistInquilinos";
            this.msSistInquilinos.Size = new System.Drawing.Size(73, 24);
            this.msSistInquilinos.Text = "Clientes";
            this.msSistInquilinos.Click += new System.EventHandler(this.msSistInquilinos_Click);
            // 
            // altaDeClientesToolStripMenuItem
            // 
            this.altaDeClientesToolStripMenuItem.Name = "altaDeClientesToolStripMenuItem";
            this.altaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.altaDeClientesToolStripMenuItem.Text = "Alta de Clientes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.mostrarListaDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            // 
            // mostrarListaDeVentasToolStripMenuItem
            // 
            this.mostrarListaDeVentasToolStripMenuItem.Name = "mostrarListaDeVentasToolStripMenuItem";
            this.mostrarListaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.mostrarListaDeVentasToolStripMenuItem.Text = "Mostrar Lista De Ventas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(495, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 346);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormOper";
            this.Text = "FormOper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msSistInquilinos;
        private System.Windows.Forms.ToolStripMenuItem altaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaDeVentasToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}