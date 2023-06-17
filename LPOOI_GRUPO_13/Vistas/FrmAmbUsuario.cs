using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmAmbUsuario : Form
    {
        int idUser;
        public FrmAmbUsuario()
        {
            InitializeComponent();
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

        private void load_usuarios_sp()
        {
            dataGridUser.DataSource = TrabajarUsuario.exec_listar_usuarios_sp();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtNyA.Text = "";
        }
        //MEJORAR EL CODIGO
        private void dataGridUser_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridUser.SelectedRows.Count > 0)
            {
                int columnIndexID = dataGridUser.Columns["ID"].Index;
                int columnIndexRol = dataGridUser.Columns["Rol"].Index;
                int columnIndexUsername = dataGridUser.Columns["Username"].Index;
                int columnIndexPassword = dataGridUser.Columns["Password"].Index;
                int columnIndexNombreApellido = dataGridUser.Columns["Nombre y apellido"].Index;

                if (!Convert.IsDBNull(dataGridUser.CurrentRow.Cells[columnIndexID].Value))
                {
                    idUser = Convert.ToInt32(dataGridUser.CurrentRow.Cells[columnIndexID].Value);
                }
                else
                {
                    idUser = 0;
                }

                if (!Convert.IsDBNull(dataGridUser.CurrentRow.Cells[columnIndexRol].Value))
                {
                    cmbRol.Text = dataGridUser.CurrentRow.Cells[columnIndexRol].Value.ToString();
                }
                else
                {
                    cmbRol.Text = "";
                }

                if (!Convert.IsDBNull(dataGridUser.CurrentRow.Cells[columnIndexUsername].Value))
                {
                    txtUsername.Text = dataGridUser.CurrentRow.Cells[columnIndexUsername].Value.ToString();
                }
                else
                {
                    txtUsername.Text = "";
                }

                if (!Convert.IsDBNull(dataGridUser.CurrentRow.Cells[columnIndexPassword].Value))
                {
                    txtPassword.Text = dataGridUser.CurrentRow.Cells[columnIndexPassword].Value.ToString();
                }
                else
                {
                    txtPassword.Text = "";
                }

                if (!Convert.IsDBNull(dataGridUser.CurrentRow.Cells[columnIndexNombreApellido].Value))
                {
                    txtNyA.Text = dataGridUser.CurrentRow.Cells[columnIndexNombreApellido].Value.ToString();
                }
                else
                {
                    txtNyA.Text = "";
                }

                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            dataGridUser.DataSource = TrabajarUsuario.modificar_usuario(oUser, txtUsername.Text, txtPassword.Text, txtNyA.Text, cmbRol.SelectedValue.ToString(), idUser);
            load_usuarios();
            dataGridUser.CurrentCell = null;
        }

        private void FrmAmbUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            //load_usuarios();
            load_usuarios_sp();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Rol_Codigo = Convert.ToInt32(cmbRol.SelectedValue.ToString());
            user.Usu_Username = txtUsername.Text;
            user.Usu_contraseña = txtPassword.Text;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridUser.DataSource = TrabajarUsuario.eliminar_usuario(idUser);
            load_usuarios();
        }


        #region Efecto Hover en Botones

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.FromArgb(186, 39, 73);
            btnAgregar.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.FromArgb(23, 21, 32);
            btnAgregar.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.BackColor = Color.FromArgb(186, 39, 73);
            btnEditar.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackColor = Color.FromArgb(23, 21, 32);
            btnEditar.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(186, 39, 73);
            btnEliminar.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.FromArgb(23, 21, 32);
            btnEliminar.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(186, 39, 73);
            btnSalir.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(23, 21, 32);
            btnSalir.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.FromArgb(186, 39, 73);
            btnBuscar.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.FromArgb(23, 21, 32);
            btnBuscar.ForeColor = Color.FromArgb(224, 224, 224);
        }

        #endregion

        private void btnSalir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            load_usuarios_sp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridUser.DataSource = TrabajarProducto.ordenarClientesApellido();
        }
    }
}
