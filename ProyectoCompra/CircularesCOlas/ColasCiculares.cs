using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.CircularesCOlas
{ 
    public partial class ColasCiculares : Form
    {
        private ColaCircular<Producto> _colaCompra;
        public class Producto
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }

            public Producto(string name, int quantity, decimal price)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
            }
        }

        public ColasCiculares()
        {
            InitializeComponent();
            lblStatus.Text = "";
            dataGridViewProducts.AutoGenerateColumns = false;
        }

        private void btnEstablecerTamaño_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQueueSize.Text, out int tamaño) && tamaño > 0)
            {
                _colaCompra = new ColaCircular<Producto>(tamaño);
                lblStatus.Text = $"Tamaño de la cola establecido a: {tamaño}";
                dataGridViewProducts.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un tamaño válido.");
                LimpiarCampos();
                txtQueueSize.Clear();
            }
        }

        private void btnAgregarAlFinal_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradasProducto(out Producto producto))
                return;

            try
            {
                _colaCompra.Encolar(producto); // Agregar al final
                ActualizarVista();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LimpiarCampos();

            }
        }

        private void btnAgregarAlInicio_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradasProducto(out Producto producto))
                return;

            try
            {
                _colaCompra.AgregarAlInicio(producto); // Agregar al inicio
                ActualizarVista();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LimpiarCampos();
            }
        }

        private void btnEliminarDelFinal_Click(object sender, EventArgs e)
        {
            try
            {
                Producto productoEliminado = _colaCompra.EliminarDelFinal();
                MessageBox.Show($"Se eliminó del final: {productoEliminado.Name}");
                ActualizarVista();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LimpiarCampos();
            }
        }

        private void btnEliminarDelInicio_Click(object sender, EventArgs e)
        {
            try
            {
                Producto productoEliminado = _colaCompra.Desencolar(); // Comportamiento estándar de eliminar desde el inicio
                MessageBox.Show($"Se eliminó del inicio: {productoEliminado.Name}");
                ActualizarVista();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LimpiarCampos();
            }
        }

        private bool ValidarEntradasProducto(out Producto producto)
        {
            producto = null;
            string nombre = txtProductName.Text;
            int cantidad;
            decimal precio;

            if (string.IsNullOrWhiteSpace(nombre) ||
                !int.TryParse(txtQuantity.Text, out cantidad) ||
                !decimal.TryParse(txtPrice.Text, out precio) ||
                cantidad <= 0 ||
                precio < 0)
            {
                MessageBox.Show("Por favor, ingresa datos válidos.");
                return false;
            }

            producto = new Producto(nombre, cantidad, precio);
            return true;
        }

        private void ActualizarVista()
        {
            dataGridViewProducts.Rows.Clear();
            foreach (var producto in _colaCompra.ConvertirAArray())
            {
                dataGridViewProducts.Rows.Add(producto.Name, producto.Quantity, producto.Price);
            }
        }

        private void LimpiarCampos()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
