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
    public partial class AltaClientes : Form
    {
        public AltaClientes()
        {
            InitializeComponent();
            load_clientes();
        }

        private void AltaClientes_Load(object sender, EventArgs e)
        {
            load_clientes();
        }

        private void load_clientes()
        {
            dataGridCliente.DataSource = TrabajarCliente.listar_clientes();
  
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDir.Text = "";
            textCuit.Text = "";
            textNroCarnet.Text = "";
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_Dni = txtDni.Text;
                oCliente.Cli_Apellido = txtApellido.Text;
                oCliente.Cli_Nombre = txtNombre.Text;
                oCliente.Cli_Direccion = txtDir.Text;
                oCliente.Os_Cuit = textCuit.Text;
                oCliente.Cli_NroCarnet = textNroCarnet.Text;

                TrabajarCliente.insertar_cliente(oCliente);
                load_clientes();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = TrabajarCliente.eliminar_cliente(txtDni.Text);
            load_clientes();
        }

        private void dataGridCliente_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridCliente.SelectedRows.Count > 0){
                txtDni.Text = dataGridCliente.CurrentRow.Cells["Dni"].Value.ToString();
                txtApellido.Text = dataGridCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = dataGridCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDir.Text = dataGridCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                textCuit.Text = dataGridCliente.CurrentRow.Cells["Cuit"].Value.ToString();
                textNroCarnet.Text = dataGridCliente.CurrentRow.Cells["N° Carnet"].Value.ToString();
                btnEnviar.Enabled = false;

            }
            else
                btnEnviar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string j = txtDni.Text;
            Cliente oCliente = new Cliente();
            dataGridCliente.DataSource = TrabajarCliente.modificar_cliente(oCliente, txtDni.Text, txtNombre.Text, txtApellido.Text, txtDir.Text, textCuit.Text, textNroCarnet.Text, j);
            load_clientes();
            dataGridCliente.CurrentCell = null;
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            if (txtBuscarCli.Text != "")
            {
                dataGridCliente.DataSource = TrabajarCliente.buscar_cliente(txtBuscarCli.Text);
            }
            else
            {
                load_clientes();
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = TrabajarCliente.listar_clientes_ordenados_sp();
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDir.Text = "";
            textCuit.Text = "";
            textNroCarnet.Text = "";
        }

        

        
    }
}
