using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarObraSocial
    {

        public static DataTable listarObraSocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarObraSocial";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void guardarObraSocial(ObraSocial oObraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "guardarObraSocial";
            cmd.Parameters.AddWithValue("@nombre", oObraSocial.Os_Nombre);
            cmd.Parameters.AddWithValue("@cuit", oObraSocial.Os_Cuit);
            cmd.Parameters.AddWithValue("@razonsocial", oObraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@direccion", oObraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@telefono", oObraSocial.Os_Telefono);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable modificarObraSocial(ObraSocial oObraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarObraSocial";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@cuit", oObraSocial.Os_Cuit);
            cmd.Parameters.AddWithValue("@razonsocial", oObraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@direccion", oObraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@telefono", oObraSocial.Os_Telefono);
            cmd.Parameters.AddWithValue("@id", oObraSocial.Os_Id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable eliminarObraSocial(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "eliminarObraSocial";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parametro de entrada
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable list_ObraSocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,OS_RazonSocial AS NAME FROM ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static DataTable buscarObraSocialCliente(string cuit)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarObraSocialCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", cuit);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }
    }
}
