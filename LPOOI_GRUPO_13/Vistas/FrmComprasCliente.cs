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
    public partial class FrmComprasCliente : Form
    {
        public FrmComprasCliente()
        {
            InitializeComponent();
        }

        private void load_clientes()
        {
            //cmdClientes.SelectedIndex = -1;
            cmdClientes.DisplayMember = "NAME";
            cmdClientes.ValueMember = "Cli_ID";
            cmdClientes.DataSource = TrabajarVenta.list_clientes();
        }

        private void FrmComprasCliente_Load(object sender, EventArgs e)
        {
            load_clientes();
        }

        public void load_compras_clientes_sp()
        {
            dataCompras.DataSource = TrabajarVenta.listar_compras_cliente_sp(Convert.ToInt32(cmdClientes.SelectedValue.ToString()));
        }

        public void load_listar_ventas_entre_fechas()
        {
            dataCompras.DataSource = TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value, dtFechaFinal.Value);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            TrabajarVenta.listar_compras_cliente_sp(Convert.ToInt32(cmdClientes.SelectedValue.ToString()));
            load_compras_clientes_sp();
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value, dtFechaFinal.Value);
            load_listar_ventas_entre_fechas();
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

        private void btnSalir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

    }
}
