using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    class TrabajarCliente
    {
        public static DataTable listar_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Cli_DNI as 'Dni', Cli_Nombre as 'Nombre', Cli_Apellido as 'Apellido', Cli_Direccion as 'Direccion',Cli_Telefono as 'Telefono' FROM Cliente", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static void insertar_cliente(Cliente oCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Cliente(Cli_DNI,Cli_Nombre,Cli_Apellido,Cli_Direccion,Cli_Telefono) values(@dni,@nombre,@apellido,@direccion,@telefono)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable eliminar_cliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Cliente WHERE Cli_DNI='" + dni + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();


            //LLENAR LOS DATOS DE CONSULTA EN EL DATATABLE

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }

        public static DataTable modificar_cliente(Cliente oCliente, string dni, string nombre, string apellido, string direccion, string telefono, string j)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Cliente SET Cli_DNI ='" + dni + "',Cli_Nombre='" + nombre + "',Cli_Apellido='" + apellido + "',Cli_Direccion='" + direccion + "',Cli_Telefono='" + telefono + "'WHERE Cli_DNI='" + j + "'";

            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        public static DataTable buscar_cliente(string buscado)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            DataTable dt;
            SqlCommand cmd = new SqlCommand();

            //BUSQUEDA POR DOS CAMPOS SEPARADOS...    
            //da = new SqlDataAdapter("select cli_Dni as 'Dni', cli_Nombre as 'Nombre', cli_Apellido as 'Apellido',cli_Direccion as 'Direccion',cli_Telefono as 'Telefono' FROM Cliente WHERE cli_Nombre LIKE '%" + buscado + "%' OR cli_Apellido LIKE '%" + buscado + "%' ", cnn);
            //BUSQUEDA POR CAMPOS COMBINADOS. NOMBRE Y APELLIDO
            da = new SqlDataAdapter("select Cli_Dni as 'DNI', Cli_Nombre as 'Nombre', Cli_Apellido as 'Apellido',Cli_Direccion as 'Direccion',Cli_Telefono as 'Telefono' FROM Cliente WHERE (Cli_Nombre+' '+ Cli_Apellido ) LIKE '%" + buscado + "%' ", cnn);

            dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
    }
}
