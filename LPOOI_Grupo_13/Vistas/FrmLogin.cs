using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class FrmLogin : Form
    {

        public static String acceso = "";
        public static String nombreApellido = "";
        public static String IdOperador = "";

        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMimiimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            FrmBienvenida frmBienvenida = new FrmBienvenida();

            // Limpiar mensajes de error
            errorUsuarioContraseña.SetError(txtPassword, "");
            errorUsuarioNoExiste.SetError(txtUsuario, "");

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.sistemaOpticaConnectionString);
            cnn.Open();
            string query = "SELECT Usu_Username FROM Usuario WHERE (Usu_Username=@username)";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@username", txtUsuario.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                // El nombre de usuario existe

                // Obtener los datos del usuario
                DataTable list_users = TrabajarUsuario.listar_usuarios();
                bool usuarioEncontrado = false; // Bandera para controlar si se encontró el usuario
                foreach (DataRow fila in list_users.Rows)
                {
                    if (fila["Username"].ToString().Equals(txtUsuario.Text) && fila["Password"].ToString().Equals(txtPassword.Text))
                    {
                        // Las credenciales coinciden, asignar los datos del usuario
                        nombreApellido = fila["Nombre y Apellido"].ToString();
                        IdOperador = fila["ID"].ToString();
                        if (fila["Rol"].ToString() == "Administrador")
                        {
                            acceso = fila["Rol"].ToString();
                        }
                        else if (fila["Rol"].ToString() == "Operador")
                        {
                            acceso = fila["Rol"].ToString();
                        }
                        else if (fila["Rol"].ToString() == "Auditor")
                        {
                            acceso = fila["Rol"].ToString();
                        }

                        // Mostrar las ventanas de bienvenida y principal
                        frmBienvenida.NombreApellido = nombreApellido;
                        frmBienvenida.IdOperador = IdOperador;
                        frmBienvenida.Acceso = acceso;

                        principal.NombreApellido = nombreApellido;
                        principal.IdOperador = IdOperador;
                        principal.Acceso = acceso;

                        this.Hide();
                        frmBienvenida.ShowDialog();
                        principal.Show();

                        // Salir del método ya que se encontraron las credenciales
                        return;
                    }
                    usuarioEncontrado = true;
                }

                // Si llega a este punto y el usuario no se encontró, mostrar mensaje de error
                if (!usuarioEncontrado)
                {
                    errorUsuarioNoExiste.SetError(txtUsuario, "El usuario " + txtUsuario.Text + " no existe");
                    return;
                }

                // Si llega a este punto, las credenciales no coinciden
                errorUsuarioContraseña.SetError(txtPassword, "El nombre de usuario o contraseña no coinciden");
                //MessageBox.Show("El nombre de usuario o contraseña no coinciden");
            }
            else
            {
                // No se encontró el usuario, mostrar mensaje de error
                errorUsuarioNoExiste.SetError(txtUsuario, "El usuario " + txtUsuario.Text + " no existe");
                //MessageBox.Show("El usuario " + txtUsuario.Text + " no existe");
            }

        }

        
    }
}
