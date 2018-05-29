using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO3_1
{
    class Bodega
    {
        string producto;
        string cantidad;
        string precio;

        public string Producto { get => producto; set => producto = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Precio { get => precio; set => precio = value; }
    }
}
