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
    public partial class FrmAbmCliente : Form
    {
        public FrmAbmCliente()
        {
            InitializeComponent();
            loadClientes();
        }

        public void loadClientes()
        {
            dataGridCliente.DataSource = TrabajarCliente.listarClientes();
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCuit.Text = "";
            txtNroCarnet.Text = "";
        }

        #region ABM (Guardar, Modificar, Eliminar, Buscar)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Obtener el número de DNI del cliente ingresado
                string dni = txtDni.Text;

                // Verificar si el número de DNI ya está registrado en la base de datos
                if (TrabajarCliente.ClienteExisteEnBaseDeDatos(dni))
                {
                    MessageBox.Show("El número de DNI ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si el número de DNI no está registrado, continuar con el proceso de guardar el cliente
                Cliente oCliente = new Cliente();
                oCliente.Cli_DNI = txtDni.Text;
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Direccion = txtDireccion.Text;
                oCliente.Os_CUIT = txtCuit.Text;
                oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                TrabajarCliente.guardarCliente(oCliente);
                loadClientes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente.Cli_DNI = txtDni.Text;
            oCliente.Cli_Apellido = txtApellido.Text;
            oCliente.Cli_Nombre = txtNombre.Text;
            oCliente.Cli_Direccion = txtDireccion.Text;
            oCliente.Os_CUIT = txtCuit.Text;
            oCliente.Cli_NroCarnet = txtNroCarnet.Text;

            dataGridCliente.DataSource = TrabajarCliente.modificarCliente(oCliente);
            loadClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = TrabajarCliente.eliminarCliente(txtDni.Text);
            loadClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridCliente.DataSource = TrabajarCliente.buscarCliente(txtBuscar.Text);
            }
            else
            {
                loadClientes();
            }
        }

        private void dataGridCliente_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridCliente.SelectedRows.Count > 0)
            {
                txtDni.Text = dataGridCliente.CurrentRow.Cells["DNI"].Value.ToString();
                txtApellido.Text = dataGridCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = dataGridCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dataGridCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCuit.Text = dataGridCliente.CurrentRow.Cells["CUIT"].Value.ToString();
                txtNroCarnet.Text = dataGridCliente.CurrentRow.Cells["N° Carnet"].Value.ToString();
                btnAgregar.Enabled = false;
            }
            else
                btnAgregar.Enabled = true;
        }
        #endregion

        private void FrmAbmCliente_Load(object sender, EventArgs e)
        {
            // Suscribirse al evento "TextChanged" de los TextBox
            txtDni.TextChanged += CamposTextChanged;
            txtApellido.TextChanged += CamposTextChanged;
            txtNombre.TextChanged += CamposTextChanged;
            txtDireccion.TextChanged += CamposTextChanged;
            txtCuit.TextChanged += CamposTextChanged;
            txtNroCarnet.TextChanged += CamposTextChanged;

            // Deshabilitar el botón inicialmente
            btnAgregar.Enabled = false;

            // Suscribirse al evento "KeyPress" de los TextBox
            txtDni.KeyPress += SoloNumerosKeyPress;
            txtCuit.KeyPress += SoloNumerosKeyPress;
            txtNroCarnet.KeyPress += SoloNumerosKeyPress;

            // Suscribirse al evento "KeyPress" de los TextBox
            txtApellido.KeyPress += SoloLetrasKeyPress;
            txtNombre.KeyPress += SoloLetrasKeyPress;
        }

        private void CamposTextChanged(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está vacío
            bool algunCampoVacio = string.IsNullOrEmpty(txtDni.Text) ||
                                    string.IsNullOrEmpty(txtApellido.Text) ||
                                    string.IsNullOrEmpty(txtNombre.Text) ||
                                    string.IsNullOrEmpty(txtDireccion.Text) ||
                                    string.IsNullOrEmpty(txtCuit.Text) ||
                                    string.IsNullOrEmpty(txtNroCarnet.Text);

            // Habilitar o deshabilitar el botón según el estado de los campos
            btnAgregar.Enabled = !algunCampoVacio;
        }

        private void SoloNumerosKeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void SoloLetrasKeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es una letra ni la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string columnaOrdenamiento = "";

            if (rbApellido.Checked)
            {
                columnaOrdenamiento = "Cli_Apellido";
            }
            else if (rbNombre.Checked)
            {
                columnaOrdenamiento = "Cli_Nombre";
            }
            else if (rbDni.Checked)
            {
                columnaOrdenamiento = "Cli_DNI";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción de ordenamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si no se seleccionó ninguna opción
            }

            dataGridCliente.DataSource = TrabajarCliente.ordenarClientes(columnaOrdenamiento);
            dataGridCliente.Refresh(); // Actualizar el DataGridView
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            loadClientes();
        }

        #region Efectos Botones
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

        private void btnOrdenar_MouseEnter(object sender, EventArgs e)
        {
            btnOrdenar.BackColor = Color.FromArgb(186, 39, 73);
            btnOrdenar.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnOrdenar_MouseLeave(object sender, EventArgs e)
        {
            btnOrdenar.BackColor = Color.FromArgb(23, 21, 32);
            btnOrdenar.ForeColor = Color.FromArgb(224, 224, 224);
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

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }

            // Verificar la longitud del texto después de ingresar el valor
            if (txtCuit.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }

            // Verificar la longitud del texto después de ingresar el valor
            if (txtDni.Text.Length >= 8 && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignorar la tecla presionada
            }

            // Verificar si el valor ingresado supera el límite de 100 millones
            if (txtDni.Text.Length == 7 && e.KeyChar != '\b')
            {
                string nuevoValor = txtDni.Text + e.KeyChar;
                int valor = int.Parse(nuevoValor);

                if (valor > 100000000)
                {
                    e.Handled = true; // Ignorar la tecla presionada
                }
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtDireccion.TextLength >= 200)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtApellido.TextLength >= 50)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtNombre.TextLength >= 50)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtNroCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }

            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtNroCarnet.TextLength >= 8)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

    }
}
