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
    public partial class RegistrarVentas : Form
    {
        public RegistrarVentas()
        {
            InitializeComponent();
        }

        public void load_combo_clientes()
        {
            cmbRegistVCli.DisplayMember = "NombreApellido";
            cmbRegistVCli.ValueMember = "Cli_DNI";
            cmbRegistVCli.DataSource = TrabajarVenta.list_clientes();
        }

        private void RegistrarVentas_Load(object sender, EventArgs e)
        {
            load_combo_clientes();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            load_combo_clientes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            this.Close();
            fPrincipal.Show();
        }
    }
}
