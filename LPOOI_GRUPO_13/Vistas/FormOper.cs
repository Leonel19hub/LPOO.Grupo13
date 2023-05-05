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
    public partial class FormOper : Form
    {
        public FormOper()
        {
            InitializeComponent();
        }

        private void msSistInquilinos_Click(object sender, EventArgs e)
        {
            AltaClientes altClientes = new AltaClientes();
            altClientes.Show();
            this.Close();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVentas frmVenta = new RegistrarVentas();
            frmVenta.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro quieres salir?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
