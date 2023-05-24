using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Collections;
using ClasesBase;

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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO") {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") {
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

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    FrmPrincipal principal = new FrmPrincipal();
        //    FrmBienvenida frmBienvenida = new FrmBienvenida();
        //    SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
        //    cnn.Open();
        //    string ini = "SELECT Usu_Username FROM Usuario WHERE (Usu_Username=@username AND Usu_Contraseña=@password)";
        //    SqlCommand cmd = new SqlCommand(ini, cnn);
        //    DataTable list_users = TrabajarUsuario.listar_usuarios();
        //    cmd.Parameters.AddWithValue("@username", txtUsuario.Text);
        //    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

        //    if (cmd.ExecuteScalar() != null)
        //    {
                
        //        //MessageBox.Show("Bienvenido " + txtUsuario.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        foreach (DataRow fila in list_users.Rows)
        //        {
        //            if (fila["Username"].ToString() == txtUsuario.Text && fila["Password"].ToString() == txtPassword.Text)
        //            {
        //                nombreApellido = fila["Nombre y Apellido"].ToString();
        //                IdOperador = fila["ID"].ToString();
        //                if (fila["Rol"].ToString() == "Administrador")
        //                {
        //                    acceso = fila["Rol"].ToString();
        //                }
        //                else
        //                {
        //                    if (fila["Rol"].ToString() == "Operador")
        //                    {
        //                        acceso = fila["Rol"].ToString();
        //                    }
        //                    else
        //                    {
        //                        if (fila["Rol"].ToString() == "Auditor")
        //                        {
        //                            acceso = fila["Rol"].ToString();
        //                        }
        //                    }
        //                }
        //            }
        //        }
                
        //        frmBienvenida.NombreApellido = nombreApellido;
        //        frmBienvenida.IdOperador = IdOperador;
        //        frmBienvenida.Acceso = acceso;

        //        principal.NombreApellido = nombreApellido;
        //        principal.IdOperador = IdOperador;
        //        principal.Acceso = acceso;
        //    }
        //    this.Hide();
        //    //FrmBienvanida bienvenida = new FrmBienvanida();
        //    frmBienvenida.ShowDialog();
            
        //    principal.Show();
        //}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.nuevaOpticaConnectionString);
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
                }

                // Si llega a este punto, las credenciales no coinciden
                MessageBox.Show("El nombre de usuario o contraseña no coinciden");
            }
            else
            {
                // No se encontró el usuario, mostrar mensaje de error
                MessageBox.Show("El usuario " + txtUsuario.Text + " no existe");
            }

        }



    }
}
