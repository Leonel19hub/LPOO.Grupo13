namespace Vistas
{
    partial class FrmAbmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtNroCarnet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbDni = new System.Windows.Forms.RadioButton();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.panelSlideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelSlideMenu.Controls.Add(this.cmbObraSocial);
            this.panelSlideMenu.Controls.Add(this.btnClean);
            this.panelSlideMenu.Controls.Add(this.txtNroCarnet);
            this.panelSlideMenu.Controls.Add(this.label7);
            this.panelSlideMenu.Controls.Add(this.label6);
            this.panelSlideMenu.Controls.Add(this.btnEliminar);
            this.panelSlideMenu.Controls.Add(this.btnEditar);
            this.panelSlideMenu.Controls.Add(this.btnSalir);
            this.panelSlideMenu.Controls.Add(this.btnAgregar);
            this.panelSlideMenu.Controls.Add(this.txtDireccion);
            this.panelSlideMenu.Controls.Add(this.txtNombre);
            this.panelSlideMenu.Controls.Add(this.txtApellido);
            this.panelSlideMenu.Controls.Add(this.txtDni);
            this.panelSlideMenu.Controls.Add(this.label5);
            this.panelSlideMenu.Controls.Add(this.label4);
            this.panelSlideMenu.Controls.Add(this.label3);
            this.panelSlideMenu.Controls.Add(this.label2);
            this.panelSlideMenu.Controls.Add(this.label1);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(368, 553);
            this.panelSlideMenu.TabIndex = 9;
            // 
            // btnClean
            // 
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnClean.FlatAppearance.BorderSize = 3;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClean.Location = new System.Drawing.Point(250, 507);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(107, 40);
            this.btnClean.TabIndex = 23;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            this.btnClean.MouseEnter += new System.EventHandler(this.btnClean_MouseEnter);
            this.btnClean.MouseLeave += new System.EventHandler(this.btnClean_MouseLeave);
            // 
            // txtNroCarnet
            // 
            this.txtNroCarnet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCarnet.Location = new System.Drawing.Point(133, 385);
            this.txtNroCarnet.Name = "txtNroCarnet";
            this.txtNroCarnet.Size = new System.Drawing.Size(224, 26);
            this.txtNroCarnet.TabIndex = 5;
            this.txtNroCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCarnet_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(13, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "N° Carnet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(12, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "CUIT";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.Location = new System.Drawing.Point(249, 454);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.btnEliminar_MouseEnter);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnEditar.FlatAppearance.BorderSize = 3;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditar.Location = new System.Drawing.Point(131, 454);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 40);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.Location = new System.Drawing.Point(12, 454);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(133, 287);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(224, 26);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(133, 238);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(133, 189);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(224, 26);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(133, 140);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(224, 26);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(13, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(13, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(13, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(89, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(419, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(516, 28);
            this.txtBuscar.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnBuscar.FlatAppearance.BorderSize = 3;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Location = new System.Drawing.Point(952, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 40);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdenar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(39)))), ((int)(((byte)(73)))));
            this.btnOrdenar.FlatAppearance.BorderSize = 3;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOrdenar.Location = new System.Drawing.Point(952, 501);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(107, 40);
            this.btnOrdenar.TabIndex = 19;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            this.btnOrdenar.MouseEnter += new System.EventHandler(this.btnOrdenar_MouseEnter);
            this.btnOrdenar.MouseLeave += new System.EventHandler(this.btnOrdenar_MouseLeave);
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCliente.ColumnHeadersHeight = 40;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCliente.EnableHeadersVisualStyles = false;
            this.dataGridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(71)))), ((int)(((byte)(106)))));
            this.dataGridCliente.Location = new System.Drawing.Point(419, 72);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(71)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(71)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridCliente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCliente.RowTemplate.Height = 24;
            this.dataGridCliente.Size = new System.Drawing.Size(640, 404);
            this.dataGridCliente.TabIndex = 29;
            this.dataGridCliente.CurrentCellChanged += new System.EventHandler(this.dataGridCliente_CurrentCellChanged);
            // 
            // rbApellido
            // 
            this.rbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbApellido.AutoSize = true;
            this.rbApellido.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApellido.ForeColor = System.Drawing.Color.White;
            this.rbApellido.Location = new System.Drawing.Point(623, 508);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(110, 27);
            this.rbApellido.TabIndex = 31;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.ForeColor = System.Drawing.Color.White;
            this.rbNombre.Location = new System.Drawing.Point(744, 508);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(106, 27);
            this.rbNombre.TabIndex = 32;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbDni
            // 
            this.rbDni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDni.AutoSize = true;
            this.rbDni.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDni.ForeColor = System.Drawing.Color.White;
            this.rbDni.Location = new System.Drawing.Point(872, 508);
            this.rbDni.Name = "rbDni";
            this.rbDni.Size = new System.Drawing.Size(63, 27);
            this.rbDni.TabIndex = 33;
            this.rbDni.TabStop = true;
            this.rbDni.Text = "DNI";
            this.rbDni.UseVisualStyleBackColor = true;
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(133, 339);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(223, 24);
            this.cmbObraSocial.TabIndex = 24;
            // 
            // FrmAbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.rbDni);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.rbApellido);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dataGridCliente);
            this.Controls.Add(this.panelSlideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbmCliente";
            this.Text = "FrmAbmCliente";
            this.Load += new System.EventHandler(this.FrmAbmCliente_Load);
            this.panelSlideMenu.ResumeLayout(false);
            this.panelSlideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtNroCarnet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDni;
        private System.Windows.Forms.ComboBox cmbObraSocial;
    }
}