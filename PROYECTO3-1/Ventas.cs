using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO3_1
{
    class Ventas
    {
        string Nit;
        string codvendedor;
        Decimal precio;
        DateTime fechaventa;

        public string Nit1 { get => Nit; set => Nit = value; }
        public string Codvendedor { get => codvendedor; set => codvendedor = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public DateTime Fechaventa { get => fechaventa; set => fechaventa = value; }

    }
}
