using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Text.RegularExpressions;

namespace Vistas
{
    public partial class FrmAltaVenta : Form
    {
        // Agrega una lista de objetos VentaDetalle como campo de la clase
        private List<VentaDetalle> detallesVenta = new List<VentaDetalle>();
        public FrmAltaVenta()
        {
            InitializeComponent();
        }

        public void loadComboClientes()
        {
            cmbRegistVCli.SelectedIndex = -1;
            cmbRegistVCli.DisplayMember = "NAME";
            cmbRegistVCli.ValueMember = "Cli_ID";
            cmbRegistVCli.DataSource = TrabajarVenta.list_clientes();
            
        }

        public void loadComboProductos()
        {
            cmdProducto.SelectedIndex = -1;
            cmdProducto.DisplayMember = "PRODUCTO";
            cmdProducto.ValueMember = "Prod_Codigo";
            cmdProducto.DataSource = TrabajarVenta.listar_productos();
        }

        private void FrmAltaVenta_Load(object sender, EventArgs e)
        {
            loadComboClientes();
            loadComboProductos();
            btnCargarProducto.Enabled = false;
            btnGenerarFactura.Enabled = detallesVenta.Count > 0;
            
        }

        private void listar_productos_comprados()
        {
            //dataGridProductos.DataSource = TrabajarProducto.listar_productos();
            var productosComprados = detallesVenta.Select(detalle => new
            {
                detalle.Prod_Codigo,
                detalle.Det_Precio,
                detalle.Det_Cantidad,
                detalle.Det_Total
            }).ToList();

            dataGridProductos.DataSource = productosComprados;
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            VentaDetalle oDetVenta = new VentaDetalle();
            oDetVenta.Prod_Codigo = Convert.ToInt32(cmdProducto.SelectedValue.ToString());
            oDetVenta.Det_Precio = Convert.ToDecimal(textBoxPrecio.Text);
            oDetVenta.Det_Cantidad = Convert.ToDecimal(textBoxCantidad.Text);
            oDetVenta.Det_Total = Convert.ToDecimal(textBoxCantidad.Text) * Convert.ToDecimal(textBoxPrecio.Text);

            // Agrega el objeto VentaDetalle a la lista
            detallesVenta.Add(oDetVenta);
            listar_productos_comprados();
            btnGenerarFactura.Enabled = detallesVenta.Count > 0;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            Venta oVenta = new Venta();
            oVenta.Ven_Fecha = dateVenta.Value;
            oVenta.Cli_ID = Convert.ToInt32(cmbRegistVCli.SelectedValue);
            TrabajarVenta.guardarVenta(oVenta);
            // Obtiene el Ven_Nro generado por la base de datos
            int venNro = TrabajarVenta.obtenerUltimoNroVenta();
            // Asigna Ven_Nro a cada objeto VentaDetalle en la lista y los inserta en la base de datos
            foreach (VentaDetalle detalle in detallesVenta)
            {
                detalle.Ven_Nro = venNro;
                TrabajarVenta.guardarDetalleVenta(detalle);
                
            }
            dataGridProductos.DataSource = TrabajarVenta.listarUltimosDetalles(detallesVenta.Count);
            detallesVenta.Clear();
            loadComboProductos();
            
            btnGenerarFactura.Enabled = detallesVenta.Count > 0;
        }

        private void cmdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProducto.SelectedIndex != -1) // Verifica si se ha seleccionado un producto
            {
                string codigoProducto = cmdProducto.SelectedValue.ToString();
                string precio = TrabajarProducto.getProductById(Convert.ToInt32(codigoProducto));

                if (precio != null)
                {
                    textBoxPrecio.Text = precio;
                }
                else
                {
                    textBoxPrecio.Text = "Precio no disponible";
                }
            }
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            decimal total;
            string codigoProducto = cmdProducto.SelectedValue.ToString();
            string precio = TrabajarProducto.getProductById(Convert.ToInt32(codigoProducto));
            string pattern = @"^\d+(\.\d+)?$";
            if (Regex.IsMatch(textBoxCantidad.Text, pattern))
            {
                decimal value = decimal.Parse(textBoxCantidad.Text);
                btnCargarProducto.Enabled = true;
                if (value != 0)
                {
                    btnCargarProducto.Enabled = true;
                    total = Convert.ToDecimal(textBoxCantidad.Text) * decimal.Parse(precio);
                }
                else
                {
                    btnCargarProducto.Enabled = false;
                    total = decimal.Parse(precio) * 0;
                }
            }
            else
            {
                btnCargarProducto.Enabled = false;
                total = decimal.Parse(precio) * 0;
            }
            textBoxTotal.Text = total.ToString();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            dataGridProductos.DataSource = TrabajarVenta.listarDetalleVenta();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Efecto Hover en Botones

        private void btnCargarProducto_MouseEnter(object sender, EventArgs e)
        {
            btnCargarProducto.BackColor = Color.FromArgb(186, 39, 73);
            btnCargarProducto.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnCargarProducto_MouseLeave(object sender, EventArgs e)
        {
            btnCargarProducto.BackColor = Color.FromArgb(23, 21, 32);
            btnCargarProducto.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnGenerarFactura_MouseEnter(object sender, EventArgs e)
        {
            btnGenerarFactura.BackColor = Color.FromArgb(186, 39, 73);
            btnGenerarFactura.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnGenerarFactura_MouseLeave(object sender, EventArgs e)
        {
            btnGenerarFactura.BackColor = Color.FromArgb(23, 21, 32);
            btnGenerarFactura.ForeColor = Color.FromArgb(224, 224, 224);
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
