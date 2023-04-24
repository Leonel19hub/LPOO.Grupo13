using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Usuario
    {
        private int rol_Id;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }
        private int user_Id;
        private String usr_Apellido;

        public String Usr_Apellido
        {
            get { return usr_Apellido; }
            set { usr_Apellido = value; }
        }
        private string usr_Nombre;

        public string Usr_Nombre
        {
            get { return usr_Nombre; }
            set { usr_Nombre = value; }
        }
        private string usr_Email;

        public string Usr_Email
        {
            get { return usr_Email; }
            set { usr_Email = value; }
        }
        private string usr_Password;

        public string Usr_Password
        {
            get { return usr_Password; }
            set { usr_Password = value; }
        }
        private string usr_UserName;

        public string Usr_UserName
        {
            get { return usr_UserName; }
            set { usr_UserName = value; }
        }

        public int User_Id
        {
            get { return user_Id; }
            set { user_Id = value; }
        }
    }
}
