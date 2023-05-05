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

        int rolUser;

        private void btnLogin_Click_1(object sender, EventArgs e) {
            Boolean foundUser = false;

            Usuario uAdministrador = new Usuario("Admin", "admin", "1");
            Usuario uOperador = new Usuario("Operador", "operador", "2");
            Usuario uAuditor = new Usuario("Auditor", "auditor", "3");

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(uAdministrador);
            usuarios.Add(uOperador);
            usuarios.Add(uAuditor);

            

            foreach (Usuario usuAux in usuarios) {
                if (usuAux.Usu_NombreUsuario == txtUsername.Text & usuAux.Usu_Contraseña == txtPassword.Text) {
                    foundUser = true;
                    switch (usuAux.Rol_Codigo) {
                        case "1": rolUser = 1; break;
                        case "2": rolUser = 2; break;
                        case "3": rolUser = 3; break;
                    }
                }
            }

            FormPrincipal fPrincipal = new FormPrincipal();
            FormMainAdmin frmAdmin = new FormMainAdmin();
            FormOper frmOper = new FormOper();

            if (foundUser) {
                switch (rolUser) {
                    case 1: 
                            MessageBox.Show("Bienvenido");
                            this.Hide();
                            frmAdmin.Show(); 
                            break;
                    case 2: 
                            MessageBox.Show("Bienvenido");
                            this.Hide();
                            frmOper.Show();
                            break;
                    case 3:
                            MessageBox.Show("Bienvenido");
                            this.Hide();
                            fPrincipal.Show();
                            break;
                }
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            /*SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            string ini = "SELECT Usu_NombreUsuario FROM Usuario WHERE (Usu_NombreUsuario=@usua AND Usu_Contraseña=@contra) ";
            SqlCommand com = new SqlCommand(ini, cnn);
            DataTable list_users = listar_usuarios();
            com.Parameters.AddWithValue("@usua", txtUsername.Text);
            com.Parameters.AddWithValue("@contra", txtPassword.Text);

            if (com.ExecuteScalar() != null)
            {

                MessageBox.Show("Bienvenido" + " " + txtUsername.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                foreach (DataRow fila in list_users.Rows)
                {
                    if (fila["Username"].ToString() == txtUsername.Text && fila["Password"].ToString() == txtPassword.Text)
                    {
                        nombreApellido = fila["Nombre y apellido"].ToString();
                        IdOperador = fila["ID"].ToString();
                        if (fila["Rol"].ToString() == "Administrador")
                        {
                            acceso = fila["Rol"].ToString();
                        }
                        else if (fila["Rol"].ToString() == "Auditor")
                        {
                            acceso = fila["Rol"].ToString();

                        }
                        else if (fila["Rol"].ToString() == "Operador")
                        {
                            acceso = fila["Rol"].ToString();

                        }
                    }
                }

                FormPrincipal fPrincipal = new FormPrincipal();
                //this.Hide();
                fPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            cnn.Close();*/
        }

    }
}
