namespace Vistas
{
    partial class AltaProducto
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
            this.lblCodProd = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.lblCatProd = new System.Windows.Forms.Label();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.txtCatProd = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.btnAceptarProd = new System.Windows.Forms.Button();
            this.btnAtrasProd = new System.Windows.Forms.Button();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(57, 184);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(60, 17);
            this.lblCodProd.TabIndex = 0;
            this.lblCodProd.Text = "Codigo: ";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(57, 248);
            this.lblDescProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(86, 17);
            this.lblDescProd.TabIndex = 1;
            this.lblDescProd.Text = "Descripcion:";
            // 
            // lblCatProd
            // 
            this.lblCatProd.AutoSize = true;
            this.lblCatProd.Location = new System.Drawing.Point(57, 314);
            this.lblCatProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatProd.Name = "lblCatProd";
            this.lblCatProd.Size = new System.Drawing.Size(77, 17);
            this.lblCatProd.TabIndex = 2;
            this.lblCatProd.Text = "Categoria: ";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Location = new System.Drawing.Point(57, 389);
            this.lblPrecioProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(56, 17);
            this.lblPrecioProd.TabIndex = 3;
            this.lblPrecioProd.Text = "Precio: ";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(177, 181);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(132, 22);
            this.txtCodProd.TabIndex = 0;
            // 
            // txtCatProd
            // 
            this.txtCatProd.Location = new System.Drawing.Point(177, 310);
            this.txtCatProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatProd.Name = "txtCatProd";
            this.txtCatProd.Size = new System.Drawing.Size(132, 22);
            this.txtCatProd.TabIndex = 2;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(177, 240);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(132, 22);
            this.txtDes.TabIndex = 1;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(177, 380);
            this.txtPrecioProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioProd.TabIndex = 3;
            // 
            // btnAceptarProd
            // 
            this.btnAceptarProd.Location = new System.Drawing.Point(248, 453);
            this.btnAceptarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarProd.Name = "btnAceptarProd";
            this.btnAceptarProd.Size = new System.Drawing.Size(100, 28);
            this.btnAceptarProd.TabIndex = 4;
            this.btnAceptarProd.Text = "Aceptar";
            this.btnAceptarProd.UseVisualStyleBackColor = true;
            this.btnAceptarProd.Click += new System.EventHandler(this.btnAceptarProd_Click);
            // 
            // btnAtrasProd
            // 
            this.btnAtrasProd.Location = new System.Drawing.Point(56, 453);
            this.btnAtrasProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtrasProd.Name = "btnAtrasProd";
            this.btnAtrasProd.Size = new System.Drawing.Size(100, 28);
            this.btnAtrasProd.TabIndex = 5;
            this.btnAtrasProd.Text = "Atras";
            this.btnAtrasProd.UseVisualStyleBackColor = true;
            this.btnAtrasProd.Click += new System.EventHandler(this.btnAtrasProd_Click);
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Location = new System.Drawing.Point(396, 144);
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.RowTemplate.Height = 24;
            this.dataGridProducto.Size = new System.Drawing.Size(734, 337);
            this.dataGridProducto.TabIndex = 6;
            this.dataGridProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProducto_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registrar Producto";
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProducto);
            this.Controls.Add(this.btnAtrasProd);
            this.Controls.Add(this.btnAceptarProd);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtCatProd);
            this.Controls.Add(this.txtCodProd);
            this.Controls.Add(this.lblPrecioProd);
            this.Controls.Add(this.lblCatProd);
            this.Controls.Add(this.lblDescProd);
            this.Controls.Add(this.lblCodProd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltaProducto";
            this.Text = "AltaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodProd;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.Label lblCatProd;
        private System.Windows.Forms.Label lblPrecioProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.TextBox txtCatProd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Button btnAceptarProd;
        private System.Windows.Forms.Button btnAtrasProd;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.Label label1;
    }
}