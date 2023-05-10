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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            string ini = "SELECT Usu_NombreUsuario FROM Usuario WHERE (Usu_NombreUsuario=@username AND Usu_Contraseña=@password)";
            SqlCommand cmd = new SqlCommand(ini, cnn);
            DataTable list_users = TrabajarUsuario.listar_usuarios();
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            if (cmd.ExecuteScalar() != null)
            {
                MessageBox.Show("Bienvenido " + txtUsername.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (DataRow fila in list_users.Rows)
                {
                    if (fila["Username"].ToString() == txtUsername.Text && fila["Password"].ToString() == txtPassword.Text)
                    {
                        nombreApellido = fila["Nombre y Apellido"].ToString();
                        IdOperador = fila["ID"].ToString();
                        if (fila["Rol"].ToString() == "Administrador")
                        {
                            acceso = fila["Rol"].ToString();
                        }
                        else
                        {
                            if (fila["Rol"].ToString() == "Operador")
                            {
                                acceso = fila["Rol"].ToString();
                            }
                            else
                            {
                                if (fila["Rol"].ToString() == "Auditor")
                                {
                                    acceso = fila["Rol"].ToString();
                                }
                            }
                        }
                    }
                }
                FormPrincipal oFrmPrincipal = new FormPrincipal();
                this.Hide();
                oFrmPrincipal.Show();
                //oFrmPrincipal.ShowDialog();
                //this.Close();
            }
            else {
                MessageBox.Show("Usuario Invalido","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.Close();
        }

        /*private void btnLogin_Click_1(object sender, EventArgs e) {
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

      
        }*/



    }
}
