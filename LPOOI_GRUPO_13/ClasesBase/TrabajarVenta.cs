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

        public static decimal obtener_precio(string codigo) {
            decimal prod_precio;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "obtener_precio_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.Parameters.Add("@precioFinal",SqlDbType.Decimal);
            cmd.Parameters["@precioFinal"].Direction = ParameterDirection.Output;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            prod_precio = (decimal)cmd.Parameters["@precioFinal"].Value;

            return prod_precio;
        }

        public static DataTable list_nro_ventas() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,Ven_Nro as NRO FROM Venta";
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
            cmd.CommandText = "SELECT *,Prod_Codigo AS PRODUCTO FROM Producto";
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
            da = new SqlDataAdapter("select Ven_Nro as 'N° Venta', Ven_Fecha as 'Fecha', Cli_DNI as 'DNI' from Venta",cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable listar_det_venta() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Det_Nro as 'N° Detalle', Det_Precio as 'Precio', Det_Cantidad as 'Cant', Det_Total as 'Total', Ven_Nro as 'N° Venta', Prod_Codigo as 'Cod Producto' from VentaDetalle",cnn);
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

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@vennum", oDetVenta.Ven_Nro);
            cmd.Parameters.AddWithValue("@prodCod", oDetVenta.Prod_Codigo);
            cmd.Parameters.AddWithValue("@detPrecio", oDetVenta.Det_Precio);
            cmd.Parameters.AddWithValue("@detCant", oDetVenta.Det_Cantidad);
            cmd.Parameters.AddWithValue("@detTotal", oDetVenta.Det_Total);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        // Trabajo Practico N°3 - Punto 4

        public static DataTable listar_compras_cliente_sp(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscar_compras_cliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni",dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
 
            return dt;
        }

        // Trabajo Practico N°3 - Punto 5

        public static DataTable listar_ventas_entre_fechas_sp(DateTime fechaInicio, DateTime fechaFinal) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_ventas_entre_fechas";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFinal",fechaFinal);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }

    }
}
