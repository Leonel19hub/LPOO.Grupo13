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
    public partial class FrmListarCompra : Form
    {
        public FrmListarCompra()
        {
            InitializeComponent();
        }

        private void cmdClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmListarCompra_Load(object sender, EventArgs e)
        {
            cmdClientes.SelectedIndex = -1;
            cmdClientes.DisplayMember = "NAME";
            cmdClientes.ValueMember = "Cli_DNI";
            cmdClientes.DataSource = TrabajarVenta.list_clientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        public void compras_clientes_sp() {
            dataCompras.DataSource = TrabajarVenta.listar_compras_cliente_sp(int.Parse(cmdClientes.SelectedValue.ToString()));
        }
    }
}
