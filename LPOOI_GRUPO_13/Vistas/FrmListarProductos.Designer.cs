namespace Vistas
{
    partial class FrmListarProductos
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
            this.btnAtrasProd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmdClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridProdCliente = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProdFechas = new System.Windows.Forms.Button();
            this.dtProdFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtProdFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtGridProdFechas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrasProd
            // 
            this.btnAtrasProd.Location = new System.Drawing.Point(1090, 557);
            this.btnAtrasProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtrasProd.Name = "btnAtrasProd";
            this.btnAtrasProd.Size = new System.Drawing.Size(124, 41);
            this.btnAtrasProd.TabIndex = 7;
            this.btnAtrasProd.Text = "Volver";
            this.btnAtrasProd.UseVisualStyleBackColor = true;
            this.btnAtrasProd.Click += new System.EventHandler(this.btnAtrasProd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGridProdCliente);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmdClientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 535);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos vendidos por Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(393, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 39);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmdClientes
            // 
            this.cmdClientes.FormattingEnabled = true;
            this.cmdClientes.Location = new System.Drawing.Point(164, 44);
            this.cmdClientes.Name = "cmdClientes";
            this.cmdClientes.Size = new System.Drawing.Size(210, 24);
            this.cmdClientes.TabIndex = 4;
            this.cmdClientes.Text = "Seleccione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un Cliente: ";
            // 
            // dtGridProdCliente
            // 
            this.dtGridProdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdCliente.Location = new System.Drawing.Point(9, 107);
            this.dtGridProdCliente.Name = "dtGridProdCliente";
            this.dtGridProdCliente.RowTemplate.Height = 24;
            this.dtGridProdCliente.Size = new System.Drawing.Size(528, 410);
            this.dtGridProdCliente.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridProdFechas);
            this.groupBox2.Controls.Add(this.btnBuscarProdFechas);
            this.groupBox2.Controls.Add(this.dtProdFechaFinal);
            this.groupBox2.Controls.Add(this.dtProdFechaInicio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(562, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 535);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos vendidos entre Fechas";
            // 
            // btnBuscarProdFechas
            // 
            this.btnBuscarProdFechas.Location = new System.Drawing.Point(482, 34);
            this.btnBuscarProdFechas.Name = "btnBuscarProdFechas";
            this.btnBuscarProdFechas.Size = new System.Drawing.Size(154, 42);
            this.btnBuscarProdFechas.TabIndex = 14;
            this.btnBuscarProdFechas.Text = "Buscar";
            this.btnBuscarProdFechas.UseVisualStyleBackColor = true;
            this.btnBuscarProdFechas.Click += new System.EventHandler(this.btnBuscarProdFechas_Click);
            // 
            // dtProdFechaFinal
            // 
            this.dtProdFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProdFechaFinal.Location = new System.Drawing.Point(341, 42);
            this.dtProdFechaFinal.Name = "dtProdFechaFinal";
            this.dtProdFechaFinal.Size = new System.Drawing.Size(126, 22);
            this.dtProdFechaFinal.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Inicio";
            // 
            // dtProdFechaInicio
            // 
            this.dtProdFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProdFechaInicio.Location = new System.Drawing.Point(113, 42);
            this.dtProdFechaInicio.Name = "dtProdFechaInicio";
            this.dtProdFechaInicio.Size = new System.Drawing.Size(126, 22);
            this.dtProdFechaInicio.TabIndex = 10;
            // 
            // dtGridProdFechas
            // 
            this.dtGridProdFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProdFechas.Location = new System.Drawing.Point(12, 107);
            this.dtGridProdFechas.Name = "dtGridProdFechas";
            this.dtGridProdFechas.RowTemplate.Height = 24;
            this.dtGridProdFechas.Size = new System.Drawing.Size(624, 410);
            this.dtGridProdFechas.TabIndex = 15;
            // 
            // FrmListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtrasProd);
            this.Name = "FrmListarProductos";
            this.Text = "Detalle venta producto";
            this.Load += new System.EventHandler(this.FrmListarProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProdFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmdClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridProdCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarProdFechas;
        private System.Windows.Forms.DateTimePicker dtProdFechaFinal;
        private System.Windows.Forms.DateTimePicker dtProdFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGridProdFechas;
    }
}