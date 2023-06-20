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
    public partial class FrmDetalleVentaProducto : Form
    {
        public FrmDetalleVentaProducto()
        {
            InitializeComponent();
            dtProdFechaFinal.Value = DateTime.Today.AddDays(1);
        }

        private void load_clientes()
        {
            //cmdClientes.SelectedIndex = -1;
            cmdClientes.DisplayMember = "NAME";
            cmdClientes.ValueMember = "Cli_ID";
            cmdClientes.DataSource = TrabajarVenta.list_clientes();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            dataGridCompras.DataSource = TrabajarProducto.listar_productos_x_cliente_sp(Convert.ToInt32(cmdClientes.SelectedValue));
            int cantidadFilas = dataGridCompras.RowCount - 1;
            lbCantidad.Text = "Se encontraron un total de " + cantidadFilas + " resultados";
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            dataGridCompras.DataSource = TrabajarProducto.listar_productos_entre_fechas_sp(dtProdFechaInicio.Value, dtProdFechaFinal.Value);
            int cantidadFilas = dataGridCompras.RowCount - 1;
            lbCantidad.Text = "Se encontraron un total de " + cantidadFilas + " resultados";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalleVentaProducto_Load(object sender, EventArgs e)
        {
            load_clientes();
        }

        #region Efecto Hover en Botones

        private void btnBuscarCliente_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarCliente.BackColor = Color.FromArgb(186, 39, 73);
            btnBuscarCliente.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnBuscarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarCliente.BackColor = Color.FromArgb(23, 21, 32);
            btnBuscarCliente.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnBuscarFechas_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarFechas.BackColor = Color.FromArgb(186, 39, 73);
            btnBuscarFechas.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnBuscarFechas_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarFechas.BackColor = Color.FromArgb(23, 21, 32);
            btnBuscarFechas.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(186, 39, 73);
            btnSalir.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(23, 21, 32);
            btnSalir.ForeColor = Color.FromArgb(224, 224, 224);
        }

        #endregion
    }
}
