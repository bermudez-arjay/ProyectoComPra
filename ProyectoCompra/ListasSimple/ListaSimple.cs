using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.ListasSimple
{
    public partial class ListaSimple : Form
    {
        public struct Producto
        {
            public string Nombre;
            public decimal Precio;
            public int Stock;

            public Producto(string nombre, decimal precio, int stock)
            {
                Nombre = nombre;
                Precio = precio;
                Stock = stock;
            }
        }

        public class Nodo
        {
            public Producto Producto;
            public Nodo Siguente;
            public Nodo(Producto producto)
            {
                Producto = producto;
                Siguente = null;
            }

        }
        public class ListaProductos
        {
            private Nodo cabeza;

            public void AgregarProductos(Producto producto)
            {
                Nodo nuevoNodo = new Nodo(producto);
                if (cabeza == null)
                {
                    cabeza = nuevoNodo;
                }
                else
                {
                    Nodo actual = cabeza;
                    while (actual.Siguente != null)
                    {
                        actual = actual.Siguente;

                    }
                    actual.Siguente = nuevoNodo;
                }
            }
            public List<Producto> ObtenerProductos()
            {
                List<Producto> productos = new List<Producto>();
                Nodo actual = cabeza;
                while (actual != null)
                {
                    productos.Add(actual.Producto);
                    actual = actual.Siguente;
                }
                return productos;
            }
        }
        private ListaProductos listaProductos = new ListaProductos();
        public ListaSimple()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            foreach (var producto in listaProductos.ObtenerProductos())
            {
                datgridventory.Rows.Add(producto.Nombre, producto.Precio, producto.Stock);
            }
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int stock = Convert.ToInt32(txtStock.Text);


            listaProductos.AgregarProductos(new Producto(nombre, precio, stock));
            CargarGrid();
        }

    }
}
