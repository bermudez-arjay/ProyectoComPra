<<<<<<< HEAD
﻿using System;
using ProyectoCompra.CircularesCOlas;
using ProyectoCompra.BubleShort;
using ProyectoCompra.Pila;
using ProyectoCompra.ColasSimples;

using ProyectoCompra.ListasSimple;
using System.Windows.Forms;
using ProyectoCompra.ListasDobles;

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

        }

        private void Floyd(object sender, EventArgs e)
        {

        }

        private void Marshall(object sender, EventArgs e)
        {

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
    }
}
=======
﻿using System;
using ProyectoCompra.CircularesCOlas;
using ProyectoCompra.BubleShort;
using ProyectoCompra.Pila;
using ProyectoCompra.ColasSimples;

using ProyectoCompra.ListasSimple;
using System.Windows.Forms;
using ProyectoCompra.ListasDobles;

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

        }

        private void Floyd(object sender, EventArgs e)
        {

        }

        private void Marshall(object sender, EventArgs e)
        {

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
    }
}
>>>>>>> 24435b81521438c5429d4046db0dcb9d216746c6
