using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data.SqlClient;
using System.Data;
namespace ClasesBase
{
    public class TrabajarCliente
    {
        public static void insertarClienteSp(Cliente cliente) 
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "insertarClienteSp";
            cmd.Parameters.AddWithValue("@cliDni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nroCarnet", cliente.Cli_NroCarnet);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable listarClientesSp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarClientesSp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable editarClienteSp(Cliente ocliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "editarClienteSp";
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

        public static DataTable eliminarClienteSp(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "eliminarClienteSp";
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

        public static DataTable buscar_cliente(string buscado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "buscar_cliente_sp";
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

        public static DataTable ordenarClientesApellido()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ordenarClientesApellido";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }
    }
}
