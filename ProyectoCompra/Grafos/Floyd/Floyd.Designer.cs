namespace ProyectoCompra.Grafos.Floyd
{
    partial class Floyd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxCarrito = new System.Windows.Forms.ListBox();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.btnEliminarCarrito = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAlmacen = new System.Windows.Forms.ComboBox();
            this.comboBoxTienda = new System.Windows.Forms.ComboBox();
            this.btnCalcularTransporte = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listBoxCarrito);
            this.groupBox3.Controls.Add(this.comboBoxProductos);
            this.groupBox3.Controls.Add(this.btnAgregarCarrito);
            this.groupBox3.Controls.Add(this.btnEliminarCarrito);
            this.groupBox3.Location = new System.Drawing.Point(101, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(698, 261);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione un producto para agregar al carrito";
            // 
            // listBoxCarrito
            // 
            this.listBoxCarrito.FormattingEnabled = true;
            this.listBoxCarrito.ItemHeight = 20;
            this.listBoxCarrito.Location = new System.Drawing.Point(292, 16);
            this.listBoxCarrito.Name = "listBoxCarrito";
            this.listBoxCarrito.Size = new System.Drawing.Size(394, 224);
            this.listBoxCarrito.TabIndex = 0;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(6, 204);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(93, 36);
            this.btnAgregarCarrito.TabIndex = 7;
            this.btnAgregarCarrito.Text = "Agregar C";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // btnEliminarCarrito
            // 
            this.btnEliminarCarrito.Location = new System.Drawing.Point(177, 204);
            this.btnEliminarCarrito.Name = "btnEliminarCarrito";
            this.btnEliminarCarrito.Size = new System.Drawing.Size(93, 36);
            this.btnEliminarCarrito.TabIndex = 8;
            this.btnEliminarCarrito.Text = "Eliminar C";
            this.btnEliminarCarrito.UseVisualStyleBackColor = true;
            this.btnEliminarCarrito.Click += new System.EventHandler(this.btnEliminarCarrito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tienda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Almacen";
            // 
            // comboBoxAlmacen
            // 
            this.comboBoxAlmacen.FormattingEnabled = true;
            this.comboBoxAlmacen.Location = new System.Drawing.Point(95, 34);
            this.comboBoxAlmacen.Name = "comboBoxAlmacen";
            this.comboBoxAlmacen.Size = new System.Drawing.Size(182, 28);
            this.comboBoxAlmacen.TabIndex = 2;
            // 
            // comboBoxTienda
            // 
            this.comboBoxTienda.FormattingEnabled = true;
            this.comboBoxTienda.Location = new System.Drawing.Point(426, 34);
            this.comboBoxTienda.Name = "comboBoxTienda";
            this.comboBoxTienda.Size = new System.Drawing.Size(191, 28);
            this.comboBoxTienda.TabIndex = 5;
            // 
            // btnCalcularTransporte
            // 
            this.btnCalcularTransporte.Location = new System.Drawing.Point(524, 202);
            this.btnCalcularTransporte.Name = "btnCalcularTransporte";
            this.btnCalcularTransporte.Size = new System.Drawing.Size(93, 36);
            this.btnCalcularTransporte.TabIndex = 3;
            this.btnCalcularTransporte.Text = "Calcular T";
            this.btnCalcularTransporte.UseVisualStyleBackColor = true;
            this.btnCalcularTransporte.Click += new System.EventHandler(this.btnCalcularTransporte_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 20;
            this.listBoxResultado.Location = new System.Drawing.Point(24, 94);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(472, 144);
            this.listBoxResultado.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxAlmacen);
            this.groupBox1.Controls.Add(this.comboBoxTienda);
            this.groupBox1.Controls.Add(this.btnCalcularTransporte);
            this.groupBox1.Controls.Add(this.listBoxResultado);
            this.groupBox1.Location = new System.Drawing.Point(101, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 261);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costo de trasportar de los diferentes almacenes";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(108, 42);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(169, 28);
            this.comboBoxProductos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Productos";
            // 
            // Floyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Floyd";
            this.Text = "Floyd";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxCarrito;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnEliminarCarrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAlmacen;
        private System.Windows.Forms.ComboBox comboBoxTienda;
        private System.Windows.Forms.Button btnCalcularTransporte;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProductos;
    }
}