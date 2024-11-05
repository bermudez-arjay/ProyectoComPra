using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasSimples
{
    public class Producto
    {
        public string Nombre { get; }
        public int Cantidad { get; }
        public decimal Precio { get; }

        public Producto(string nombre, int cantidad, decimal precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
