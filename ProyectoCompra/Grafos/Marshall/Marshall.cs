using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.Grafos.Marshall
{

 
        public partial class Marshall : Form
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


            public class GrafoMarshall
            {
                private Dictionary<string, Producto> productos;
                private Dictionary<string, List<Arista>> aristas;
                private Dictionary<string, Dictionary<string, decimal>> distancias;
                private Dictionary<string, Dictionary<string, string>> predecesores;
                private Dictionary<string, Dictionary<string, decimal>> costosTransporte;

                public GrafoMarshall()
                {
                    productos = new Dictionary<string, Producto>();
                    aristas = new Dictionary<string, List<Arista>>();
                    distancias = new Dictionary<string, Dictionary<string, decimal>>();
                    predecesores = new Dictionary<string, Dictionary<string, string>>();
                    costosTransporte = new Dictionary<string, Dictionary<string, decimal>>();
                }
                public void AgregarProducto(Producto producto)
                {
                    if (!productos.ContainsKey(producto.Nombre))
                    {
                        productos.Add(producto.Nombre, producto);
                        aristas[producto.Nombre] = new List<Arista>();
                    }
                }

                public void AgregarRutaTransporte(string almacen, string tienda, decimal costo)
                {
                    if (!costosTransporte.ContainsKey(almacen))
                    {
                        costosTransporte[almacen] = new Dictionary<string, decimal>();
                    }
                    costosTransporte[almacen][tienda] = costo;
                }
                public Producto ObtenerProducto(string nombre)
                {
  
                    return productos.ContainsKey(nombre) ? productos[nombre] : null;
                }
                public void InicializarMatrices()
                {
                    var todosLosNodos = new HashSet<string>(productos.Keys);

                    foreach (var almacen in costosTransporte.Keys)
                    {
                        todosLosNodos.Add(almacen);
                        foreach (var tienda in costosTransporte[almacen].Keys)
                        {
                            todosLosNodos.Add(tienda);
                        }
                    }

                    foreach (var nodo in todosLosNodos)
                    {
                        distancias[nodo] = new Dictionary<string, decimal>();
                        predecesores[nodo] = new Dictionary<string, string>();

                        foreach (var otroNodo in todosLosNodos)
                        {
                            if (nodo == otroNodo)
                            {
                                distancias[nodo][otroNodo] = 0;
                                predecesores[nodo][otroNodo] = null;
                            }
                            else
                            {
                                distancias[nodo][otroNodo] = decimal.MaxValue;
                                predecesores[nodo][otroNodo] = null;
                            }
                        }
                    }

                    foreach (var producto in productos.Keys)
                    {
                        foreach (var arista in aristas[producto])
                        {
                            distancias[producto][arista.Destino] = arista.Costo;
                            predecesores[producto][arista.Destino] = producto;
                        }
                    }

                    foreach (var almacen in costosTransporte.Keys)
                    {
                        foreach (var tienda in costosTransporte[almacen].Keys)
                        {
                            distancias[almacen][tienda] = costosTransporte[almacen][tienda];
                            predecesores[almacen][tienda] = almacen;
                        }
                    }
                }

                public void EjecutarFloydWarshall()
                {
                    foreach (var k in distancias.Keys)
                    {
                        foreach (var i in distancias.Keys)
                        {
                            foreach (var j in distancias.Keys)
                            {
                                if (distancias[i][k] < decimal.MaxValue && distancias[k][j] < decimal.MaxValue)
                                {
                                    decimal nuevoCosto = distancias[i][k] + distancias[k][j];

                                    if (nuevoCosto < distancias[i][j] && nuevoCosto < decimal.MaxValue)
                                    {
                                        distancias[i][j] = nuevoCosto;
                                        predecesores[i][j] = predecesores[k][j];
                                    }
                                }
                            }
                        }
                    }
                }

                public (List<string> camino, decimal costo) ObtenerCaminoMinimo(string inicio, string fin)
                {
                    if (distancias[inicio][fin] == decimal.MaxValue)
                        return (null, decimal.MaxValue);

                    List<string> camino = new List<string>();
                    decimal costoTotal = distancias[inicio][fin];

                    string actual = fin;
                    while (actual != inicio)
                    {
                        camino.Insert(0, actual);
                        actual = predecesores[inicio][actual];
                    }
                    camino.Insert(0, inicio);

                    return (camino, costoTotal);
                }
            }


            private GrafoMarshall grafo;
            private List<Producto> carrito;

            public Marshall()
            {
                InitializeComponent();
                grafo = new GrafoMarshall();
                carrito = new List<Producto>();
                InicializarProductos();
                InicializarRutas();
                grafo.InicializarMatrices();
                grafo.EjecutarFloydWarshall();
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

            private void InicializarRutas()
            {
                grafo.AgregarRutaTransporte("Almacen 1", "Tienda A", 5.0m);
                grafo.AgregarRutaTransporte("Almacen 1", "Tienda B", 7.0m);
                grafo.AgregarRutaTransporte("Almacen 1", "Tienda C", 6.0m);
                grafo.AgregarRutaTransporte("Almacen 2", "Tienda A", 3.5m);
                grafo.AgregarRutaTransporte("Almacen 2", "Tienda B", 4.0m);
                grafo.AgregarRutaTransporte("Almacen 2", "Tienda C", 2.5m);
                grafo.AgregarRutaTransporte("Almacen 3", "Tienda A", 4.5m);
                grafo.AgregarRutaTransporte("Almacen 3", "Tienda B", 6.0m);
                grafo.AgregarRutaTransporte("Almacen 3", "Tienda C", 5.5m);

                comboBoxAlmacen.Items.AddRange(new[] { "Almacen 1", "Almacen 2", "Almacen 3" });
                comboBoxTienda.Items.AddRange(new[] { "Tienda A", "Tienda B", "Tienda C" });
            }

            private void btnAgregarCarrito_Click(object sender, EventArgs e)
            {
                var productoSeleccionado = comboBoxProductos.SelectedItem.ToString();
                var producto = grafo.ObtenerProducto(productoSeleccionado);
                if (producto != null)
                {
                    carrito.Add(producto);
                    listBoxCarrito.Items.Add($"{producto.Nombre} - ${producto.Precio}");
                }
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
                    costoTotal += producto.Precio;
                }

                var (camino, costoTransporte) = grafo.ObtenerCaminoMinimo(almacenSeleccionado, tiendaSeleccionada);

                listBoxResultado.Items.Clear();
                listBoxResultado.Items.Add($"Costo total de los productos en el carrito: ${costoTotal}");
                listBoxResultado.Items.Add($"Costo de transporte de {almacenSeleccionado} a {tiendaSeleccionada}: ${costoTransporte}");
            }
        }
}

