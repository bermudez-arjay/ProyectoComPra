using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.ArboleBinario
{
    public partial class ArbolesBinarios : Form
    {
        private ArbolBinario arbol;
        private List<int> numeros;
        public ArbolesBinarios()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
            numeros = new List<int>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (!numeros.Contains(numero))
                {
                    numeros.Add(numero);
                    arbol.Insertar(numero);
                    ActualizarListaNumeros();
                    MessageBox.Show($"Número {numero} agregado al árbol.", "Éxito");
                }
                else
                {
                    MessageBox.Show("El número ya existe en el árbol.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error");
            }
        }

        private void btnRecorridoPreorden_Click(object sender, EventArgs e)
        {
            txtRecorridos.Text = "Preorden: " + arbol.ObtenerRecorridoPreorden();
        }

        private void btnRecorridoInorden_Click(object sender, EventArgs e)
        {
            txtRecorridos.Text = "Inorden: " + arbol.ObtenerRecorridoInorden();
        }

        private void btnRecorridoPosorden_Click(object sender, EventArgs e)
        {
            txtRecorridos.Text = "Posorden: " + arbol.ObtenerRecorridoPosorden();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                try
                {
                    arbol.Eliminar(numero);
                    numeros.Remove(numero);
                    ActualizarListaNumeros();
                    MessageBox.Show($"Número {numero} eliminado del árbol.", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el número: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error");
            }
        }
        private void ActualizarListaNumeros()
        {
            lstNumeros.Items.Clear();
            foreach (var num in numeros)
            {
                lstNumeros.Items.Add(num);
            }
        }
    }
}
