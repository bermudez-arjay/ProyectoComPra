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
        public class Product
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }

            public Product(string name, int quantity, decimal price)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
            }
        }
        private CircularQueue<Product> _purchaseQueue;
        public ColasCiculares()
        {
            InitializeComponent();
            lblStatus.Text = "";
        }

        private void btnQueueSize_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQueueSize.Text, out int size) && size > 0)
            {
                _purchaseQueue = new CircularQueue<Product>(size);
                lblStatus.Text = $"Tamaño de la cola establecido a: {size}";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un tamaño válido.");
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            int quantity;
            decimal price;

            if (string.IsNullOrWhiteSpace(name) ||
                !int.TryParse(txtQuantity.Text, out quantity) ||
                !decimal.TryParse(txtPrice.Text, out price) ||
                quantity <= 0 ||
                price < 0)
            {
                MessageBox.Show("Por favor, ingresa datos válidos.");
                return;
            }

            try
            {
                if (_purchaseQueue == null)
                {
                    MessageBox.Show("Por favor, establece el tamaño de la cola primero.");
                    return;
                }

                var product = new Product(name, quantity, price);
                _purchaseQueue.Enqueue(product);
                dataGridViewProducts.Rows.Add(product.Name, product.Quantity, product.Price);
                txtProductName.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
