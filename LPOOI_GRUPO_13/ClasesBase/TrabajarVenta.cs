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

            SqlDataAdapter da;
            //cmd.CommandText = "SELECT *,(Cli_Nombre+' '+Cli_Apellido) AS NombreApellido FROM Cliente
            da = new SqlDataAdapter("select (Cli_Apellido + ' ' +Cli_Nombre) as 'ApellidoNombre' FROM Cliente", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
    }
}
