using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoCompra.Grafos.Dijasktra.Dijasktra;

namespace ProyectoCompra.Grafos.Dijasktra
{
    public partial class Dijasktra : Form
    {
        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }

            public Producto(string nombre, decimal precio, int stock)
            {
                Nombre = nombre;
                Precio = precio;
                Stock = stock;
            }
        }

        public class Arista
        {
            public string Destino { get; set; }
            public decimal Costo { get; set; }

            public Arista(string destino, decimal costo)
            {
                Destino = destino;
                Costo = costo;
            }
        }

        public class Grafo
        {
            private Dictionary<string, Producto> productos;
            private Dictionary<string, List<Arista>> aristas;
            private Dictionary<string, List<Arista>> rutasAlmacenTienda;

            public Grafo()
            {
                productos = new Dictionary<string, Producto>();
                aristas = new Dictionary<string, List<Arista>>();
                rutasAlmacenTienda = new Dictionary<string, List<Arista>>();
            }

            public void AgregarProducto(Producto producto)
            {
                if (!productos.ContainsKey(producto.Nombre))
                {
                    productos.Add(producto.Nombre, producto);
                    aristas[producto.Nombre] = new List<Arista>();
                }
            }

            public void AgregarArista(string productoA, string productoB, decimal costo)
            {
                if (!productos.ContainsKey(productoA) || !productos.ContainsKey(productoB))
                    return;

                aristas[productoA].Add(new Arista(productoB, costo));
                aristas[productoB].Add(new Arista(productoA, costo));
            }

            public void AgregarRutaAlmacenTienda(string almacen, string tienda, decimal costo)
            {
                if (!rutasAlmacenTienda.ContainsKey(almacen))
                {
                    rutasAlmacenTienda[almacen] = new List<Arista>();
                }
                rutasAlmacenTienda[almacen].Add(new Arista(tienda, costo));
            }

            public (List<string> camino, decimal costo) ObtenerCaminoMinimo(string inicio, string fin)
            {
                var distancias = new Dictionary<string, decimal>();
                var predecesores = new Dictionary<string, string>();
                var noVisitados = new HashSet<string>(productos.Keys);

                foreach (var producto in productos.Keys)
                {
                    distancias[producto] = decimal.MaxValue;
                    predecesores[producto] = null;
                }
                distancias[inicio] = 0;

                while (noVisitados.Count > 0)
                {
                    var actual = noVisitados.OrderBy(p => distancias[p]).First();
                    noVisitados.Remove(actual);

                    if (actual == fin)
                    {
                        List<string> camino = new List<string>();
                        decimal costoTotal = distancias[fin];
                        while (predecesores[actual] != null)
                        {
                            camino.Insert(0, actual);
                            actual = predecesores[actual];
                        }
                        camino.Insert(0, inicio);
                        return (camino, costoTotal);
                    }

                    foreach (var arista in aristas[actual])
                    {
                        var vecino = arista.Destino;
                        var nuevoCosto = distancias[actual] + arista.Costo;
                        if (nuevoCosto < distancias[vecino])
                        {
                            distancias[vecino] = nuevoCosto;
                            predecesores[vecino] = actual;
                        }
                    }
                }

                return (null, decimal.MaxValue);
            }

            public decimal ObtenerCostoTransporte(string almacen, string tienda)
            {
                if (!rutasAlmacenTienda.ContainsKey(almacen))
                    return decimal.MaxValue;

                var ruta = rutasAlmacenTienda[almacen].FirstOrDefault(r => r.Destino == tienda);
                return ruta != null ? ruta.Costo : decimal.MaxValue;
            }

            public Producto ObtenerProducto(string nombre)
            {
                return productos.ContainsKey(nombre) ? productos[nombre] : null;
            }
        }

        private Grafo grafo;
        private List<Producto> carrito;

        public Dijasktra()
        {
            InitializeComponent();
            grafo = new Grafo();
            carrito = new List<Producto>();
            InicializarProductos();
            InicializarRutasAlmacenTienda();
        }
        private void InicializarProductos()
        {
            var productoA = new Producto("Producto A", 10.99m, 1);
            var productoB = new Producto("Producto B", 15.49m, 1);
            var productoC = new Producto("Producto C", 7.99m, 1);
            var productoD = new Producto("Producto D", 12.49m, 1);
            var productoE = new Producto("Producto E", 5.49m, 1);

            grafo.AgregarProducto(productoA);
            grafo.AgregarProducto(productoB);
            grafo.AgregarProducto(productoC);
            grafo.AgregarProducto(productoD);
            grafo.AgregarProducto(productoE);

            comboBoxProductos.Items.AddRange(new[] { "Producto A", "Producto B", "Producto C", "Producto D", "Producto E" });
        }

        private void InicializarRutasAlmacenTienda()
        {
            grafo.AgregarRutaAlmacenTienda("Almacen 1", "Tienda A", 5.0m);
            grafo.AgregarRutaAlmacenTienda("Almacen 1", "Tienda B", 7.0m);
            grafo.AgregarRutaAlmacenTienda("Almacen 1", "Tienda C", 6.0m);
            grafo.AgregarRutaAlmacenTienda("Almacen 2", "Tienda A", 3.5m);
            grafo.AgregarRutaAlmacenTienda("Almacen 2", "Tienda B", 4.0m);
            grafo.AgregarRutaAlmacenTienda("Almacen 2", "Tienda C", 2.5m);
            grafo.AgregarRutaAlmacenTienda("Almacen 3", "Tienda A", 4.5m);
            grafo.AgregarRutaAlmacenTienda("Almacen 3", "Tienda B", 6.0m);
            grafo.AgregarRutaAlmacenTienda("Almacen 3", "Tienda C", 5.5m);

            comboBoxAlmacen.Items.AddRange(new[] { "Almacen 1", "Almacen 2", "Almacen 3" });
            comboBoxTienda.Items.AddRange(new[] { "Tienda A", "Tienda B", "Tienda C" });
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            var productoSeleccionado = comboBoxProductos.SelectedItem.ToString();
            var producto = grafo.ObtenerProducto(productoSeleccionado);
            carrito.Add(producto);
            listBoxCarrito.Items.Add($"{producto.Nombre} - ${producto.Precio}");
        }

        private void btnEliminarCarrito_Click(object sender, EventArgs e)
        {
            if (listBoxCarrito.SelectedItem != null)
            {
                var productoSeleccionado = listBoxCarrito.SelectedItem.ToString().Split('-')[0].Trim();
                var producto = carrito.FirstOrDefault(p => p.Nombre == productoSeleccionado);
                if (producto != null)
                {
                    carrito.Remove(producto);
                    listBoxCarrito.Items.Remove(listBoxCarrito.SelectedItem);
                }
            }
        }

        private void btnCalcularTransporte_Click(object sender, EventArgs e)
        {
            var almacenSeleccionado = comboBoxAlmacen.SelectedItem.ToString();
            var tiendaSeleccionada = comboBoxTienda.SelectedItem.ToString();

            decimal costoTotal = 0;
            foreach (var producto in carrito)
            {
                decimal costoTransporte = grafo.ObtenerCostoTransporte(almacenSeleccionado, tiendaSeleccionada);
                costoTotal += producto.Precio + costoTransporte;
            }

            listBoxResultado.Items.Clear();
            listBoxResultado.Items.Add($"Costo total de los productos en el carrito: ${costoTotal}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
