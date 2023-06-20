using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarProducto
    {

        #region ABM (Guardar, Modificar, Eliminar, Buscar)
        public static void guardarProducto(Producto oProducto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "guardarProducto";
            cmd.Parameters.AddWithValue("@nombre", oProducto.Prod_Nombre);
            cmd.Parameters.AddWithValue("@categoria", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable modificarProducto(Producto oProducto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@codigo", oProducto.Prod_Codigo);
            cmd.Parameters.AddWithValue("@nombre", oProducto.Prod_Nombre);
            cmd.Parameters.AddWithValue("@categoria", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static DataTable eliminarProducto(int codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "eliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscarProductos(string buscado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "buscarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@buscado", buscado);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
#endregion 

        public static DataTable listarProductos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool ProductoExisteEnBaseDeDatos(string nombre)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "productoExisteEnBd";
            cmd.Parameters.AddWithValue("@nombre", nombre);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public static DataTable ordenarProductos(string ordenamiento)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "ordenarProductos";
            cmd.Parameters.AddWithValue("@ordenamiento", ordenamiento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static string getProductById(int codigo)
        {
            string prod_precio;
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "getProductById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Connection = cnn;
            cnn.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prod_precio = (string)dr["Prod_Precio"].ToString();
                return prod_precio;
            }
            return null;
        }

        public static DataTable listar_productos_x_cliente_sp(int cliDni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarProductosXCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", cliDni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }

        public static DataTable listar_productos_entre_fechas_sp(DateTime fechaInicio, DateTime fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listarProductoEntreFechas";
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
    }
}
