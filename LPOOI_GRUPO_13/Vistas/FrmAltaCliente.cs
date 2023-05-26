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
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
            loadClientes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #endregion

        public void loadClientes() 
        {
            dataGridCliente.DataSource = TrabajarCliente.listarClientesSp();
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCuit.Text = "";
            txtNroCarnet.Text = "";
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

        #region Operaciones ABM
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_DNI = txtDni.Text;
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Direccion = txtDireccion.Text;
                oCliente.Os_CUIT = txtCuit.Text;
                oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                TrabajarCliente.insertarClienteSp(oCliente);
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

            dataGridCliente.DataSource = TrabajarCliente.editarClienteSp(oCliente);
            loadClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = TrabajarCliente.eliminarClienteSp(txtDni.Text);
            loadClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridCliente.DataSource = TrabajarCliente.buscar_cliente(txtBuscar.Text);
            }
            else
            {
                loadClientes();
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = TrabajarCliente.ordenarClientesApellido();
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCuit.Text = "";
            txtNroCarnet.Text = "";
        }
        #endregion

        
    }
}
