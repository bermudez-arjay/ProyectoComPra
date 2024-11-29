using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.ArboleAVL
{
    public partial class ArbolesAVL : Form
    {
        private ArbolAVL arbol;
        private List<int> numeros;
        public ArbolesAVL()
        {
            InitializeComponent();
            arbol = new ArbolAVL();
            numeros = new List<int>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (!numeros.Contains(numero))
                {
                    try
                    {
                        numeros.Add(numero);
                        arbol.Insertar(numero);
                        ActualizarListaNumeros();
                        MessageBox.Show($"Número {numero} agregado al árbol AVL.", "Éxito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al agregar el número: {ex.Message}", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("El número ya existe en el árbol AVL.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error");
            }

            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnRecorridoPreorden_Click(object sender, EventArgs e)
        {
            try
            {
                txtRecorridos.Text = "Preorden: " + arbol.ObtenerRecorridoPreorden();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el recorrido: {ex.Message}", "Error");
            }
        }

        private void btnRecorridoPosorden_Click(object sender, EventArgs e)
        {
            try
            {
                txtRecorridos.Text = "Posorden: " + arbol.ObtenerRecorridoPosorden();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el recorrido: {ex.Message}", "Error");
            }
        }

        private void btnRecorridoInorden_Click(object sender, EventArgs e)
        {
            try
            {
                txtRecorridos.Text = "Inorden: " + arbol.ObtenerRecorridoInorden();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el recorrido: {ex.Message}", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (numeros.Contains(numero))
                {
                    try
                    {
                        arbol.Eliminar(numero);
                        numeros.Remove(numero);
                        ActualizarListaNumeros();
                        MessageBox.Show($"Número {numero} eliminado del árbol AVL.", "Éxito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el número: {ex.Message}", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("El número no se encuentra en el árbol AVL.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error");
            }

            txtNumero.Clear();
            txtNumero.Focus();
        }
        private void ActualizarListaNumeros()
        {
            lstNumeros.Items.Clear();
            foreach (var num in numeros.OrderBy(x => x))
            {
                lstNumeros.Items.Add(num);
            }
        }
    }
}
