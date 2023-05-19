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
    public partial class RegistrarVentas : Form
    {
        // Agrega una lista de objetos VentaDetalle como campo de la clase
        private List<VentaDetalle> detallesVenta = new List<VentaDetalle>();
        public RegistrarVentas()
        {
            InitializeComponent();
            load_factura();
        }

        public void load_factura() {
            dataGridProductos.DataSource = TrabajarVenta.listar_det_venta();
            //dataGridView1.DataSource = TrabajarVenta.listar_ventas();
        }
        
        public void load_combo_clientes()
        {
            cmbRegistVCli.SelectedIndex = -1;
            cmbRegistVCli.DisplayMember = "NAME";
            cmbRegistVCli.ValueMember = "Cli_DNI";
            cmbRegistVCli.DataSource = TrabajarVenta.list_clientes();
        }

        public void load_combo_productos() {
            cmdProducto.SelectedIndex = -1;
            cmdProducto.DisplayMember = "PRODUCTO";
            cmdProducto.ValueMember = "Prod_Codigo";
            cmdProducto.DataSource = TrabajarVenta.listar_productos();
        }

        private void RegistrarVentas_Load(object sender, EventArgs e)
        {
            load_combo_clientes();
            load_combo_productos();
            //load_nro_venta();

        }
        //prueba
        private void listar_productos_comprados() {
            dataGridProductos.DataSource = TrabajarProducto.listar_productos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void listar_det_ventas() {
            dataGridProductos.DataSource = TrabajarVenta.listar_det_venta();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            Venta oVenta = new Venta();
            oVenta.Ven_Fecha = dateVenta.Value;
            oVenta.Cli_Dni = cmbRegistVCli.SelectedValue.ToString();
            TrabajarVenta.insertar_venta(oVenta);

            // Obtiene el Ven_Nro generado por la base de datos
            int venNro = TrabajarVenta.obtener_ultimo_ven_nro();

            // Asigna Ven_Nro a cada objeto VentaDetalle en la lista y los inserta en la base de datos
            foreach (VentaDetalle detalle in detallesVenta)
            {
                detalle.Ven_Nro = venNro;
                TrabajarVenta.insertar_det_venta(detalle);
            }

            // Limpia la lista de detalles de venta
            detallesVenta.Clear();

            listar_det_ventas();
            //load_nro_venta();
        }
        // Modifica el evento del botón btnCargarProducto_Click para agregar productos a la lista
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            VentaDetalle oDetVenta = new VentaDetalle();
            oDetVenta.Prod_Codigo = cmdProducto.SelectedValue.ToString();
            oDetVenta.Det_Precio = Convert.ToDecimal(textBoxPrecio.Text);
            oDetVenta.Det_Cantidad = Convert.ToDecimal(textBoxCantidad.Text);
            oDetVenta.Det_Total = Convert.ToDecimal(textBoxCantidad.Text) * Convert.ToDecimal(textBoxPrecio.Text);

            // Agrega el objeto VentaDetalle a la lista
            detallesVenta.Add(oDetVenta);
            listar_productos_comprados();
        }

        private void cmdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProducto.SelectedIndex != -1) // Verifica si se ha seleccionado un producto
            {
                string codigoProducto = cmdProducto.SelectedValue.ToString();
                string precio = TrabajarVenta.obtener_precio(codigoProducto);

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
            string precio = TrabajarVenta.obtener_precio(codigoProducto);
            if (textBoxCantidad.Text == "")
            {
                total = decimal.Parse(precio) * 0;
            }
            else
            {
                total = decimal.Parse(precio) * (decimal.Parse(textBoxCantidad.Text));
            }

            textBoxTotal.Text = total.ToString();
        }

    }
}
