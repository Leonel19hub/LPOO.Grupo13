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
            this.dateVenta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.groupBoxVentaDetalle = new System.Windows.Forms.GroupBox();
            this.cmdNroVenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdProducto = new System.Windows.Forms.ComboBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.groupBoxVentaDetalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRegistVCli
            // 
            this.cmbRegistVCli.FormattingEnabled = true;
            this.cmbRegistVCli.Location = new System.Drawing.Point(201, 45);
            this.cmbRegistVCli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRegistVCli.Name = "cmbRegistVCli";
            this.cmbRegistVCli.Size = new System.Drawing.Size(241, 24);
            this.cmbRegistVCli.TabIndex = 0;
            // 
            // lblRegistVCli
            // 
            this.lblRegistVCli.AutoSize = true;
            this.lblRegistVCli.Location = new System.Drawing.Point(58, 48);
            this.lblRegistVCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistVCli.Name = "lblRegistVCli";
            this.lblRegistVCli.Size = new System.Drawing.Size(51, 17);
            this.lblRegistVCli.TabIndex = 1;
            this.lblRegistVCli.Text = "Cliente";
            // 
            // dateVenta
            // 
            this.dateVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVenta.Location = new System.Drawing.Point(201, 92);
            this.dateVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dateVenta.Name = "dateVenta";
            this.dateVenta.Size = new System.Drawing.Size(241, 22);
            this.dateVenta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(242, 132);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(200, 35);
            this.btnGenerarFactura.TabIndex = 4;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // groupBoxVentaDetalle
            // 
            this.groupBoxVentaDetalle.Controls.Add(this.cmdNroVenta);
            this.groupBoxVentaDetalle.Controls.Add(this.label2);
            this.groupBoxVentaDetalle.Controls.Add(this.btnCargarProducto);
            this.groupBoxVentaDetalle.Controls.Add(this.textBoxPrecio);
            this.groupBoxVentaDetalle.Controls.Add(this.textBoxTotal);
            this.groupBoxVentaDetalle.Controls.Add(this.label7);
            this.groupBoxVentaDetalle.Controls.Add(this.label6);
            this.groupBoxVentaDetalle.Controls.Add(this.label9);
            this.groupBoxVentaDetalle.Controls.Add(this.label8);
            this.groupBoxVentaDetalle.Controls.Add(this.cmdProducto);
            this.groupBoxVentaDetalle.Controls.Add(this.textBoxCantidad);
            this.groupBoxVentaDetalle.Location = new System.Drawing.Point(681, 204);
            this.groupBoxVentaDetalle.Name = "groupBoxVentaDetalle";
            this.groupBoxVentaDetalle.Size = new System.Drawing.Size(450, 305);
            this.groupBoxVentaDetalle.TabIndex = 20;
            this.groupBoxVentaDetalle.TabStop = false;
            this.groupBoxVentaDetalle.Text = "Cargar Producto";
            // 
            // cmdNroVenta
            // 
            this.cmdNroVenta.FormattingEnabled = true;
            this.cmdNroVenta.Location = new System.Drawing.Point(217, 213);
            this.cmdNroVenta.Name = "cmdNroVenta";
            this.cmdNroVenta.Size = new System.Drawing.Size(225, 24);
            this.cmdNroVenta.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "N° de Venta: ";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(242, 254);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(200, 45);
            this.btnCargarProducto.TabIndex = 24;
            this.btnCargarProducto.Text = "Cargar Producto";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(217, 84);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(225, 22);
            this.textBoxPrecio.TabIndex = 14;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(217, 171);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(225, 22);
            this.textBoxTotal.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cantidad:";
            // 
            // cmdProducto
            // 
            this.cmdProducto.FormattingEnabled = true;
            this.cmdProducto.Location = new System.Drawing.Point(217, 47);
            this.cmdProducto.Name = "cmdProducto";
            this.cmdProducto.Size = new System.Drawing.Size(225, 24);
            this.cmdProducto.TabIndex = 16;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(217, 127);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(225, 22);
            this.textBoxCantidad.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerarFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateVenta);
            this.groupBox1.Controls.Add(this.lblRegistVCli);
            this.groupBox1.Controls.Add(this.cmbRegistVCli);
            this.groupBox1.Location = new System.Drawing.Point(681, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 186);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nro de Venta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(651, 186);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Location = new System.Drawing.Point(12, 211);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.RowTemplate.Height = 24;
            this.dataGridProductos.Size = new System.Drawing.Size(651, 356);
            this.dataGridProductos.TabIndex = 24;
            // 
            // RegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 579);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxVentaDetalle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrarVentas";
            this.Text = "Registrar Ventas";
            this.Load += new System.EventHandler(this.RegistrarVentas_Load);
            this.groupBoxVentaDetalle.ResumeLayout(false);
            this.groupBoxVentaDetalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRegistVCli;
        private System.Windows.Forms.Label lblRegistVCli;
        private System.Windows.Forms.DateTimePicker dateVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.GroupBox groupBoxVentaDetalle;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmdProducto;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.ComboBox cmdNroVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridProductos;
    }
}