using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using ClasesBase;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class FormLogin : Form
    {
        public static String acceso = "";
        public static String nombreApellido = "";
        public static String IdOperador = "";


        public FormLogin()
        {
            InitializeComponent();
        }


        public static DataTable listar_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlDataAdapter da;
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter("select Usu_ID as 'ID', Usu_NombreUsuario as 'Username', Usu_Contraseña as 'Password', Usu_ApellidoNombre as 'Nombre y apellido',Rol_Descripcion as 'Rol' from Usuario LEFT JOIN Roles on Usuario.Rol_Codigo=Roles.Rol_Codigo", cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        private void btnLogin_Click_1(object sender, EventArgs e) {
            Boolean foundUser = false;

            Usuario uAdministrador = new Usuario("Admin", "admin", "1");
            Usuario uOperador = new Usuario("Operador", "operador", "3");
            Usuario uAuditor = new Usuario("Auditor", "auditor", "2");

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(uAdministrador);
            usuarios.Add(uOperador);
            usuarios.Add(uAuditor);

            

            foreach (Usuario usuAux in usuarios) {
                if (usuAux.Usu_NombreUsuario == txtUsername.Text & usuAux.Usu_Contraseña == txtPassword.Text) {
                    foundUser = true;
                }
            }

            FormPrincipal fPrincipal = new FormPrincipal();

            if (foundUser) {
                MessageBox.Show("Bienvenido");
                this.Hide();
                fPrincipal.Show();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

      
        }

    }
}
