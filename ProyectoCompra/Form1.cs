using System;
using ProyectoCompra.CircularesCOlas;
using ProyectoCompra.BubleShort;
using ProyectoCompra.Pila;
using ProyectoCompra.ColasSimples;
using ProyectoCompra.Grafos.Dijasktra;
using ProyectoCompra.Grafos.Floyd;
using ProyectoCompra.ListasSimple;
using System.Windows.Forms;
using ProyectoCompra.ListasDobles;
using ProyectoCompra.Grafos.Marshall;

namespace ProyectoCompra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pilas(object sender, EventArgs e)
        {
            Pilas frm = new Pilas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ColasSimples(object sender, EventArgs e)
        {
            ColasSimple frm = new ColasSimple();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ColasCirculares(object sender, EventArgs e)
        {
            ColasCiculares frm = new ColasCiculares();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ListasSimples(object sender, EventArgs e)
        {
            ListaSimple frm = new ListaSimple();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ListasDobles(object sender, EventArgs e)
        {
            ListaDoble frm  = new ListaDoble();
            frm.MdiParent = this;
            frm.Show();
        }


        private void ArbolesBinarios(object sender, EventArgs e)
        {

        }

        private void ArbolesAVL(object sender, EventArgs e)
        {

        }

        private void Dijkstra(object sender, EventArgs e)
        {
            Dijasktra frm = new Dijasktra();
            frm.MdiParent = this;   
            frm.Show();
        }



        private void ordenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             OrdenamientosPc frm = new OrdenamientosPc ();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Floyds(object sender, EventArgs e)
        {
            Floyd frm = new Floyd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Marshal(object sender, EventArgs e)
        {
            Marshall frm = new Marshall();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
