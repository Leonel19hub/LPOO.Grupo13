using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class VentaDetalle
    {
        private int det_Nro;

        public int Det_Nro
        {
            get { return det_Nro; }
            set { det_Nro = value; }
        }
        private int ven_Nro;

        public int Ven_Nro
        {
            get { return ven_Nro; }
            set { ven_Nro = value; }
        }
        private string prod_Codigo;

        public string Prod_Codigo
        {
            get { return prod_Codigo; }
            set { prod_Codigo = value; }
        }
        private decimal det_Precio;

        public decimal Det_Precio
        {
            get { return det_Precio; }
            set { det_Precio = value; }
        }
        private decimal det_Cantidad;

        public decimal Det_Cantidad
        {
            get { return det_Cantidad; }
            set { det_Cantidad = value; }
        }
        private decimal det_Total;

        public decimal Det_Total
        {
            get { return det_Total; }
            set { det_Total = value; }
        }
    }
}
