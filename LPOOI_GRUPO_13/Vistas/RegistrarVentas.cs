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
        public RegistrarVentas()
        {
            InitializeComponent();
            load_factura();
        }

        public void load_factura() {
            dataGridProductos.DataSource = TrabajarVenta.listar_det_venta();
            dataGridView1.DataSource = TrabajarVenta.listar_ventas();
        }

        public void load_nro_venta() {
            cmdNroVenta.SelectedIndex = -1;
            cmdNroVenta.DisplayMember = "NRO";
            cmdNroVenta.ValueMember = "Ven_Nro";
            cmdNroVenta.DataSource = TrabajarVenta.list_nro_ventas();
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
            load_nro_venta();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void listar_ventas() {
            dataGridView1.DataSource = TrabajarVenta.listar_ventas();
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
            listar_ventas();
            load_nro_venta();
        }

        private void dataGridView1_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            VentaDetalle oDetVenta = new VentaDetalle();
            oDetVenta.Ven_Nro = int.Parse(cmdNroVenta.SelectedValue.ToString());
            oDetVenta.Prod_Codigo = cmdProducto.SelectedValue.ToString();
            oDetVenta.Det_Precio = Convert.ToDecimal(textBoxPrecio.Text);
            oDetVenta.Det_Cantidad = Convert.ToDecimal(textBoxCantidad.Text);
            oDetVenta.Det_Total = Convert.ToDecimal(textBoxCantidad.Text) * Convert.ToDecimal(textBoxPrecio.Text);

            TrabajarVenta.insertar_det_venta(oDetVenta);
            listar_det_ventas();
        }
    }
}
