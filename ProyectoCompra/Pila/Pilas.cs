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
        private Stack<Producto> stackProductos;
        decimal total = 0;
        public Pilas()
        {
            InitializeComponent();
            stackProductos = new Stack<Producto>();

            btnFinslizarCompra.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadProducto.Clear();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            decimal precio;
            int cantidad;

            if (!decimal.TryParse(txtPrecioProducto.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingree un Precio Valido");
                return;
            }
            if (!int.TryParse(txtCantidadProducto.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese un Cantidad Validad");
                return;
            }

            Producto producto = new Producto(nombre, precio, cantidad);
            stackProductos.Push(producto);

            dgvCarrito.Rows.Add(producto.Nombre, producto.Cantidad, producto.Precio);



            total += producto.Precio * producto.Cantidad;

            txttotal.Text = Convert.ToString(total);
            LimpiarCampos();
            btnFinslizarCompra.Enabled = true;
        }

        private void btnFinslizarCompra_Click_1(object sender, EventArgs e)
        {
            decimal total = 0;


            while (stackProductos.Count > 0)
            {
                Producto producto = stackProductos.Pop();

                total += producto.Precio * producto.Cantidad;
            }
            MessageBox.Show($"El Total de su compra fue de ${total}");
            MessageBox.Show("Gracias Por su compra");

            dgvCarrito.Rows.Clear();
            txttotal.Clear();
            btnFinslizarCompra.Enabled = false;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
