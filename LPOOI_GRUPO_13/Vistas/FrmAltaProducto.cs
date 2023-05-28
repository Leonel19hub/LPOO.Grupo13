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
    public partial class FrmAltaProducto : Form
    {
        public FrmAltaProducto()
        {
            InitializeComponent();
            loadProductos();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadProductos()
        {
            dataGridProducto.DataSource = TrabajarProducto.listarProductoSp();
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        int codigoProducto;

        //private void dataGridProducto_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    if (dataGridProducto.SelectedRows.Count > 0)
        //    {
        //        codigoProducto = Convert.ToInt32(dataGridProducto.CurrentRow.Cells["Codigo"].Value.ToString());
        //        txtNombre.Text = dataGridProducto.CurrentRow.Cells["Nombre"].Value.ToString();
        //        txtCategoria.Text = dataGridProducto.CurrentRow.Cells["Categoria"].Value.ToString();
        //        txtDescripcion.Text = dataGridProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
        //        txtPrecio.Text = dataGridProducto.CurrentRow.Cells["Precio"].Value.ToString();
        //        btnAgregar.Enabled = false;

        //    }
        //    else
        //        btnAgregar.Enabled = true;
        //}

        private void dataGridProducto_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridProducto.SelectedRows.Count > 0)
            {
                int columnIndexCodigo = dataGridProducto.Columns["Codigo"].Index;
                int columnIndexNombre = dataGridProducto.Columns["Nombre"].Index;
                int columnIndexCategoria = dataGridProducto.Columns["Categoria"].Index;
                int columnIndexDescripcion = dataGridProducto.Columns["Descripcion"].Index;
                int columnIndexPrecio = dataGridProducto.Columns["Precio"].Index;

                if (!Convert.IsDBNull(dataGridProducto.CurrentRow.Cells[columnIndexCodigo].Value))
                {
                    codigoProducto = Convert.ToInt32(dataGridProducto.CurrentRow.Cells[columnIndexCodigo].Value);
                }
                else
                {
                    codigoProducto = 0;
                }

                if (!Convert.IsDBNull(dataGridProducto.CurrentRow.Cells[columnIndexNombre].Value))
                {
                    txtNombre.Text = dataGridProducto.CurrentRow.Cells[columnIndexNombre].Value.ToString();
                }
                else
                {
                    txtNombre.Text = "";
                }

                if (!Convert.IsDBNull(dataGridProducto.CurrentRow.Cells[columnIndexCategoria].Value))
                {
                    txtCategoria.Text = dataGridProducto.CurrentRow.Cells[columnIndexCategoria].Value.ToString();
                }
                else
                {
                    txtCategoria.Text = "";
                }

                if (!Convert.IsDBNull(dataGridProducto.CurrentRow.Cells[columnIndexDescripcion].Value))
                {
                    txtDescripcion.Text = dataGridProducto.CurrentRow.Cells[columnIndexDescripcion].Value.ToString();
                }
                else
                {
                    txtDescripcion.Text = "";
                }

                if (!Convert.IsDBNull(dataGridProducto.CurrentRow.Cells[columnIndexPrecio].Value))
                {
                    txtPrecio.Text = dataGridProducto.CurrentRow.Cells[columnIndexPrecio].Value.ToString();
                }
                else
                {
                    txtPrecio.Text = "";
                }

                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }


        #region Operaciones ABM
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Producto oProducto = new Producto();
                oProducto.Prod_Nombre = txtNombre.Text;
                oProducto.Prod_Categoria = txtCategoria.Text;
                oProducto.Prod_Descripcion = txtDescripcion.Text;
                oProducto.Prod_Precio = decimal.Parse(txtPrecio.Text);

                TrabajarProducto.insertarProductoSp(oProducto);
                loadProductos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Producto oProducto = new Producto();
            oProducto.Prod_Codigo = codigoProducto;
            oProducto.Prod_Nombre = txtNombre.Text;
            oProducto.Prod_Categoria = txtCategoria.Text;
            oProducto.Prod_Descripcion = txtDescripcion.Text;
            oProducto.Prod_Precio = decimal.Parse(txtPrecio.Text);

            dataGridProducto.DataSource = TrabajarProducto.editarProductoSp(oProducto);
            loadProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridProducto.DataSource = TrabajarProducto.eliminarProductoSp(codigoProducto);
            loadProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridProducto.DataSource = TrabajarProducto.buscar_producto(txtBuscar.Text);
            }
            else
            {
                loadProductos();
            }
        }
        #endregion

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (radioCategoria.Checked)
            {
                dataGridProducto.DataSource = TrabajarProducto.listar_productos_categoria_sp();
            }
            else
            {
                if (radioDescripcion.Checked)
                {
                    dataGridProducto.DataSource = TrabajarProducto.listar_productos_descripcion_sp();
                }
            }
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número ni el punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                // Bloquear el carácter ingresado
                e.Handled = true;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar el botón según si el texto es un número válido
            decimal precio;
            bool esNumero = decimal.TryParse(txtPrecio.Text, out precio);
            btnAgregar.Enabled = esNumero && precio != 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            loadProductos();
        }

    }
}
