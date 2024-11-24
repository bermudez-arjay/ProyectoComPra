<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.ListasDoble
{
    public class Producto
    {

            public string Nombre { get; set; }

            public decimal Precio { get; set; }

            public int Cantidad { get; set; }

            public Producto(string nombre, decimal precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }
            public decimal Total => Precio * Cantidad;
       
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.ListasDoble
{
    public class Producto
    {

            public string Nombre { get; set; }

            public decimal Precio { get; set; }

            public int Cantidad { get; set; }

            public Producto(string nombre, decimal precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
            }
            public decimal Total => Precio * Cantidad;
       
    }
}
>>>>>>> 24435b81521438c5429d4046db0dcb9d216746c6
