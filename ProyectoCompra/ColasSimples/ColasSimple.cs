﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.ColasSimples
{
    public partial class ColasSimple : Form
    {
        public class Producto
        {
            public string Nombre { get; }
            public int Cantidad { get; }
            public decimal Precio { get; }

            public Producto(string nombre, int cantidad, decimal precio)
            {
                Nombre = nombre;
                Cantidad = cantidad;
                Precio = precio;
            }
        }

        private Queue<Producto> purchaseQueue;
        private int queueSize;

        public ColasSimple()
        {
            InitializeComponent();
            purchaseQueue = new Queue<Producto>(); 
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string nombre = txtProducto.Text;
            int cantidad;
            decimal precio;

            if (string.IsNullOrWhiteSpace(nombre) ||
                !int.TryParse(txtCantidad.Text, out cantidad) ||
                !decimal.TryParse(txtPrecio.Text, out precio) ||
                cantidad <= 0 ||
                precio < 0)
            {
                MessageBox.Show("Por favor, ingresa datos válidos.");
                return;
            }

            if (purchaseQueue == null)
            {
                MessageBox.Show("Por favor, establece el tamaño de la cola");
                return;
            }

            if (purchaseQueue.Count >= queueSize)
            {
                MessageBox.Show("La cola está llena. No se pueden agregar más productos.");
                return;
            }

            var producto = new Producto(nombre, cantidad, precio);
            purchaseQueue.Enqueue(producto);

            UpdateDataGridView();

            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTamaño.Text, out int size) && size > 0)
            {
                queueSize = size;
                purchaseQueue = new Queue<Producto>();

                MessageBox.Show("Tamaño de la cola definido. Ahora puedes agregar productos.");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un tamaño válido");
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (purchaseQueue.Count == 0)
            {
                MessageBox.Show("No hay productos para eliminar.");
                return;
            }

            Producto productoEliminado = purchaseQueue.Dequeue();

            UpdateDataGridView();

            MessageBox.Show($"Producto eliminado: {productoEliminado.Nombre}");
        }

        private void UpdateDataGridView()
        {
            dGVProductos.Rows.Clear();

            foreach (var producto in purchaseQueue)
            {
                dGVProductos.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
