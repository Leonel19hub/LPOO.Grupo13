using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmListarProductos : Form
    {
        public FrmListarProductos()
        {
            InitializeComponent();
        }

        private void load_clientes()
        {
            //cmdClientes.SelectedIndex = -1;
            cmdClientes.DisplayMember = "NAME";
            cmdClientes.ValueMember = "Cli_DNI";
            cmdClientes.DataSource = TrabajarVenta.list_clientes();
        }

        private void load_productos_x_cliente_sp() {
            dtGridProdCliente.DataSource = TrabajarProducto.listar_productos_x_cliente_sp(cmdClientes.SelectedValue.ToString());
        }

        private void load_producto_entre_fechas_sp() {
            dtGridProdCliente.DataSource = TrabajarProducto.listar_productos_entre_fechas_sp(dtProdFechaInicio.Value, dtProdFechaFinal.Value);
        }

        private void btnAtrasProd_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void FrmListarProductos_Load(object sender, EventArgs e)
        {
            load_clientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtGridProdCliente.DataSource = TrabajarProducto.listar_productos_x_cliente_sp(cmdClientes.SelectedValue.ToString());
            load_productos_x_cliente_sp();
        }

        private void btnBuscarProdFechas_Click(object sender, EventArgs e)
        {
            dtGridProdCliente.DataSource = TrabajarProducto.listar_productos_entre_fechas_sp(dtProdFechaInicio.Value,dtProdFechaFinal.Value);
            load_producto_entre_fechas_sp();
        }
    }
}
