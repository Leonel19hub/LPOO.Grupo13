using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarCliente
    {

        # region ABM (Guardar, Modificar, Eliminar, Buscar)
        public static void guardarCliente(Cliente oCliente) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "guardarCliente";
            cmd.Parameters.AddWithValue("@cliDni", oCliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", oCliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nroCarnet", oCliente.Cli_NroCarnet);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable modificarCliente(Cliente ocliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cliDni", ocliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", ocliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", ocliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", ocliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", ocliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nroCarnet", ocliente.Cli_NroCarnet);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable eliminarCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "eliminarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parametro de entrada
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscarCliente(string buscado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "buscarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parametro de entrada
            cmd.Parameters.AddWithValue("@buscado", buscado);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
        #endregion

        public static bool ClienteExisteEnBaseDeDatos(string dni) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "clienteExisteEnBd";
            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public static DataTable listarClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ordenarClientes(string ordenamiento)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "ordenarClientes";
            cmd.Parameters.AddWithValue("@ordenamiento", ordenamiento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
