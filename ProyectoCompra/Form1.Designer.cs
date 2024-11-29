namespace ProyectoCompra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasCircularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesBinariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesAVLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floydToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marshallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem,
            this.ordenamientoToolStripMenuItem,
            this.arbolesToolStripMenuItem,
            this.grafosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1262, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.Pilas);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colasSimplesToolStripMenuItem,
            this.colasCircularesToolStripMenuItem});
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.colasToolStripMenuItem.Text = "Colas";
            // 
            // colasSimplesToolStripMenuItem
            // 
            this.colasSimplesToolStripMenuItem.Name = "colasSimplesToolStripMenuItem";
            this.colasSimplesToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.colasSimplesToolStripMenuItem.Text = "Colas simples";
            this.colasSimplesToolStripMenuItem.Click += new System.EventHandler(this.ColasSimples);
            // 
            // colasCircularesToolStripMenuItem
            // 
            this.colasCircularesToolStripMenuItem.Name = "colasCircularesToolStripMenuItem";
            this.colasCircularesToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.colasCircularesToolStripMenuItem.Text = "Colas Circulares";
            this.colasCircularesToolStripMenuItem.Click += new System.EventHandler(this.ColasCirculares);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasSimplesToolStripMenuItem,
            this.listasDoblesToolStripMenuItem});
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.listasToolStripMenuItem.Text = "Listas";
            // 
            // listasSimplesToolStripMenuItem
            // 
            this.listasSimplesToolStripMenuItem.Name = "listasSimplesToolStripMenuItem";
            this.listasSimplesToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.listasSimplesToolStripMenuItem.Text = "Listas simples";
            this.listasSimplesToolStripMenuItem.Click += new System.EventHandler(this.ListasSimples);
            // 
            // listasDoblesToolStripMenuItem
            // 
            this.listasDoblesToolStripMenuItem.Name = "listasDoblesToolStripMenuItem";
            this.listasDoblesToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.listasDoblesToolStripMenuItem.Text = "Listas dobles";
            this.listasDoblesToolStripMenuItem.Click += new System.EventHandler(this.ListasDobles);
            // 
            // ordenamientoToolStripMenuItem
            // 
            this.ordenamientoToolStripMenuItem.Name = "ordenamientoToolStripMenuItem";
            this.ordenamientoToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.ordenamientoToolStripMenuItem.Text = "Ordenamiento";
            this.ordenamientoToolStripMenuItem.Click += new System.EventHandler(this.ordenamientoToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesBinariosToolStripMenuItem,
            this.arbolesAVLToolStripMenuItem});
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            // 
            // arbolesBinariosToolStripMenuItem
            // 
            this.arbolesBinariosToolStripMenuItem.Name = "arbolesBinariosToolStripMenuItem";
            this.arbolesBinariosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.arbolesBinariosToolStripMenuItem.Text = "Arboles binarios";
            this.arbolesBinariosToolStripMenuItem.Click += new System.EventHandler(this.BinariosArboles);
            // 
            // arbolesAVLToolStripMenuItem
            // 
            this.arbolesAVLToolStripMenuItem.Name = "arbolesAVLToolStripMenuItem";
            this.arbolesAVLToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.arbolesAVLToolStripMenuItem.Text = "Arboles AVL";
            this.arbolesAVLToolStripMenuItem.Click += new System.EventHandler(this.AvlArboles);
            // 
            // grafosToolStripMenuItem
            // 
            this.grafosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijkstraToolStripMenuItem,
            this.floydToolStripMenuItem,
            this.marshallToolStripMenuItem});
            this.grafosToolStripMenuItem.Name = "grafosToolStripMenuItem";
            this.grafosToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.grafosToolStripMenuItem.Text = "Grafos";
            // 
            // dijkstraToolStripMenuItem
            // 
            this.dijkstraToolStripMenuItem.Name = "dijkstraToolStripMenuItem";
            this.dijkstraToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.dijkstraToolStripMenuItem.Text = "Dijkstra";
            this.dijkstraToolStripMenuItem.Click += new System.EventHandler(this.Dijkstra);
            // 
            // floydToolStripMenuItem
            // 
            this.floydToolStripMenuItem.Name = "floydToolStripMenuItem";
            this.floydToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.floydToolStripMenuItem.Text = "Floyd";
            this.floydToolStripMenuItem.Click += new System.EventHandler(this.Floyds);
            // 
            // marshallToolStripMenuItem
            // 
            this.marshallToolStripMenuItem.Name = "marshallToolStripMenuItem";
            this.marshallToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.marshallToolStripMenuItem.Text = "Marshall";
            this.marshallToolStripMenuItem.Click += new System.EventHandler(this.Marshal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 102);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasCircularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesBinariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesAVLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floydToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marshallToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

