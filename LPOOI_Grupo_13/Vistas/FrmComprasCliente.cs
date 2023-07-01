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
        private string ultimoBotonPresionado = "";
        public FrmComprasCliente()
        {
            InitializeComponent();
            dtFechaFinal.Value = DateTime.Today.AddDays(1);
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
        DataTable cmbListado;
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ultimoBotonPresionado = "Cliente";
            var dataTableCompras = TrabajarVenta.listar_compras_cliente_sp(Convert.ToInt32(cmdClientes.SelectedValue));
            cmbListado = TrabajarVenta.listar_compras_cliente_sp(Convert.ToInt32(cmdClientes.SelectedValue));
            if (dataTableCompras.Rows.Count > 0)
            {
                dataCompras.DataSource = dataTableCompras;
                int cantidadFilas = dataTableCompras.Rows.Count;
                lbCantidad.Text = "Se encontraron un total de " + cantidadFilas + " resultados";
            }
            else
            {
                dataCompras.DataSource = null; // No hay datos, asignar null al DataSource
                lbCantidad.Text = "No se encontraron resultados";
            }
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            ultimoBotonPresionado = "Fechas";
            var dataTableVentas = TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value, dtFechaFinal.Value);
            cmbListado = TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value, dtFechaFinal.Value);

            if (dataTableVentas.Rows.Count > 0)
            {
                dataCompras.DataSource = dataTableVentas;
                int cantidadFilas = dataTableVentas.Rows.Count;
                lbCantidad.Text = "Se encontraron un total de " + cantidadFilas + " resultados";
            }
            else
            {
                dataCompras.DataSource = null; // No hay datos, asignar null al DataSource
                lbCantidad.Text = "No se encontraron resultados";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        Venta deleteVenta = new Venta();
        private void dataCompras_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataCompras.CurrentRow != null && dataCompras.SelectedRows.Count > 0)
            {
                deleteVenta.Ven_Nro = Convert.ToInt32(dataCompras.CurrentRow.Cells["N° Venta"].Value.ToString());
                deleteVenta.Ven_Fecha = Convert.ToDateTime(dataCompras.CurrentRow.Cells["Fecha"].Value);
                deleteVenta.Cli_ID = Convert.ToInt32(dataCompras.CurrentRow.Cells["ID Cliente"].Value.ToString());
            }
        }

        private void dataCompras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // Verifica si se ha presionado la tecla "Suprimir"
            {
                if (dataCompras.SelectedRows.Count > 0)
                {
                    // Obtener los datos de la venta antes de eliminarla
                    int ventaNro = Convert.ToInt32(dataCompras.CurrentRow.Cells["N° Venta"].Value.ToString());
                    DataTable dtVenta = TrabajarVenta.buscarVenta(ventaNro);

                    // Mostrar MessageBox con los datos y solicitar confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro de eliminar la venta?\n\nDatos de la venta:\n" + 
                        "\nN° Venta: " +deleteVenta.Ven_Nro +
                        "\nFecha: " + deleteVenta.Ven_Fecha +
                        "\nID Cliente: " + deleteVenta.Cli_ID, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Eliminar la venta
                        TrabajarVenta.eliminarVenta(ventaNro);
                        deleteVenta = new Venta();
                    }
                }
            }
        }
    }
}
