using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        public static void insertarProductoSp(Producto oProducto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "insertarProductoSp";
            cmd.Parameters.AddWithValue("@nombre", oProducto.Prod_Nombre);
            cmd.Parameters.AddWithValue("@categoria", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable listarProductoSp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarProductosSp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable editarProductoSp(Producto oProducto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificarProductoSp";
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

        public static DataTable eliminarProductoSp(int codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "eliminarProductoSp";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parametro de entrada
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscar_producto(string buscado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "buscarProductoSp";
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

        public static DataTable listar_productos_categoria_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ordenarProductoCategoria";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }

        public static DataTable listar_productos_descripcion_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ordenarProductoDescripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public static DataTable listar_productos_x_cliente_sp(int cliDni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
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

        public static DataTable list_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT *,(Cli_Nombre + ' ' + Cli_Apellido) AS NAME FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
    }
}
