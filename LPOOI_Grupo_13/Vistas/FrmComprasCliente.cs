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
            btnEliminar.Enabled = false;
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
                loadCmdDelete();
                lbCantidad.Text = "Se encontraron un total de " + cantidadFilas + " resultados";
                btnEliminar.Enabled = true;
            }
            else
            {
                dataCompras.DataSource = null; // No hay datos, asignar null al DataSource
                lbCantidad.Text = "No se encontraron resultados";
            }
        }

        public void loadCmdDelete() {
            // Asignar el DataTable como origen de datos del ComboBox
            cmbDelete.DataSource = cmbListado;

            // Establecer el campo que se mostrará en el ComboBox
            cmbDelete.DisplayMember = "N° Venta";

            // Establecer el valor seleccionado en el ComboBox
            cmbDelete.ValueMember = "N° Venta";

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
                loadCmdDelete();
                lbCantidad.Text = "Se encontraron un total de " + cantidadFilas + " resultados";
                btnEliminar.Enabled = true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una venta
            if (cmbDelete.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado una venta para eliminar.", "Eliminar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener el número de venta seleccionado
            int ventaNro = Convert.ToInt32(cmbDelete.SelectedValue);

            // Buscar la fila correspondiente al número de venta en el DataTable cmbListado
            DataRow[] rows = cmbListado.Select("[N° Venta] = " + ventaNro);

            // Verificar si se encontró la fila y obtener los datos adicionales
            if (rows.Length > 0)
            {
                DataRow ventaSeleccionada = rows[0];
                string fechaVenta = ventaSeleccionada["Fecha"].ToString();

                // Mostrar cuadro de diálogo de confirmación
                string mensaje = "¿Estás seguro de que deseas eliminar la venta " + ventaNro + " realizada el " + fechaVenta + "?";
                DialogResult result = MessageBox.Show(mensaje, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la venta
                    TrabajarVenta.eliminarVenta(ventaNro);

                    // Actualizar la fuente de datos del ComboBox cmbDelete
                    if (ultimoBotonPresionado == "Cliente")
                    {
                        cmbListado = TrabajarVenta.listar_compras_cliente_sp(Convert.ToInt32(cmdClientes.SelectedValue));
                    }
                    else if (ultimoBotonPresionado == "Fechas")
                    {
                        cmbListado = TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value, dtFechaFinal.Value);
                    }
                    cmbDelete.DataSource = cmbListado;
                    cmbDelete.DisplayMember = "N° Venta";
                    cmbDelete.ValueMember = "N° Venta";

                    // Actualizar la fuente de datos y refrescar el DataGridView
                    if (ultimoBotonPresionado == "Cliente")
                    {
                        dataCompras.DataSource = TrabajarVenta.listar_compras_cliente_sp(Convert.ToInt32(cmdClientes.SelectedValue));
                    }
                    else if (ultimoBotonPresionado == "Fechas")
                    {
                        dataCompras.DataSource = TrabajarVenta.listar_ventas_entre_fechas_sp(dtFechaInicio.Value, dtFechaFinal.Value);
                    }

                    dataCompras.Refresh();
                }
            }
        }
    }
}
