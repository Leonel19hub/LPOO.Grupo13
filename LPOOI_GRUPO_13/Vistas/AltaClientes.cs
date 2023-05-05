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
    public partial class AltaClientes : Form
    {
        public AltaClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            load_clientes();
        }

        private void load_clientes()
        {
            dataGridCliente.DataSource = listar_clientes();
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDir.Text = "";
            textCuit.Text = "";
            textNroCarnet.Text = "";
        }

        public static DataTable listar_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Cli_DNI as 'Dni', Cli_Apellido as 'Apellido', Cli_Nombre as 'Nombre', Cli_Direccion as 'Direccion',OS_CUIT as 'CUIT' FROM Cliente", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        private void dataGridCliente_CurrentCellChanged(object sender, EventArgs e)
        {

            if (dataGridCliente.SelectedRows.Count > 0)
            {
                txtDni.Text = dataGridCliente.CurrentRow.Cells["Dni"].Value.ToString();
                txtNombre.Text = dataGridCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                txtApellido.Text = dataGridCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                textCuit.Text = dataGridCliente.CurrentRow.Cells["Cuit"].Value.ToString();
                textNroCarnet.Text = dataGridCliente.CurrentRow.Cells["N° Carnet"].Value.ToString();
                btnModificar.Enabled = false;

            }
            else
                btnModificar.Enabled = true;
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_Dni = txtDni.Text;
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Direccion = txtDir.Text;
                oCliente.Os_Cuit = textCuit.Text;
                oCliente.Cli_NroCarnet = textNroCarnet.Text;

                insertar_cliente(oCliente);
                load_clientes();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = eliminar_cliente(txtDni.Text);
            load_clientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string j = txtDni.Text;
            Cliente oCliente = new Cliente();
            dataGridCliente.DataSource = modificar_cliente(oCliente, txtDni.Text, txtNombre.Text, txtApellido.Text, j);
            load_clientes();
            dataGridCliente.CurrentCell = null;
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            if (txtBuscarCli.Text != "")
            {
                dataGridCliente.DataSource = buscar_cliente(txtBuscarCli.Text);
            }
            else
            {
                load_clientes();
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }





        public static void insertar_cliente(Cliente oCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Cliente(Cli_DNI,Cli_Apellido,Cli_Nombre,Cli_Direccion,OS_CUIT,Cli_NroCarnet) values(@dni,@apellido,@nombre,@direccion,@cuit,@carnet)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", oCliente.Os_Cuit);
            cmd.Parameters.AddWithValue("@carnet", oCliente.Cli_NroCarnet);
            
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable eliminar_cliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Cliente WHERE Cli_DNI='" + dni + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();


            //LLENAR LOS DATOS DE CONSULTA EN EL DATATABLE

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }

        public static DataTable modificar_cliente(Cliente oCliente, string dni, string nombre, string apellido, string j)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Cliente SET Cli_DNI ='" + dni + "',Cli_Apellido='" + apellido + "',Cli_Nombre='" + nombre + "'WHERE Cli_DNI='" + j + "'";

            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        public static DataTable buscar_cliente(string buscado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            DataTable dt;
            SqlCommand cmd = new SqlCommand();

            da = new SqlDataAdapter("select Cli_Dni as 'DNI', Cli_Apellido as 'Apellido', Cli_Nombre as 'Nombre',Cli_Direccion as 'Direccion',OS_CUIT as 'CUIT' FROM Cliente WHERE (Cli_Nombre+' '+ Cli_Apellido ) LIKE '%" + buscado + "%' ", cnn);

            dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        private void volver_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

    }
}
