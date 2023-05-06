﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {

        public static DataTable listar_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static DataTable listar_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Usu_ID as 'ID', Usu_NombreUsuario as 'Username', Usu_Contraseña as 'Password', Usu_ApellidoNombre as 'Nombre y apellido',Rol_Descripcion as 'Roles' from Usuario LEFT JOIN Roles on Usuario.Rol_Codigo=Roles.Rol_Codigo", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static void insertar_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Usuario(Rol_Codigo,Usu_NombreUsuario,Usu_Contraseña,Usu_ApellidoNombre) values(@rol,@username,@password,@AyN)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@username", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@password", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@AyN", user.Usu_ApellidoNombre);

            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        public static DataTable modificar_usuario(Usuario user, string username, string password, string apellidonombre, string rolcodigo, int i)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario ='" + username + "',Usu_Contraseña ='" + password + "',Usu_ApellidoNombre='" + apellidonombre + "',Rol_Codigo='" + rolcodigo + "'WHERE Usu_ID='" + i + "'";

            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable eliminar_usuario(string username)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_NombreUsuario='" + username + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();


            //LLENAR LOS DATOS DE CONSULTA EN EL DATATABLE

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }

        public static DataTable buscar_usuario(string username)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            DataTable dt;
            SqlCommand cmd = new SqlCommand();

            da = new SqlDataAdapter("select Usu_ID as 'ID', Usu_NombreUsuario as 'Username',Usu_Contraseña as 'Password',Usu_ApellidoNombre as 'Nombre y apellido',Rol_Descripcion as 'Roles' from Usuario LEFT JOIN Roles on Usuario.Rol_Codigo = Roles.Rol_Codigo where Usu_NombreUsuario Like '%" + username + "%'", cnn);
            dt = new DataTable();
            da.Fill(dt);

            return dt;

        }
    }
}