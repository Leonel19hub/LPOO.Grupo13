using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaClientes altClientes = new AltaClientes();
            altClientes.Show();
            this.Close();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProducto altProductos = new AltaProducto();
            altProductos.Show();
            this.Close();
        }

        private void altaObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaObraSocial altObraSocial = new AltaObraSocial();
            altObraSocial.Show();
            this.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            altaUsuario.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro quieres salir?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void msSistInquilinos_Click(object sender, EventArgs e)
        {

        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVentas frmVenta = new RegistrarVentas();
            frmVenta.Show();
            this.Close();
        }
    }
}
