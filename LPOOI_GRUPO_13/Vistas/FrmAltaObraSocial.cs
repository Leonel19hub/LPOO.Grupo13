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
    public partial class FrmAltaObraSocial : Form
    {
        public FrmAltaObraSocial()
        {
            InitializeComponent();
            load_obrasocial();
        }

        private void load_obrasocial() {
            dataGridObraSocial.DataSource = TrabajarObraSocial.listarObraSocial();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridObraSocial_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridObraSocial.SelectedRows.Count > 0)
            {
                txtCuit.Text = dataGridObraSocial.CurrentRow.Cells["CUIT"].Value.ToString();
                txtRazonSocial.Text = dataGridObraSocial.CurrentRow.Cells["Razon Social"].Value.ToString();
                txtDireccion.Text = dataGridObraSocial.CurrentRow.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = dataGridObraSocial.CurrentRow.Cells["N° Telefono"].Value.ToString();
                btnAgregar.Enabled = false;

            }
            else
                btnAgregar.Enabled = true;
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
        #endregion
    }
}
