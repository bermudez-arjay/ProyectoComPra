using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasCirculares
{
    public partial class Form1 : Form
    {
        private CircularQueue<Product> _purchaseQueue;

        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = ""; 
            
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
