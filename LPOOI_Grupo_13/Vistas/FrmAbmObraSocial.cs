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
    public partial class FrmAbmObraSocial : Form
    {
        int idCuit;

        public FrmAbmObraSocial()
        {
            InitializeComponent();
            load_obrasocial();
        }

        public void load_comco_obraSocial()
        {
            cmbObraSocial.SelectedIndex = -1;
            cmbObraSocial.DisplayMember = "NAME";
            cmbObraSocial.ValueMember = "OS_RazonSocial";
            cmbObraSocial.DataSource = TrabajarObraSocial.list_ObraSocial();
        }

        private void load_obrasocial()
        {
            dataGridObraSocial.DataSource = TrabajarObraSocial.listarObraSocial();
            txtCuit.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            // Ajustar el ancho de las columnas
            AjustarAnchoColumnas();
        }

        private void AjustarAnchoColumnas()
        {
            // Calcula el ancho total del DataGridView
            int totalWidth = dataGridObraSocial.Width;

            // Calcula los anchos proporcionales para cada columna (por ejemplo, 30% para la primera columna y 70% para la segunda columna)
            int widthColumn1 = (int)(totalWidth * 0.3);
            int widthColumn2 = (int)(totalWidth * 0.7);

            // Establecer el ancho de la primera columna (ID) a un valor específico
            int columnIndexID = dataGridObraSocial.Columns["ID"].Index;
            int columnIndexCuit = dataGridObraSocial.Columns["CUIT"].Index;
            int columnIndexRazonSocial = dataGridObraSocial.Columns["Razon Social"].Index;
            int columnIndexDireccion = dataGridObraSocial.Columns["Direccion"].Index;
            int columnIndexTelefono = dataGridObraSocial.Columns["N° Telefono"].Index;
            dataGridObraSocial.Columns[columnIndexID].Width = (int)(totalWidth * 0.04);
            dataGridObraSocial.Columns[columnIndexCuit].Width = (int)(totalWidth * 0.11);
            dataGridObraSocial.Columns[columnIndexRazonSocial].Width = (int)(totalWidth * 0.25);
            dataGridObraSocial.Columns[columnIndexDireccion].Width = (int)(totalWidth * 0.48);
            dataGridObraSocial.Columns[columnIndexTelefono].Width = (int)(totalWidth * 0.12);
            // Establece el ancho deseado en píxeles

            // Establecer el modo de ajuste automático en las demás columnas
            for (int i = 0; i < dataGridObraSocial.Columns.Count; i++)
            {
                if (i != columnIndexID)
                {
                    dataGridObraSocial.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObraSocial oObraSocial = new ObraSocial();
                oObraSocial.Os_Cuit = txtCuit.Text;
                oObraSocial.Os_RazonSocial = txtRazonSocial.Text;
                oObraSocial.Os_Direccion = txtDireccion.Text;
                oObraSocial.Os_Telefono = txtTelefono.Text;

                TrabajarObraSocial.guardarObraSocial(oObraSocial);
                load_obrasocial();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ObraSocial oObraSocial = new ObraSocial();
            oObraSocial.Os_Id = idCuit;
            oObraSocial.Os_Cuit = txtCuit.Text;
            oObraSocial.Os_RazonSocial = txtRazonSocial.Text;
            oObraSocial.Os_Direccion = txtDireccion.Text;
            oObraSocial.Os_Telefono = txtTelefono.Text;

            dataGridObraSocial.DataSource = TrabajarObraSocial.modificarObraSocial(oObraSocial);
            load_obrasocial();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar MessageBox de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta obra social?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Continuar con la eliminación de la obra social
                dataGridObraSocial.DataSource = TrabajarObraSocial.eliminarObraSocial(idCuit);
                load_obrasocial();
            }
        }

        private void dataGridObraSocial_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridObraSocial.SelectedRows.Count > 0)
            {
                int columnIndexID = dataGridObraSocial.Columns["ID"].Index;
                int columnIndexCuit = dataGridObraSocial.Columns["CUIT"].Index;
                int columnIndexRazonSocial = dataGridObraSocial.Columns["Razon Social"].Index;
                int columnIndexDireccion = dataGridObraSocial.Columns["Direccion"].Index;
                int columnIndexTelefono = dataGridObraSocial.Columns["N° Telefono"].Index;

                if (!Convert.IsDBNull(dataGridObraSocial.CurrentRow.Cells[columnIndexID].Value))
                {
                    idCuit = Convert.ToInt32(dataGridObraSocial.CurrentRow.Cells[columnIndexID].Value);
                }
                else
                {
                    idCuit = 0;
                }

                if (!Convert.IsDBNull(dataGridObraSocial.CurrentRow.Cells[columnIndexCuit].Value))
                {
                    txtCuit.Text = dataGridObraSocial.CurrentRow.Cells[columnIndexCuit].Value.ToString();
                }
                else
                {
                    txtCuit.Text = "";
                }

                if (!Convert.IsDBNull(dataGridObraSocial.CurrentRow.Cells[columnIndexRazonSocial].Value))
                {
                    txtRazonSocial.Text = dataGridObraSocial.CurrentRow.Cells[columnIndexRazonSocial].Value.ToString();
                }
                else
                {
                    txtRazonSocial.Text = "";
                }

                if (!Convert.IsDBNull(dataGridObraSocial.CurrentRow.Cells[columnIndexDireccion].Value))
                {
                    txtDireccion.Text = dataGridObraSocial.CurrentRow.Cells[columnIndexDireccion].Value.ToString();
                }
                else
                {
                    txtDireccion.Text = "";
                }

                if (!Convert.IsDBNull(dataGridObraSocial.CurrentRow.Cells[columnIndexTelefono].Value))
                {
                    txtTelefono.Text = dataGridObraSocial.CurrentRow.Cells[columnIndexTelefono].Value.ToString();
                }
                else
                {
                    txtTelefono.Text = "";
                }

                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            load_obrasocial();
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            dataGridObraSocial.DataSource = TrabajarObraSocial.buscarObraSocialCliente(cmbObraSocial.SelectedValue.ToString());
        }

        private void FrmAbmObraSocial_Load(object sender, EventArgs e)
        {
            load_comco_obraSocial();
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

        private void btnBuscarClientes_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarClientes.BackColor = Color.FromArgb(186, 39, 73);
            btnBuscarClientes.ForeColor = Color.FromArgb(23, 21, 32);
        }

        private void btnBuscarClientes_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarClientes.BackColor = Color.FromArgb(23, 21, 32);
            btnBuscarClientes.ForeColor = Color.FromArgb(224, 224, 224);
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b') // Verificar si es la tecla de retroceso
            {
                return; // Permitir la tecla de retroceso sin aplicar las demás restricciones
            }

            string telefono = txtTelefono.Text + e.KeyChar; // Obtener el número de teléfono actual agregando la tecla presionada

            // Verificar si el número comienza con "0800"
            if (telefono.StartsWith("0800"))
            {
                // Verificar si el total de dígitos es igual a 11
                if (telefono.Length > 11)
                {
                    e.Handled = true; // Ignorar la tecla presionada
                }
            }
            else
            {
                // Verificar si el total de dígitos es igual a 10
                if (telefono.Length > 10)
                {
                    e.Handled = true; // Ignorar la tecla presionada
                }
            }
        }

    }
}
