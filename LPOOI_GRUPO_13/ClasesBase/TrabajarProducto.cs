using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        public static void insertar_producto(Producto oProducto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Producto(Prod_Codigo, Prod_Categoria, Prod_Descripcion, Prod_Precio, Prod_Nombre) values(@cod,@cat,@des,@precio,@nombre)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cod", oProducto.Prod_Codigo);
            cmd.Parameters.AddWithValue("@cat", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@des", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);
            cmd.Parameters.AddWithValue("@nombre", oProducto.Prod_Nombre);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }
        public static DataTable listar_productos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Prod_Codigo as 'Codigo', Prod_Categoria as 'Categoria', Prod_Descripcion as 'Descripcion', Prod_Precio as 'Precio', Prod_Nombre as 'Nombre' FROM Producto", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static DataTable listar_productos_categoria_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ordenar_producto_categoria";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }

        public static DataTable listar_productos_descripcion_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ordernar_producto_descripcion";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public static DataTable eliminar_producto(string codigo) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Producto WHERE Prod_Codigo='"+codigo+"'";
            cmd.ExecuteNonQuery();
            cnn.Close();
            //LLENAR LOS DATOS DE CONSULTA EN EL DATATABLE
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable eliminar_producto_sp(string codigo) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "borrar_producto_sp";
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

        public static DataTable listar_productos_x_cliente_sp(string cliDni) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_productos_x_cliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cliDni", cliDni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();

            return dt;
        }

        public static DataTable listar_productos_entre_fechas_sp(DateTime fechaInicio, DateTime fechaFinal) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_productos_entre_fechas_sp";
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
