using ProyectoCompra.BubleShort;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace ProyectoCompra.Pila
{

    public partial class Pilas : Form
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

        private Stack<Producto> stackProductos; // Pila de productos
        private const int MaxSize = 5; // Tamaño máximo de la pila
        private decimal total = 0;

        public Pilas()
        {
            InitializeComponent();
            stackProductos = new Stack<Producto>();
            btnFinslizarCompra.Enabled = false;
            ActualizarEstadoPila();
            dgvCarrito.AllowUserToAddRows = false;
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadProducto.Clear();
        }

        private void ActualizarEstadoPila()
        {
            lblEstadoPila.Text = $"Tamaño actual: {stackProductos.Count}/{MaxSize}";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (stackProductos.Count >= MaxSize)
            {
                MessageBox.Show($"La pila está llena. No se pueden agregar más de {MaxSize} productos.");
                return;
            }

            string nombre = txtNombreProducto.Text;
            decimal precio;
            int cantidad;

            if (!decimal.TryParse(txtPrecioProducto.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            if (!int.TryParse(txtCantidadProducto.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }
            dgvCarrito.AllowUserToAddRows = false;



            Producto producto = new Producto(nombre, precio, cantidad);
            stackProductos.Push(producto);

            dgvCarrito.Rows.Add(producto.Nombre, producto.Cantidad, producto.Precio);

            total += producto.Precio * producto.Cantidad;
            txttotal.Text = total.ToString();

            LimpiarCampos();
            btnFinslizarCompra.Enabled = true;
            ActualizarEstadoPila();
        }

        private void btnFinslizarCompra_Click_1(object sender, EventArgs e)
        {
            if (stackProductos.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
                return;
            }

            decimal totalCompra = 0;

            while (stackProductos.Count > 0)
            {
                Producto producto = stackProductos.Pop();
                totalCompra += producto.Precio * producto.Cantidad;
            }

            MessageBox.Show($"El total de su compra fue de ${totalCompra}");
            MessageBox.Show("Gracias por su compra.");

            dgvCarrito.Rows.Clear();
            txttotal.Clear();
            btnFinslizarCompra.Enabled = false;
            total = 0;

            ActualizarEstadoPila();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            if (stackProductos.Count == 0)
            {
                MessageBox.Show("No hay productos para eliminar.");
                return;
            }

            Producto productoEliminado = stackProductos.Pop();

            total -= productoEliminado.Precio * productoEliminado.Cantidad;
            txttotal.Text = total.ToString();

            if (dgvCarrito.Rows.Count > 0)
            {
                dgvCarrito.Rows.RemoveAt(dgvCarrito.Rows.Count - 1);
            }

            ActualizarEstadoPila();

            MessageBox.Show($"Se eliminó el último producto: {productoEliminado.Nombre}");
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
