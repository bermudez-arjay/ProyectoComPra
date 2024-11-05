using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDobles
{
    public class NodoDoble
    {
        public Producto Producto { get; set; }
        public NodoDoble Siguiente { get; set; }
        public NodoDoble Anterior { get; set; }

        public NodoDoble(Producto producto) {
            Producto = producto;
            Siguiente = null;
            Anterior = null;
        }
    }
}
