using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDobles
{
    public partial class Form1 : Form
    {
        private ListaDobleProductos listaProductos = new ListaDobleProductos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            Producto producto = new Producto(nombre, precio, cantidad);
            listaProductos.AgregarProducto(producto);

            MostrarProductos();
        }

        public void MostrarProductos()
        {
            var productos = listaProductos.obtenerProductos();
            dataGridView1.DataSource = null;
          
            dataGridView1.DataSource = productos;
            dataGridView1.AutoGenerateColumns = false;

            decimal totalCompra = listaProductos.CalcularTotalCompra();
            txtTotalCompra.Text = totalCompra.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            listaProductos = new ListaDobleProductos();

            dataGridView1.DataSource = null;

            txtTotalCompra.Text = 0.00.ToString();

            MessageBox.Show("Desea Realizar esta Compra", "Confirmar Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
