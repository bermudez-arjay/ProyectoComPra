using ProyectoCompra.ArboleBinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.ArboleAVL
{
    public class NodoArbol
    {
        public int Dato { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }
        public int FactorEquilibrio { get; set; }

        public NodoArbol(int dato)
        {
            Dato = dato;
            Izquierdo = Derecho = null;
            FactorEquilibrio = 0;
        }
    }
}
