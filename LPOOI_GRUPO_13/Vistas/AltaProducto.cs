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

        private void dataGridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProducto.SelectedRows.Count > 0)
            {
                txtCodProd.Text = dataGridProducto.CurrentRow.Cells["Codifo"].Value.ToString();
                txtNombre.Text = dataGridProducto.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCatProd.Text = dataGridProducto.CurrentRow.Cells["Categoria"].Value.ToString();
                txtDes.Text = dataGridProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecioProd.Text = dataGridProducto.CurrentRow.Cells["Precio"].Value.ToString();
                btnAceptarProd.Enabled = false;

            }
            else
                btnAceptarProd.Enabled = true;
        }
    }
}
