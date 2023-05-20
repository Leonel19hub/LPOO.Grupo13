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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioDescripcion = new System.Windows.Forms.RadioButton();
            this.radioCategoria = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodProd
            // 
            this.lblCodProd.AutoSize = true;
            this.lblCodProd.Location = new System.Drawing.Point(72, 99);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(60, 17);
            this.lblCodProd.TabIndex = 0;
            this.lblCodProd.Text = "Codigo: ";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(72, 200);
            this.lblDescProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(86, 17);
            this.lblDescProd.TabIndex = 1;
            this.lblDescProd.Text = "Descripcion:";
            // 
            // lblCatProd
            // 
            this.lblCatProd.AutoSize = true;
            this.lblCatProd.Location = new System.Drawing.Point(72, 266);
            this.lblCatProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatProd.Name = "lblCatProd";
            this.lblCatProd.Size = new System.Drawing.Size(77, 17);
            this.lblCatProd.TabIndex = 2;
            this.lblCatProd.Text = "Categoria: ";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Location = new System.Drawing.Point(72, 341);
            this.lblPrecioProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(56, 17);
            this.lblPrecioProd.TabIndex = 3;
            this.lblPrecioProd.Text = "Precio: ";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(192, 96);
            this.txtCodProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(132, 22);
            this.txtCodProd.TabIndex = 0;
            // 
            // txtCatProd
            // 
            this.txtCatProd.Location = new System.Drawing.Point(192, 262);
            this.txtCatProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatProd.Name = "txtCatProd";
            this.txtCatProd.Size = new System.Drawing.Size(132, 22);
            this.txtCatProd.TabIndex = 3;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(192, 192);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(132, 22);
            this.txtDes.TabIndex = 2;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(192, 332);
            this.txtPrecioProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioProd.TabIndex = 4;
            this.txtPrecioProd.TextChanged += new System.EventHandler(this.txtPrecioProd_TextChanged);
            // 
            // btnAceptarProd
            // 
            this.btnAceptarProd.Location = new System.Drawing.Point(38, 407);
            this.btnAceptarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarProd.Name = "btnAceptarProd";
            this.btnAceptarProd.Size = new System.Drawing.Size(100, 28);
            this.btnAceptarProd.TabIndex = 5;
            this.btnAceptarProd.Text = "Aceptar";
            this.btnAceptarProd.UseVisualStyleBackColor = true;
            this.btnAceptarProd.Click += new System.EventHandler(this.btnAceptarProd_Click);
            // 
            // btnAtrasProd
            // 
            this.btnAtrasProd.Location = new System.Drawing.Point(28, 479);
            this.btnAtrasProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtrasProd.Name = "btnAtrasProd";
            this.btnAtrasProd.Size = new System.Drawing.Size(100, 28);
            this.btnAtrasProd.TabIndex = 6;
            this.btnAtrasProd.Text = "Atras";
            this.btnAtrasProd.UseVisualStyleBackColor = true;
            this.btnAtrasProd.Click += new System.EventHandler(this.btnAtrasProd_Click);
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Location = new System.Drawing.Point(383, 33);
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.RowTemplate.Height = 24;
            this.dataGridProducto.Size = new System.Drawing.Size(734, 377);
            this.dataGridProducto.TabIndex = 6;
            this.dataGridProducto.CurrentCellChanged += new System.EventHandler(this.dataGridProducto_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registrar Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(192, 145);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ordenar por: ";
            // 
            // radioDescripcion
            // 
            this.radioDescripcion.AutoSize = true;
            this.radioDescripcion.Location = new System.Drawing.Point(558, 464);
            this.radioDescripcion.Name = "radioDescripcion";
            this.radioDescripcion.Size = new System.Drawing.Size(103, 21);
            this.radioDescripcion.TabIndex = 10;
            this.radioDescripcion.TabStop = true;
            this.radioDescripcion.Text = "Descripcion";
            this.radioDescripcion.UseVisualStyleBackColor = true;
            // 
            // radioCategoria
            // 
            this.radioCategoria.AutoSize = true;
            this.radioCategoria.Location = new System.Drawing.Point(709, 464);
            this.radioCategoria.Name = "radioCategoria";
            this.radioCategoria.Size = new System.Drawing.Size(90, 21);
            this.radioCategoria.TabIndex = 11;
            this.radioCategoria.TabStop = true;
            this.radioCategoria.Text = "Categoria";
            this.radioCategoria.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(872, 457);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(168, 36);
            this.btnOrdenar.TabIndex = 12;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(254, 407);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(147, 407);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 533);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.radioCategoria);
            this.Controls.Add(this.radioDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioDescripcion;
        private System.Windows.Forms.RadioButton radioCategoria;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
    }
}