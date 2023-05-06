using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int ven_Nro;

        public int Ven_Nro
        {
            get { return ven_Nro; }
            set { ven_Nro = value; }
        }
        private DateTime ven_Fecha;

        public DateTime Ven_Fecha
        {
            get { return ven_Fecha; }
            set { ven_Fecha = value; }
        }
        private string cli_Dni;

        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
    }
}
