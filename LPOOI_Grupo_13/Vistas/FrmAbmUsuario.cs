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
    public partial class FrmAbmUsuario : Form
    {
        int idUser;
        public FrmAbmUsuario()
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
            // Ajustar el ancho de las columnas
            AjustarAnchoColumnas();
        }

        private void AjustarAnchoColumnas()
        {
            // Establecer el ancho de la primera columna (ID) a un valor específico
            int columnIndexID = dataGridUser.Columns["ID"].Index;
            dataGridUser.Columns[columnIndexID].Width = 20; // Establece el ancho deseado en píxeles

            // Establecer el modo de ajuste automático en las demás columnas
            for (int i = 0; i < dataGridUser.Columns.Count; i++)
            {
                if (i != columnIndexID)
                {
                    dataGridUser.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtNyA.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin insertar el usuario
            }

            // Si todos los campos tienen datos, proceder con la inserción del usuario
            Usuario user = new Usuario();

            user.Rol_Codigo = Convert.ToInt32(cmbRol.SelectedValue.ToString());
            user.Usu_Username = txtUsername.Text;
            user.Usu_contraseña = txtPassword.Text;
            user.Usu_ApellidoNombre = txtNyA.Text;

            TrabajarUsuario.insertar_usuario(user);
            load_usuarios();
        }

        private void FrmAbmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }
        private void CamposTextChanged(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está vacío
            bool algunCampoVacio = string.IsNullOrEmpty(txtUsername.Text) ||
                                    string.IsNullOrEmpty(txtPassword.Text) ||
                                    string.IsNullOrEmpty(txtNyA.Text);

            // Habilitar o deshabilitar el botón según el estado de los campos
            btnAgregar.Enabled = !algunCampoVacio;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            dataGridUser.DataSource = TrabajarUsuario.modificar_usuario(oUser, txtUsername.Text, txtPassword.Text, txtNyA.Text, cmbRol.SelectedValue.ToString(), idUser);
            load_usuarios();
            dataGridUser.CurrentCell = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener la lista de usuarios con sus roles
            DataTable usuariosDataTable = TrabajarUsuario.listar_usuarios();

            // Verificar si el usuario a eliminar es de tipo 'Auditor'
            bool esAuditor = usuariosDataTable.AsEnumerable()
                                              .Any(u => u.Field<int>("ID") == idUser && u.Field<string>("Rol") == "Auditor");

            if (esAuditor)
            {
                // Verificar si es el último usuario de tipo 'Auditor'
                int cantidadAuditores = usuariosDataTable.AsEnumerable()
                                                         .Count(u => u.Field<string>("Rol") == "Auditor");

                if (cantidadAuditores == 1)
                {
                    MessageBox.Show("No se puede eliminar el último usuario de tipo 'Auditor'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Continuar con la eliminación del usuario
            dataGridUser.DataSource = TrabajarUsuario.eliminar_usuario(idUser);
            load_usuarios();
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridUser.DataSource = TrabajarUsuario.ordenarClientesApellido();
            // Ajustar el ancho de las columnas después de ordenar
            AjustarAnchoColumnas();
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(186, 39, 73);
            button1.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(23, 21, 32);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnClean_MouseEnter(object sender, EventArgs e)
        {
            btnClean.BackColor = Color.FromArgb(186, 39, 73);
            btnClean.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnClean_MouseLeave(object sender, EventArgs e)
        {
            btnClean.BackColor = Color.FromArgb(23, 21, 32);
            btnClean.ForeColor = Color.FromArgb(224, 224, 224);
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            load_usuarios();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtUsername.TextLength >= 50)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtPassword.TextLength >= 50)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtNyA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtPassword.TextLength >= 100)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }


        
    }
}
