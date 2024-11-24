using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.BubleShort

{
  

    public partial class OrdenamientosPc : Form
    {

        public class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }

            public Producto(string nombre, int cantidad, decimal precio)
            {
                Nombre = nombre;
                Cantidad = cantidad;
                Precio = precio;
            }

            public override string ToString()
            {
                return $"{Nombre} - Cantidad: {Cantidad} - Precio: {Precio:C}";
            }
        }
        private List<Producto> productos = new List<Producto>();
        public OrdenamientosPc()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreP.Text;
            int cantidad = Convert.ToInt32(txtCantidadP.Text);
            decimal precio = Convert.ToDecimal(txtPrecioP.Text);

            Producto nuevoProducto = new Producto(nombre, cantidad, precio);
            productos.Add(nuevoProducto);

            UpdateProductList();
        }
        private void UpdateProductList()
        {
            listBox1.Items.Clear();
            foreach (var producto in productos)
            {
                listBox1.Items.Add(producto);
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Func<Producto, Producto, int> comparer = GetComparer();
            if (comparer == null)
            {
                MessageBox.Show("Por favor, seleccione un criterio de ordenación.");
                return;
            }

            List<Producto> sortedList = null;
            if (rbBubbleSort.Checked)
                sortedList = BubbleSort(productos, comparer);
            else if (rbQuickSort.Checked)
                sortedList = QuickSort(productos, 0, productos.Count - 1, comparer);
            else if (rbHeapSort.Checked)
                sortedList = HeapSort(productos, comparer);
            else if (rbSelectionSort.Checked)
                sortedList = SelectionSort(productos, comparer);
            else if (rbShakeSort.Checked)
                sortedList = ShakeSort(productos, comparer);
            else if (rbShellSort.Checked)
                sortedList = ShellSort(productos, comparer);
            else
            {
                MessageBox.Show("Por favor, seleccione un algoritmo de ordenación.");
                return;
            }

            productos = sortedList;
            UpdateProductList();
        }
        private Func<Producto, Producto, int> GetComparer()
        {
            if (rbNombre.Checked)
                return (a, b) => a.Precio.CompareTo(b.Precio);
            else if (rbCantidad.Checked)
                return (a, b) => a.Cantidad.CompareTo(b.Cantidad);
            else if (rbPrecio.Checked)
                return (a, b) => a.Nombre.CompareTo(b.Nombre);
            else
                return null;
        }

        private List<Producto> BubbleSort(List<Producto> list, Func<Producto, Producto, int> comparer)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (comparer(list[j], list[j + 1]) > 0)
                    {
                        Producto temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        private List<Producto> QuickSort(List<Producto> list, int low, int high, Func<Producto, Producto, int> comparer)
        {
            if (low < high)
            {
                int pi = Partition(list, low, high, comparer);
                QuickSort(list, low, pi - 1, comparer);
                QuickSort(list, pi + 1, high, comparer);
            }
            return list;
        }

        private int Partition(List<Producto> list, int low, int high, Func<Producto, Producto, int> comparer)
        {
            Producto pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (comparer(list[j], pivot) < 0)
                {
                    i++;
                    Producto temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            Producto temp1 = list[i + 1];
            list[i + 1] = list[high];
            list[high] = temp1;

            return i + 1;
        }

        private List<Producto> HeapSort(List<Producto> list, Func<Producto, Producto, int> comparer)
        {
            int n = list.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(list, n, i, comparer);

            for (int i = n - 1; i > 0; i--)
            {
                Producto temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                Heapify(list, i, 0, comparer);
            }
            return list;
        }

        private void Heapify(List<Producto> list, int n, int i, Func<Producto, Producto, int> comparer)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && comparer(list[left], list[largest]) > 0)
                largest = left;

            if (right < n && comparer(list[right], list[largest]) > 0)
                largest = right;

            if (largest != i)
            {
                Producto temp = list[i];
                list[i] = list[largest];
                list[largest] = temp;

                Heapify(list, n, largest, comparer);
            }
        }

        private List<Producto> SelectionSort(List<Producto> list, Func<Producto, Producto, int> comparer)
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (comparer(list[j], list[minIndex]) < 0)
                        minIndex = j;
                }

                Producto temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
            }
            return list;
        }

       
        private List<Producto> ShakeSort(List<Producto> list, Func<Producto, Producto, int> comparer)
        {
            int left = 0;
            int right = list.Count - 1;
            bool swapped = true;

            while (left < right && swapped)
            {
                swapped = false;

                for (int i = left; i < right; i++)
                {
                    if (comparer(list[i], list[i + 1]) > 0)
                    {
                        Producto temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
                right--;

                if (!swapped) break;

                swapped = false;

                for (int i = right; i > left; i--)
                {
                    if (comparer(list[i], list[i - 1]) < 0)
                    {
                        Producto temp = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = temp;
                        swapped = true;
                    }
                }
                left++;
            }
            return list;
        }
        private List<Producto> ShellSort(List<Producto> list, Func<Producto, Producto, int> comparer)
        {
            int n = list.Count;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    Producto temp = list[i];
                    int j;
                    for (j = i; j >= gap && comparer(list[j - gap], temp) > 0; j -= gap)
                    {
                        list[j] = list[j - gap];
                    }
                    list[j] = temp;
                }
            }
            return list;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
