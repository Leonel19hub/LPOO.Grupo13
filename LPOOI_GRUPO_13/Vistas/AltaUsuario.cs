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
namespace Vistas
{
    public partial class AltaUsuario : Form { 
        int i;
        public AltaUsuario()
        {
            InitializeComponent();
            txtUsername.Text = " ";
            txtPassword.Text = " ";
            txtNyA.Text = " ";
            dataGridUser.CurrentCell = null;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }
        
        private void load_combo_roles()
        {
            cmbRol.DisplayMember = "rol_Descripcion";
            cmbRol.ValueMember = "rol_Codigo";
            cmbRol.DataSource = listar_roles();
        }
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
        private void load_usuarios()
        {
            dataGridUser.DataSource = listar_usuarios();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNyA.Text = "";
            
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

            cmd.CommandText = "INSERT INTO Usuario(Rol_Codigo,Usu_NombreUsuario,Usu_ApellidoNombre,Usu_Contraseña) values(@rol,@username,@AyN,@password)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@username", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@AyN", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@password", user.Usu_Contraseña);


            cnn.Open();
            cmd.ExecuteNonQuery();

            cnn.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            
            user.Rol_Codigo = cmbRol.SelectedValue.ToString();
            user.Usu_NombreUsuario = txtUsername.Text;
            user.Usu_Contraseña = txtPassword.Text;
            user.Usu_ApellidoNombre = txtNyA.Text;

            insertar_usuario(user);
            load_usuarios();
        }

        private void dataGridUser_CurrentCellChanged(object sender, EventArgs e)
        {   
            if(dataGridUser.SelectedRows.Count > 0){
                i = Convert.ToInt32(dataGridUser.CurrentRow.Cells["ID"].Value.ToString());
                cmbRol.Text = dataGridUser.CurrentRow.Cells["Rol"].Value.ToString();
                txtUsername.Text = dataGridUser.CurrentRow.Cells["Username"].Value.ToString();
                txtPassword.Text = dataGridUser.CurrentRow.Cells["Password"].Value.ToString();
                txtNyA.Text = dataGridUser.CurrentRow.Cells["Nombre y apellido"].Value.ToString();
                btnAgregar.Enabled = false;
            }else
            btnAgregar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
            Usuario oUser = new Usuario();
            dataGridUser.DataSource = modificar_usuario(oUser, txtUsername.Text, txtPassword.Text, txtNyA.Text, cmbRol.SelectedValue.ToString(),i);
            load_usuarios();
            dataGridUser.CurrentCell = null;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dataGridUser.DataSource = eliminar_usuario(txtUsername.Text);
            load_usuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridUser.DataSource = buscar_usuario(txtBuscar.Text);
            }
            else
            {
                load_usuarios();
            }
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

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtrasProd_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }
    }
}