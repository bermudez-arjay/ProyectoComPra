using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {
        private Stack<Producto> stackProductos;
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
            stackProductos = new Stack<Producto>();

            btnFinslizarCompra.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            decimal precio;
            int cantidad;

            if(!decimal.TryParse(txtPrecioProducto.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingree un Precio Valido");
                return;
            }
            if (!int.TryParse(txtCantidadProducto.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese un Cantidad Validad");
                return;
            }

            Producto producto = new Producto(nombre,precio,cantidad);
            stackProductos.Push(producto);

            dgvCarrito.Rows.Add(producto.Nombre, producto.Cantidad, producto.Precio);

         

                total += producto.Precio * producto.Cantidad;

            txttotal.Text = Convert.ToString(total);
            LimpiarCampos();
            btnFinslizarCompra.Enabled = true;
        }


        private void btnFinslizarCompra_Click(object sender, EventArgs e)
        {
            decimal total = 0;


            while (stackProductos.Count > 0)
            {
              Producto  producto = stackProductos.Pop();

                total += producto.Precio * producto.Cantidad;
            }
            MessageBox.Show($"El Total de su compra fue de ${total}");
            MessageBox.Show("Gracias Por su compra");

            dgvCarrito.Rows.Clear();
            txttotal.Clear();
            btnFinslizarCompra.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadProducto.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
