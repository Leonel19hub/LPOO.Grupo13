using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Globalization;

namespace Vistas
{
    public partial class FrmAbmProducto : Form
    {

        int codigoProducto;

        public FrmAbmProducto()
        {
            InitializeComponent();
            loadProductos();
            //dataGridProducto.CellFormatting += dataGridProducto_CellFormatting;
        }

        private void loadProductos()
        {
            dataGridProducto.DataSource = TrabajarProducto.listarProductos();
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            dataGridProducto.Columns["Precio"].DefaultCellStyle.Format = "0.##";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ABM (Guardar, Modificar, Eliminar, Buscar)

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Cliente?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Obtener el nombre del producto ingresado
                string nombre = txtNombre.Text;

                // Verificar si el nombre del producto ya está registrado en la base de datos
                if (TrabajarProducto.ProductoExisteEnBaseDeDatos(nombre))
                {
                    MessageBox.Show("El nombre del producto ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si el número de nombre no esta registrado, continuar con el proceso de guardar el producto
                Producto oProducto = new Producto();
                oProducto.Prod_Nombre = txtNombre.Text;
                oProducto.Prod_Categoria = txtCategoria.Text;
                oProducto.Prod_Descripcion = txtDescripcion.Text;
                oProducto.Prod_Precio = decimal.Parse(txtPrecio.Text);
                //oProducto.Prod_Precio = decimal.Parse(txtPrecio.Text, CultureInfo.GetCultureInfo("es-ES"));
                //MessageBox.Show("El precio es"+oProducto.Prod_Precio);
                TrabajarProducto.guardarProducto(oProducto);
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

            dataGridProducto.DataSource = TrabajarProducto.modificarProducto(oProducto);
            loadProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridProducto.DataSource = TrabajarProducto.eliminarProducto(codigoProducto);
            loadProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dataGridProducto.DataSource = TrabajarProducto.buscarProductos(txtBuscar.Text);
            }
            else
            {
                loadProductos();
            }
        }

        #endregion

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

        private void btnClean_Click(object sender, EventArgs e)
        {
            loadProductos();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string columnaOrdenamiento = "";

            if (radioDescripcion.Checked)
            {
                columnaOrdenamiento = "Prod_Descripcion";
            }
            else if (radioCategoria.Checked)
            {
                columnaOrdenamiento = "Prod_Categoria";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción de ordenamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si no se seleccionó ninguna opción
            }

            dataGridProducto.DataSource = TrabajarProducto.ordenarProductos(columnaOrdenamiento);
            dataGridProducto.Refresh(); // Actualizar el DataGridView
        }

        private void FrmAbmProducto_Load(object sender, EventArgs e)
        {
            // Suscribirse al evento "TextChanged" de los TextBox
            txtNombre.TextChanged += CamposTextChanged;
            txtDescripcion.TextChanged += CamposTextChanged;
            txtCategoria.TextChanged += CamposTextChanged;
            txtPrecio.TextChanged += CamposTextChanged;

            // Deshabilitar el botón inicialmente
            btnAgregar.Enabled = false;

            // Suscribirse al evento "KeyPress" de los TextBox
            txtPrecio.KeyPress += SoloNumerosKeyPress;
        }

        private void CamposTextChanged(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está vacío
            bool algunCampoVacio = string.IsNullOrEmpty(txtNombre.Text) ||
                                    string.IsNullOrEmpty(txtDescripcion.Text) ||
                                    string.IsNullOrEmpty(txtCategoria.Text) ||
                                    string.IsNullOrEmpty(txtPrecio.Text);

            // Habilitar o deshabilitar el botón según el estado de los campos
            btnAgregar.Enabled = !algunCampoVacio;
        }

        private void SoloNumerosKeyPress(object sender, KeyPressEventArgs e)
        {
            char separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            // Verificar si la tecla presionada no es un número, el separador decimal ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != separator)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
            else if (e.KeyChar == separator && ((sender as TextBox).Text.Contains(separator)))
            {
                e.Handled = true; // Ignorar el segundo separador decimal
            }
        }
        //No funciona el formateo de precio
        private void dataGridProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridProducto.Columns[e.ColumnIndex].Name == "Precio" && e.Value != null)
            {
                if (e.Value is decimal)
                {
                    decimal precio = (decimal)e.Value;
                    e.Value = precio.ToString("0.##");
                    e.FormattingApplied = true;
                }
            }
        }

        #region Efecto Botones
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtNombre.TextLength >= 100)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtDescripcion.TextLength >= 200)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtCategoria.TextLength >= 50)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Continuar permitiendo la tecla de retroceso
                return;
            }

            // Verificar si el texto ya alcanzó la longitud máxima permitida
            if (txtPrecio.TextLength >= 8)
            {
                // Ignorar la tecla presionada
                e.Handled = true;
                return;
            }

            // Continuar permitiendo la tecla presionada
        }
    }
}
