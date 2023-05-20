using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace Vistas
{
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
            load_productos();
        }

        private void btnAtrasProd_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void btnAceptarProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Producto?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Producto oProducto = new Producto();
                oProducto.Prod_Codigo = txtCodProd.Text;
                oProducto.Prod_Nombre = txtNombre.Text;
                oProducto.Prod_Categoria = txtCatProd.Text;
                oProducto.Prod_Descripcion= txtDes.Text;
                oProducto.Prod_Precio = decimal.Parse(txtPrecioProd.Text);
                TrabajarProducto.insertar_producto(oProducto);
                load_productos();
            }
        }

        private void load_productos()
        {
            dataGridProducto.DataSource = TrabajarProducto.listar_productos();
            txtCodProd.Text = "";
            txtNombre.Text = "";
            txtCatProd.Text = "";
            txtDes.Text = "";
            txtPrecioProd.Text = "";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (radioCategoria.Checked)
            {
                dataGridProducto.DataSource = TrabajarProducto.listar_productos_categoria_sp();
            }
            else {
                if (radioDescripcion.Checked) {
                    dataGridProducto.DataSource = TrabajarProducto.listar_productos_descripcion_sp();
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dataGridProducto.DataSource = TrabajarProducto.eliminar_producto_sp(txtCodProd.Text);
            //dataGridProducto.DataSource = TrabajarProducto.eliminar_producto(txtCodProd.Text);
            load_productos();
        }

        private void dataGridProducto_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridProducto.SelectedRows.Count > 0)
            {
                txtCodProd.Text = dataGridProducto.CurrentRow.Cells["Codigo"].Value.ToString();
                txtNombre.Text = dataGridProducto.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCatProd.Text = dataGridProducto.CurrentRow.Cells["Categoria"].Value.ToString();
                txtDes.Text = dataGridProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecioProd.Text = dataGridProducto.CurrentRow.Cells["Precio"].Value.ToString();
                btnAceptarProd.Enabled = false;

            }
            else
                btnAceptarProd.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto oProducto = new Producto();
            oProducto.Prod_Codigo = txtCodProd.Text;
            oProducto.Prod_Descripcion = txtDes.Text;
            oProducto.Prod_Categoria = txtCatProd.Text;
            oProducto.Prod_Nombre = txtNombre.Text;
            oProducto.Prod_Precio = Convert.ToDecimal(txtPrecioProd.Text);
            dataGridProducto.DataSource = TrabajarProducto.modeificar_producto_sp(oProducto);
            load_productos();
        }

        private void txtPrecioProd_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\d+(\.\d+)?$";
            if (Regex.IsMatch(txtPrecioProd.Text, pattern))
            {
                decimal value = decimal.Parse(txtPrecioProd.Text);
                btnAceptarProd.Enabled = true;
                if (value != 0)
                {
                    btnAceptarProd.Enabled = true;
                }
                else
                {
                    btnAceptarProd.Enabled = false;
                }
            }
            else
            {
                btnAceptarProd.Enabled = false;
            }
        }
    }
}
