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
        int codvendedor;
        Decimal precio;
        string producto2;
        DateTime fechaventa;
        Decimal subtotal;
        public string Nit1 { get => Nit; set => Nit = value; }
        
        public decimal Precio { get => precio; set => precio = value; }
        public DateTime Fechaventa { get => fechaventa; set => fechaventa = value; }
        public string Producto2 { get => producto2; set => producto2 = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public int Codvendedor { get => codvendedor; set => codvendedor = value; }
    }
}
