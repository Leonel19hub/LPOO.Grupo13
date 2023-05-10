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
        public static DataTable list_clientes()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,(Cli_Nombre + ' ' + Cli_Apellido) AS NAME FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static DataTable listar_productos() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,Prod_Nombre AS PRODUCTO FROM Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertar_venta(Venta oVenta) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Venta(Ven_Fecha,Cli_DNI) values(@fecha,@dni)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", oVenta.Ven_Fecha);
            cmd.Parameters.AddWithValue("@dni", oVenta.Cli_Dni);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listar_ventas() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Det_Nro as 'N° Detalle', Det_Precio as 'Precio', Det_Cantidad as 'Cant',Det_Total as 'Total', Prod_Nombre as 'Producto', Ven_Nro as 'N° Venta' LEFT JOIN Venta ON VentaDetalle.Ven_Nro=Venta.Ven_Nro LEFT JOIN Producto ON VentaDetalle.Prod_Codigo=Producto.Prod_Codigo",cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insertar_det_venta(VentaDetalle oDetVenta) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO VentaDetalle(Ven_Nro,Prod_Codigo,Det_Precio,Det_Cantidad,Det_Total) values(@vennum,@prodCod,@detPrecio,@detCant,@detTotal)";

            cmd.Parameters.AddWithValue("@vennum",oDetVenta.Ven_Nro);

            cmd.Parameters.AddWithValue("@vennum", oDetVenta.Ven_Nro);
            cmd.Parameters.AddWithValue("@prodCod", oDetVenta.Prod_Codigo);
            cmd.Parameters.AddWithValue("@detPrecio", oDetVenta.Det_Precio);
            cmd.Parameters.AddWithValue("@detCant", oDetVenta.Det_Cantidad);
            cmd.Parameters.AddWithValue("@detTotal", oDetVenta.Det_Total);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
