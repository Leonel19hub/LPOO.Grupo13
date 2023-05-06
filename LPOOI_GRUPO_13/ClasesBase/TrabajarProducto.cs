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

            cmd.CommandText = "INSERT INTO Producto(Prod_Codigo, Prod_Categoria, Prod_Descripcion, Prod_Precio) values(@cod,@cat,@des,@precio)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cod", oProducto.Prod_Codigo);
            cmd.Parameters.AddWithValue("@cat", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@des", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", oProducto.Prod_Precio);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }
        public static DataTable listar_productos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Prod_Codigo as 'Codigo', Prod_Categoria as 'Categoria', Prod_Descripcion as 'Descripcion', Prod_Precio as 'Precio' FROM Producto", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

    }
}
