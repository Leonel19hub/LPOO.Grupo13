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

        
        private void load_combo_roles()
        {
            cmbRol.DisplayMember = "rol_Descripcion";
            cmbRol.ValueMember = "rol_Codigo";
            cmbRol.DataSource = TrabajarUsuario.listar_roles();
        }
        
        private void load_usuarios()
        {
            dataGridUser.DataSource = TrabajarUsuario.listar_usuarios();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNyA.Text = "";
            
        }

        private void load_usuarios_sp(){
            dataGridUser.DataSource = TrabajarUsuario.exec_listar_usuarios_sp();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNyA.Text = "";
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
            dataGridUser.DataSource = TrabajarUsuario.modificar_usuario(oUser, txtUsername.Text, txtPassword.Text, txtNyA.Text, cmbRol.SelectedValue.ToString(),i);
            load_usuarios();
            dataGridUser.CurrentCell = null;
        }

        private void btnAtrasProd_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            //load_usuarios();
            load_usuarios_sp();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Rol_Codigo = cmbRol.SelectedValue.ToString();
            user.Usu_NombreUsuario = txtUsername.Text;
            user.Usu_Contraseña = txtPassword.Text;
            user.Usu_ApellidoNombre = txtNyA.Text;

            TrabajarUsuario.insertar_usuario(user);
            load_usuarios_sp();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridUser.DataSource = TrabajarUsuario.buscar_usuario(txtBuscar.Text);
            }
            else
            {
                load_usuarios();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dataGridUser.DataSource = TrabajarUsuario.eliminar_usuario(txtUsername.Text);
            load_usuarios();
        }

        public static DataTable get_count_user_x_rol_sp(int rol_id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "borrar_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            //Parametro de entrada
            cmd.Parameters.AddWithValue("@rol_id", rol_id);
            cmd.ExecuteNonQuery();
            cnn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void dataGridUser_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (dataGridUser.SelectedRows.Count > 0)
            {
                i = Convert.ToInt32(dataGridUser.CurrentRow.Cells["ID"].Value.ToString());
                cmbRol.Text = dataGridUser.CurrentRow.Cells["Rol"].Value.ToString();
                txtUsername.Text = dataGridUser.CurrentRow.Cells["Username"].Value.ToString();
                txtPassword.Text = dataGridUser.CurrentRow.Cells["Password"].Value.ToString();
                txtNyA.Text = dataGridUser.CurrentRow.Cells["Nombre y apellido"].Value.ToString();
                btnAgregar.Enabled = false;
            }
            else
                btnAgregar.Enabled = true;
        }
    }
}