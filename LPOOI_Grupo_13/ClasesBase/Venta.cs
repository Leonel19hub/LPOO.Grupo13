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
        private int cli_ID;

        public int Cli_ID
        {
            get { return cli_ID; }
            set { cli_ID = value; }
        }
    }
}
