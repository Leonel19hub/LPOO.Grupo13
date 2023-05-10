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
            cmdProducto.ValueMember = "Prod_Nombre";
            cmdProducto.DataSource = TrabajarVenta.listar_productos();
        }

        private void RegistrarVentas_Load(object sender, EventArgs e)
        {
            load_combo_clientes();
            load_combo_productos();
        }

        /*private void groupBox1_Enter(object sender, EventArgs e)
        {
            load_combo_clientes();
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void listar_ventas() {
            dataGridView1.DataSource = TrabajarVenta.listar_ventas();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            Venta oVenta = new Venta();
            oVenta.Ven_Fecha = dateVenta.Value;
            oVenta.Cli_Dni = cmbRegistVCli.SelectedValue.ToString();

            VentaDetalle oDetVenta = new VentaDetalle();
            oDetVenta.Det_Nro = oVenta.Ven_Nro;
            oDetVenta.Prod_Codigo = cmdProducto.SelectedValue.ToString();
            oDetVenta.Det_Precio = Convert.ToDecimal(textBoxPrecio.Text);
            oDetVenta.Det_Cantidad = Convert.ToDecimal(textBoxCantidad.Text);
            oDetVenta.Det_Total = Convert.ToDecimal(textBoxCantidad.Text) * Convert.ToDecimal(textBoxPrecio.Text);

            TrabajarVenta.insertar_det_venta(oDetVenta);
            TrabajarVenta.insertar_venta(oVenta);
            listar_ventas();
        }

        private void dataGridView1_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
