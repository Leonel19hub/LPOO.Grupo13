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
    public partial class FrmPrincipal : Form
    {

        public string NombreApellido { get; set; }
        public string IdOperador { get; set; }
        public string Acceso { get; set; }
        public FrmPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing() {
            panelProductSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;
        }

        private void hideSubMenu() {
            if (panelProductSubMenu.Visible == true)
                panelProductSubMenu.Visible = false;
            if (panelVentasSubMenu.Visible == true)
                panelVentasSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region Producto Menu
        private void btnProducto_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductSubMenu);
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAltaProducto());
            hideSubMenu();
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmDetalleVentaProducto());
            hideSubMenu();
        }
        #endregion
        #region Ventas Menu
        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentasSubMenu);
        }

        private void btnAltaVenta_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAltaVenta());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmComprasCliente());
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAltaCliente());
            //btnClientes.BackColor = Color.FromArgb(186, 39, 73);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Cierra la aplicación cuando se hace clic en la "X" de cierre
            }
        }

        private void btnObraSocial_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAltaObraSocial());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmAmbUsuario());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtUserName.Text = NombreApellido;
            txtUserRol.Text = Acceso;
            String acceso = FrmLogin.acceso;
            if (acceso == "Administrador")
            {
                btnClientes.Visible = false;
                btnObraSocial.Visible = false;
                btnVentas.Visible = false;
                panelVentasSubMenu.Visible = false;
            }
            else
            {
                if (acceso == "Operador")
                {
                    btnProducto.Visible = false;
                    panelProductSubMenu.Visible = false;
                    btnObraSocial.Visible = false;
                    btnUsuario.Visible = false;
                }
            }
        }
    }
}
