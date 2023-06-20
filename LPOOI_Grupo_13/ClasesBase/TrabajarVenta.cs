using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVenta
    {
        public static void guardarVenta(Venta oVenta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "guardarVenta";
            cmd.Parameters.AddWithValue("@fecha", oVenta.Ven_Fecha);
            cmd.Parameters.AddWithValue("@id", oVenta.Cli_ID);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void guardarDetalleVenta(VentaDetalle oDetVenta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "guardarDetalleVenta";
            cmd.Parameters.AddWithValue("@vennum", oDetVenta.Ven_Nro);
            cmd.Parameters.AddWithValue("@prodCod", oDetVenta.Prod_Codigo);
            cmd.Parameters.AddWithValue("@detPrecio", oDetVenta.Det_Precio);
            cmd.Parameters.AddWithValue("@detCant", oDetVenta.Det_Cantidad);
            cmd.Parameters.AddWithValue("@detTotal", oDetVenta.Det_Total);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static int obtenerUltimoNroVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MAX(Ven_Nro) FROM Venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            int ultimoVenNro = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();
            return ultimoVenNro;
        }

        public static DataTable listarDetalleVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarDetalleVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable list_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,(Cli_Nombre + ' ' + Cli_Apellido) AS NAME FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static DataTable listar_productos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,Prod_Nombre AS PRODUCTO FROM Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable listar_compras_cliente_sp(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscar_compras_cliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }

        public static DataTable listarUltimosDetalles(int cantidadUltimos)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarUltimosDetalles";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cantidadUltimos", cantidadUltimos);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }

        public static DataTable listar_ventas_entre_fechas_sp(DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_ventas_entre_fechas";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }

        public static DataTable eliminarVenta(int venNro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "eliminarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parametro de entrada
            cmd.Parameters.AddWithValue("@venNro", venNro);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
