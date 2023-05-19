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
    public partial class AltaObraSocial : Form
    {
        public AltaObraSocial()
        {
            InitializeComponent();
            load_obraSocial();
        }

        private void lblDirObraSocial_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarObraSocial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                ObraSocial oObraSocial = new ObraSocial();
                oObraSocial.Os_Cuit = txtCuitObraSocial.Text;
                oObraSocial.Os_RazonSocial = txtRazonSocialObraSocial.Text;
                oObraSocial.Os_Direccion = txtDirObraSocial.Text;
                oObraSocial.Os_Telefono = txtTelefonoOs.Text;

                insertar_obraSocial(oObraSocial);
                load_obraSocial();
            }
        }

        public static void insertar_obraSocial(ObraSocial oObraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO ObraSocial(OS_CUIT, OS_RazonSocial, OS_Direccion, OS_Telefono) values(@cuit, @rz, @dir, @tel)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", oObraSocial.Os_Cuit);
            cmd.Parameters.AddWithValue("@rz", oObraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@dir", oObraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@tel", oObraSocial.Os_Telefono);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        private void dataGridObra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridObra.SelectedRows.Count > 0)
            {
                txtCuitObraSocial.Text = dataGridObra.CurrentRow.Cells["CUIT"].Value.ToString();
                txtRazonSocialObraSocial.Text = dataGridObra.CurrentRow.Cells["Razon Social"].Value.ToString();
                txtDirObraSocial.Text = dataGridObra.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefonoOs.Text = dataGridObra.CurrentRow.Cells["Telefono"].Value.ToString();
                btnAceptarObraSocial.Enabled = false;

            }
            else
                btnAceptarObraSocial.Enabled = true;
        }

        private void load_obraSocial()
        {
            dataGridObra.DataSource = listar_ObraSocial();
            txtCuitObraSocial.Text = "";
            txtRazonSocialObraSocial.Text = "";
            txtDirObraSocial.Text = "";
            txtTelefonoOs.Text = "";
        }

        public static DataTable listar_ObraSocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select OS_CUIT as 'CUIT', OS_RazonSocial as 'Razon Social', OS_Direccion as 'Direccion', OS_Telefono as 'Telefono' FROM ObraSocial", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        private void btnAtrasObraSocial_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void dataGridObra_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridObra.SelectedRows.Count > 0)
            {
                txtCuitObraSocial.Text = dataGridObra.CurrentRow.Cells["CUIT"].Value.ToString();
                txtRazonSocialObraSocial.Text = dataGridObra.CurrentRow.Cells["Razon Social"].Value.ToString();
                txtDirObraSocial.Text = dataGridObra.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefonoOs.Text = dataGridObra.CurrentRow.Cells["Telefono"].Value.ToString();
                btnAceptarObraSocial.Enabled = false;

            }
            else
                btnAceptarObraSocial.Enabled = true;
        }
    }
}
