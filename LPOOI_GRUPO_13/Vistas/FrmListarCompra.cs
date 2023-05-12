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

        private void load_clientes() {
            //cmdClientes.SelectedIndex = -1;
            cmdClientes.DisplayMember = "NAME";
            cmdClientes.ValueMember = "Cli_DNI";
            cmdClientes.DataSource = TrabajarVenta.list_clientes();
        }

        private void FrmListarCompra_Load(object sender, EventArgs e)
        {
            load_clientes();
            //compras_clientes_sp();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        public void load_compras_clientes_sp() {
            dataCompras.DataSource = TrabajarVenta.listar_compras_cliente_sp(cmdClientes.SelectedValue.ToString());
        }

        public void load_listar_ventas_entre_fechas() {
            dataCompras.DataSource = TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value,dtFechaFinal.Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TrabajarVenta.listar_compras_cliente_sp(cmdClientes.SelectedValue.ToString());
            load_compras_clientes_sp();
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value, dtFechaFinal.Value);
            load_listar_ventas_entre_fechas();
        }
    }
}
