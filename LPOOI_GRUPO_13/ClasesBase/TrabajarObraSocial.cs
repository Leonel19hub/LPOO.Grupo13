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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarObraSocialSp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertarObraSocialSp(ObraSocial oObraSocial) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "insertarObraSocial";
            cmd.Parameters.AddWithValue("@cuit", oObraSocial.Os_Cuit);
            cmd.Parameters.AddWithValue("@razonsocial", oObraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@direccion", oObraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@telefono", oObraSocial.Os_Telefono);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable editarObraSocialSp(ObraSocial oObraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
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

        public static DataTable eliminarObraSocialSp(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
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
    }
}
