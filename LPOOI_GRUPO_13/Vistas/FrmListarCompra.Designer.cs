namespace Vistas
{
    partial class FrmListarCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdClientes = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataCompras = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un Cliente: ";
            // 
            // cmdClientes
            // 
            this.cmdClientes.FormattingEnabled = true;
            this.cmdClientes.Location = new System.Drawing.Point(194, 28);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(289, 24);
            this.cmdClientes.TabIndex = 1;
            this.cmdClientes.Text = "Seleccione";
            this.cmdClientes.SelectedIndexChanged += new System.EventHandler(this.cmdClientes_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(500, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataCompras
            // 
            this.dataCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCompras.Location = new System.Drawing.Point(12, 79);
            this.dataCompras.Name = "dataCompras";
            this.dataCompras.RowTemplate.Height = 24;
            this.dataCompras.Size = new System.Drawing.Size(646, 265);
            this.dataCompras.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(500, 371);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 39);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmListarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 422);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataCompras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmdClientes);
            this.Controls.Add(this.label1);
            this.Name = "FrmListarCompra";
            this.Text = "Compras de Cliente";
            this.Load += new System.EventHandler(this.FrmListarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataCompras;
        private System.Windows.Forms.Button btnVolver;
    }
}