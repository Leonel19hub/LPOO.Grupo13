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
                oProducto.Prod_Categoria = txtCatProd.Text;
                oProducto.Prod_Descripcion= txtDes.Text;
                oProducto.Prod_Precio = Convert.ToDecimal(txtPrecioProd.Text);
                insertar_producto(oProducto);
                load_productos();
            }
        }

        public static void insertar_producto(Producto oProducto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Producto(Prod_Codigo, Prod_Categoria, Prod_Descripcion, Prod_Precio) values(@cod,@cat,@des,@precio)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cod", oProducto.Prod_Codigo);
            cmd.Parameters.AddWithValue("@cat", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@des", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        private void load_productos()
        {
            dataGridProducto.DataSource = listar_productos();
            txtCodProd.Text = "";
            txtCatProd.Text = "";
            txtDes.Text = "";
            txtPrecioProd.Text = "";
        }

        public static DataTable listar_productos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Prod_Codigo as 'Codigo', Prod_Categoria as 'Categoria', Prod_Descripcion as 'Descripcion', Prod_Precio as 'Precio' FROM Producto", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        private void dataGridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProducto.SelectedRows.Count > 0)
            {
                txtCodProd.Text = dataGridProducto.CurrentRow.Cells["Codifo"].Value.ToString();
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
