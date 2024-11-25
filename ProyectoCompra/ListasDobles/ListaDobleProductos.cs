using ProyectoCompra.ListasDobles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoCompra.ListasDobles
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
    }

    public class Nodo
    {
        public Producto Producto { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }

        public Nodo(Producto producto)
        {
            Producto = producto;
            Siguiente = null;
            Anterior = null;
        }
    }

    public class ListaDobleProductos
    {
        private Nodo cabeza;

        public ListaDobleProductos()
        {
            cabeza = null;
        }


        public void AgregarProducto(Producto producto)
        {
            Nodo nuevoNodo = new Nodo(producto);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = temp;
            }
        }

        public List<Producto> obtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            Nodo temp = cabeza;
            while (temp != null)
            {
                productos.Add(temp.Producto);
                temp = temp.Siguiente;
            }
            return productos;
        }

        public void OrdenarAdelanteAtras()
        {
            if (cabeza == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Nodo temp = cabeza;
                while (temp.Siguiente != null)
                {
                    if (string.Compare(temp.Producto.Nombre, temp.Siguiente.Producto.Nombre) > 0)
                    {
                        Producto tempProducto = temp.Producto;
                        temp.Producto = temp.Siguiente.Producto;
                        temp.Siguiente.Producto = tempProducto;
                        swapped = true;
                    }
                    temp = temp.Siguiente;
                }
            } while (swapped);
        }


        public void OrdenarAtrasAdelante()
        {
            if (cabeza == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Nodo temp = cabeza;
                while (temp.Siguiente != null)
                {
                    if (string.Compare(temp.Producto.Nombre, temp.Siguiente.Producto.Nombre) < 0)
                    {
                        Producto tempProducto = temp.Producto;
                        temp.Producto = temp.Siguiente.Producto;
                        temp.Siguiente.Producto = tempProducto;
                        swapped = true;
                    }
                    temp = temp.Siguiente;
                }
            } while (swapped);
        }

        public void EliminarProducto(string nombre)
        {
            Nodo temp = cabeza;
            while (temp != null)
            {
                if (temp.Producto.Nombre == nombre)
                {
                    if (temp.Anterior != null)
                        temp.Anterior.Siguiente = temp.Siguiente;
                    if (temp.Siguiente != null)
                        temp.Siguiente.Anterior = temp.Anterior;

                    if (temp == cabeza)
                        cabeza = temp.Siguiente;

                    return;
                }
                temp = temp.Siguiente;
            }
        }

        public decimal CalcularTotalCompra()
        {
            decimal total = 0;
            Nodo temp = cabeza;
            while (temp != null)
            {
                total += temp.Producto.Precio * temp.Producto.Cantidad;
                temp = temp.Siguiente;
            }
            return total;
        }
    }
}
