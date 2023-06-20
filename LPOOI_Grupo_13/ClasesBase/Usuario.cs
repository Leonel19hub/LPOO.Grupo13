using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_Username;

        public string Usu_Username
        {
            get { return usu_Username; }
            set { usu_Username = value; }
        }
        private string usu_contraseña;

        public string Usu_contraseña
        {
            get { return usu_contraseña; }
            set { usu_contraseña = value; }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        private int rol_Codigo;

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Usuario(String nombreUsuario, String password, int rol)
        {
            Usu_Username = nombreUsuario;
            Usu_contraseña = password;
            Rol_Codigo = rol;
        }

        public Usuario() { }
    }
}
