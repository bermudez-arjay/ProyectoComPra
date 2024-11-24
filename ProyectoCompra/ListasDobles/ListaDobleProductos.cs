﻿using ProyectoCompra.ListasDoble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoCompra.ListasDobles
{
    public class NodoDoble
    {
        public Producto Producto { get; set; }
        public NodoDoble Siguiente { get; set; }
        public NodoDoble Anterior { get; set; }

        public NodoDoble(Producto producto)
        {
            Producto = producto;
            Siguiente = null;
            Anterior = null;
        }
    }
    public class ListaDobleProductos
    {
        private NodoDoble cabeza;
        private NodoDoble cola;

        public void AgregarProducto(Producto producto)
        {
            var nuevonodo = new NodoDoble(producto);

            if (cabeza == null)
            {
                cabeza = cola = nuevonodo;
            }
            else
            {
                cola.Siguiente = nuevonodo;
                nuevonodo.Anterior = cola;
                cola = nuevonodo;

            }

        }
        public List<Producto> obtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            NodoDoble actual = cabeza;

            while (actual != null)
            {
                productos.Add(actual.Producto);
                actual = actual.Siguiente;
            }
            return productos;
        }

        public decimal CalcularTotalCompra()
        {
            decimal total = 0;
            NodoDoble actual = cabeza;

            while (actual != null)
            {
                total += actual.Producto.Total;
                actual = actual.Siguiente;
            }
            return total;
        }
    }
}