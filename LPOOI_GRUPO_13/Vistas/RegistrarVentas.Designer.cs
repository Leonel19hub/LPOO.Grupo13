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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxVentaDetalle = new System.Windows.Forms.GroupBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxVentaDetalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRegistVCli
            // 
            this.cmbRegistVCli.FormattingEnabled = true;
            this.cmbRegistVCli.Location = new System.Drawing.Point(164, 45);
            this.cmbRegistVCli.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRegistVCli.Name = "cmbRegistVCli";
            this.cmbRegistVCli.Size = new System.Drawing.Size(316, 24);
            this.cmbRegistVCli.TabIndex = 0;
            // 
            // lblRegistVCli
            // 
            this.lblRegistVCli.AutoSize = true;
            this.lblRegistVCli.Location = new System.Drawing.Point(21, 48);
            this.lblRegistVCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistVCli.Name = "lblRegistVCli";
            this.lblRegistVCli.Size = new System.Drawing.Size(51, 17);
            this.lblRegistVCli.TabIndex = 1;
            this.lblRegistVCli.Text = "Cliente";
            // 
            // dateTimePickerRegistV
            // 
            this.dateTimePickerRegistV.Location = new System.Drawing.Point(164, 92);
            this.dateTimePickerRegistV.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerRegistV.Name = "dateTimePickerRegistV";
            this.dateTimePickerRegistV.Size = new System.Drawing.Size(316, 22);
            this.dateTimePickerRegistV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Factura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxVentaDetalle
            // 
            this.groupBoxVentaDetalle.Controls.Add(this.buttonModificar);
            this.groupBoxVentaDetalle.Controls.Add(this.buttonEliminar);
            this.groupBoxVentaDetalle.Controls.Add(this.textBoxPrecio);
            this.groupBoxVentaDetalle.Controls.Add(this.textBoxTotal);
            this.groupBoxVentaDetalle.Controls.Add(this.label7);
            this.groupBoxVentaDetalle.Controls.Add(this.label6);
            this.groupBoxVentaDetalle.Controls.Add(this.label9);
            this.groupBoxVentaDetalle.Controls.Add(this.label8);
            this.groupBoxVentaDetalle.Controls.Add(this.comboBoxProductos);
            this.groupBoxVentaDetalle.Controls.Add(this.buttonRegistrar);
            this.groupBoxVentaDetalle.Controls.Add(this.textBoxCantidad);
            this.groupBoxVentaDetalle.Location = new System.Drawing.Point(491, 266);
            this.groupBoxVentaDetalle.Name = "groupBoxVentaDetalle";
            this.groupBoxVentaDetalle.Size = new System.Drawing.Size(640, 239);
            this.groupBoxVentaDetalle.TabIndex = 20;
            this.groupBoxVentaDetalle.TabStop = false;
            this.groupBoxVentaDetalle.Text = "Cargar Producto";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(435, 176);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(166, 37);
            this.buttonModificar.TabIndex = 20;
            this.buttonModificar.Text = "Modificar Producto";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(435, 107);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(166, 37);
            this.buttonEliminar.TabIndex = 19;
            this.buttonEliminar.Text = "Eliminar Producto";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(164, 84);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(225, 22);
            this.textBoxPrecio.TabIndex = 14;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(164, 171);
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
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(164, 47);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(225, 24);
            this.comboBoxProductos.TabIndex = 16;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(435, 40);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(166, 37);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "Cargar Producto";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(164, 127);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(225, 22);
            this.textBoxCantidad.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerRegistV);
            this.groupBox1.Controls.Add(this.lblRegistVCli);
            this.groupBox1.Controls.Add(this.cmbRegistVCli);
            this.groupBox1.Location = new System.Drawing.Point(491, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 229);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nro de Venta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(418, 473);
            this.dataGridView1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(938, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 579);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRegistVCli;
        private System.Windows.Forms.Label lblRegistVCli;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxVentaDetalle;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}