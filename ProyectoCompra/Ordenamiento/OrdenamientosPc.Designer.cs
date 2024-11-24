<<<<<<< HEAD
﻿namespace ProyectoCompra.BubleShort
{
    partial class OrdenamientosPc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPrecio = new System.Windows.Forms.RadioButton();
            this.rbCantidad = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.rbBubbleSort = new System.Windows.Forms.RadioButton();
            this.rbSelectionSort = new System.Windows.Forms.RadioButton();
            this.rbHeapSort = new System.Windows.Forms.RadioButton();
            this.rbShellSort = new System.Windows.Forms.RadioButton();
            this.rbShakeSort = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(326, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(177, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenamiento";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 17);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 329);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecioP);
            this.groupBox2.Controls.Add(this.txtCantidadP);
            this.groupBox2.Controls.Add(this.txtNombreP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(288, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra Productos";
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(13, 185);
            this.txtPrecioP.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioP.Multiline = true;
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(261, 36);
            this.txtPrecioP.TabIndex = 5;
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.Location = new System.Drawing.Point(13, 113);
            this.txtCantidadP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadP.Multiline = true;
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(261, 36);
            this.txtCantidadP.TabIndex = 4;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(13, 39);
            this.txtNombreP.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreP.Multiline = true;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(261, 36);
            this.txtNombreP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NombreProducto:";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(13, 25);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPrecio);
            this.groupBox3.Controls.Add(this.rbCantidad);
            this.groupBox3.Controls.Add(this.rbNombre);
            this.groupBox3.Location = new System.Drawing.Point(16, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(288, 55);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecciona el tipo de Ordenamiento";
            // 
            // rbPrecio
            // 
            this.rbPrecio.AutoSize = true;
            this.rbPrecio.Location = new System.Drawing.Point(189, 25);
            this.rbPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.rbPrecio.Name = "rbPrecio";
            this.rbPrecio.Size = new System.Drawing.Size(55, 17);
            this.rbPrecio.TabIndex = 4;
            this.rbPrecio.TabStop = true;
            this.rbPrecio.Text = "Precio";
            this.rbPrecio.UseVisualStyleBackColor = true;
            // 
            // rbCantidad
            // 
            this.rbCantidad.AutoSize = true;
            this.rbCantidad.Location = new System.Drawing.Point(101, 25);
            this.rbCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.rbCantidad.Name = "rbCantidad";
            this.rbCantidad.Size = new System.Drawing.Size(67, 17);
            this.rbCantidad.TabIndex = 3;
            this.rbCantidad.TabStop = true;
            this.rbCantidad.Text = "Cantidad";
            this.rbCantidad.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnOrdenar);
            this.groupBox4.Controls.Add(this.btnAgregarProducto);
            this.groupBox4.Location = new System.Drawing.Point(20, 300);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(284, 65);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(208, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 27);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(110, 16);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(88, 24);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(13, 16);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(81, 24);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbShellSort);
            this.groupBox5.Controls.Add(this.rbSelectionSort);
            this.groupBox5.Controls.Add(this.rbShakeSort);
            this.groupBox5.Controls.Add(this.rbQuickSort);
            this.groupBox5.Controls.Add(this.rbHeapSort);
            this.groupBox5.Controls.Add(this.rbBubbleSort);
            this.groupBox5.Location = new System.Drawing.Point(515, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(215, 336);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seleccione el Tipo de Ordenamiento";
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(127, 48);
            this.rbQuickSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(72, 17);
            this.rbQuickSort.TabIndex = 7;
            this.rbQuickSort.TabStop = true;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // rbBubbleSort
            // 
            this.rbBubbleSort.AutoSize = true;
            this.rbBubbleSort.Location = new System.Drawing.Point(13, 48);
            this.rbBubbleSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbBubbleSort.Name = "rbBubbleSort";
            this.rbBubbleSort.Size = new System.Drawing.Size(77, 17);
            this.rbBubbleSort.TabIndex = 6;
            this.rbBubbleSort.TabStop = true;
            this.rbBubbleSort.Text = "BubbleSort";
            this.rbBubbleSort.UseVisualStyleBackColor = true;
            // 
            // rbSelectionSort
            // 
            this.rbSelectionSort.AutoSize = true;
            this.rbSelectionSort.Location = new System.Drawing.Point(127, 180);
            this.rbSelectionSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbSelectionSort.Name = "rbSelectionSort";
            this.rbSelectionSort.Size = new System.Drawing.Size(88, 17);
            this.rbSelectionSort.TabIndex = 7;
            this.rbSelectionSort.TabStop = true;
            this.rbSelectionSort.Text = "SelectionSort";
            this.rbSelectionSort.UseVisualStyleBackColor = true;
            // 
            // rbHeapSort
            // 
            this.rbHeapSort.AutoSize = true;
            this.rbHeapSort.Location = new System.Drawing.Point(4, 180);
            this.rbHeapSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbHeapSort.Name = "rbHeapSort";
            this.rbHeapSort.Size = new System.Drawing.Size(70, 17);
            this.rbHeapSort.TabIndex = 6;
            this.rbHeapSort.TabStop = true;
            this.rbHeapSort.Text = "HeapSort";
            this.rbHeapSort.UseVisualStyleBackColor = true;
            // 
            // rbShellSort
            // 
            this.rbShellSort.AutoSize = true;
            this.rbShellSort.Location = new System.Drawing.Point(140, 298);
            this.rbShellSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbShellSort.Name = "rbShellSort";
            this.rbShellSort.Size = new System.Drawing.Size(67, 17);
            this.rbShellSort.TabIndex = 7;
            this.rbShellSort.TabStop = true;
            this.rbShellSort.Text = "ShellSort";
            this.rbShellSort.UseVisualStyleBackColor = true;
            // 
            // rbShakeSort
            // 
            this.rbShakeSort.AutoSize = true;
            this.rbShakeSort.Location = new System.Drawing.Point(13, 298);
            this.rbShakeSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbShakeSort.Name = "rbShakeSort";
            this.rbShakeSort.Size = new System.Drawing.Size(75, 17);
            this.rbShakeSort.TabIndex = 6;
            this.rbShakeSort.TabStop = true;
            this.rbShakeSort.Text = "ShakeSort";
            this.rbShakeSort.UseVisualStyleBackColor = true;
            // 
            // OrdenamientosPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 372);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdenamientosPc";
            this.Text = "Ordenamientos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPrecio;
        private System.Windows.Forms.RadioButton rbCantidad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbBubbleSort;
        private System.Windows.Forms.RadioButton rbSelectionSort;
        private System.Windows.Forms.RadioButton rbHeapSort;
        private System.Windows.Forms.RadioButton rbShellSort;
        private System.Windows.Forms.RadioButton rbShakeSort;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
=======
﻿namespace ProyectoCompra.BubleShort
{
    partial class OrdenamientosPc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPrecio = new System.Windows.Forms.RadioButton();
            this.rbCantidad = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.rbBubbleSort = new System.Windows.Forms.RadioButton();
            this.rbSelectionSort = new System.Windows.Forms.RadioButton();
            this.rbHeapSort = new System.Windows.Forms.RadioButton();
            this.rbShellSort = new System.Windows.Forms.RadioButton();
            this.rbShakeSort = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(326, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(177, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenamiento";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 17);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 329);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecioP);
            this.groupBox2.Controls.Add(this.txtCantidadP);
            this.groupBox2.Controls.Add(this.txtNombreP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(288, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra Productos";
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(13, 185);
            this.txtPrecioP.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioP.Multiline = true;
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(261, 36);
            this.txtPrecioP.TabIndex = 5;
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.Location = new System.Drawing.Point(13, 113);
            this.txtCantidadP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadP.Multiline = true;
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(261, 36);
            this.txtCantidadP.TabIndex = 4;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(13, 39);
            this.txtNombreP.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreP.Multiline = true;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(261, 36);
            this.txtNombreP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NombreProducto:";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(13, 25);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbPrecio);
            this.groupBox3.Controls.Add(this.rbCantidad);
            this.groupBox3.Controls.Add(this.rbNombre);
            this.groupBox3.Location = new System.Drawing.Point(16, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(288, 55);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecciona el tipo de Ordenamiento";
            // 
            // rbPrecio
            // 
            this.rbPrecio.AutoSize = true;
            this.rbPrecio.Location = new System.Drawing.Point(189, 25);
            this.rbPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.rbPrecio.Name = "rbPrecio";
            this.rbPrecio.Size = new System.Drawing.Size(55, 17);
            this.rbPrecio.TabIndex = 4;
            this.rbPrecio.TabStop = true;
            this.rbPrecio.Text = "Precio";
            this.rbPrecio.UseVisualStyleBackColor = true;
            // 
            // rbCantidad
            // 
            this.rbCantidad.AutoSize = true;
            this.rbCantidad.Location = new System.Drawing.Point(101, 25);
            this.rbCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.rbCantidad.Name = "rbCantidad";
            this.rbCantidad.Size = new System.Drawing.Size(67, 17);
            this.rbCantidad.TabIndex = 3;
            this.rbCantidad.TabStop = true;
            this.rbCantidad.Text = "Cantidad";
            this.rbCantidad.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnOrdenar);
            this.groupBox4.Controls.Add(this.btnAgregarProducto);
            this.groupBox4.Location = new System.Drawing.Point(20, 300);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(284, 65);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(208, 16);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 27);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(110, 16);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(88, 24);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(13, 16);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(81, 24);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbShellSort);
            this.groupBox5.Controls.Add(this.rbSelectionSort);
            this.groupBox5.Controls.Add(this.rbShakeSort);
            this.groupBox5.Controls.Add(this.rbQuickSort);
            this.groupBox5.Controls.Add(this.rbHeapSort);
            this.groupBox5.Controls.Add(this.rbBubbleSort);
            this.groupBox5.Location = new System.Drawing.Point(515, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(215, 336);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seleccione el Tipo de Ordenamiento";
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(127, 48);
            this.rbQuickSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(72, 17);
            this.rbQuickSort.TabIndex = 7;
            this.rbQuickSort.TabStop = true;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // rbBubbleSort
            // 
            this.rbBubbleSort.AutoSize = true;
            this.rbBubbleSort.Location = new System.Drawing.Point(13, 48);
            this.rbBubbleSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbBubbleSort.Name = "rbBubbleSort";
            this.rbBubbleSort.Size = new System.Drawing.Size(77, 17);
            this.rbBubbleSort.TabIndex = 6;
            this.rbBubbleSort.TabStop = true;
            this.rbBubbleSort.Text = "BubbleSort";
            this.rbBubbleSort.UseVisualStyleBackColor = true;
            // 
            // rbSelectionSort
            // 
            this.rbSelectionSort.AutoSize = true;
            this.rbSelectionSort.Location = new System.Drawing.Point(127, 180);
            this.rbSelectionSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbSelectionSort.Name = "rbSelectionSort";
            this.rbSelectionSort.Size = new System.Drawing.Size(88, 17);
            this.rbSelectionSort.TabIndex = 7;
            this.rbSelectionSort.TabStop = true;
            this.rbSelectionSort.Text = "SelectionSort";
            this.rbSelectionSort.UseVisualStyleBackColor = true;
            // 
            // rbHeapSort
            // 
            this.rbHeapSort.AutoSize = true;
            this.rbHeapSort.Location = new System.Drawing.Point(4, 180);
            this.rbHeapSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbHeapSort.Name = "rbHeapSort";
            this.rbHeapSort.Size = new System.Drawing.Size(70, 17);
            this.rbHeapSort.TabIndex = 6;
            this.rbHeapSort.TabStop = true;
            this.rbHeapSort.Text = "HeapSort";
            this.rbHeapSort.UseVisualStyleBackColor = true;
            // 
            // rbShellSort
            // 
            this.rbShellSort.AutoSize = true;
            this.rbShellSort.Location = new System.Drawing.Point(140, 298);
            this.rbShellSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbShellSort.Name = "rbShellSort";
            this.rbShellSort.Size = new System.Drawing.Size(67, 17);
            this.rbShellSort.TabIndex = 7;
            this.rbShellSort.TabStop = true;
            this.rbShellSort.Text = "ShellSort";
            this.rbShellSort.UseVisualStyleBackColor = true;
            // 
            // rbShakeSort
            // 
            this.rbShakeSort.AutoSize = true;
            this.rbShakeSort.Location = new System.Drawing.Point(13, 298);
            this.rbShakeSort.Margin = new System.Windows.Forms.Padding(2);
            this.rbShakeSort.Name = "rbShakeSort";
            this.rbShakeSort.Size = new System.Drawing.Size(75, 17);
            this.rbShakeSort.TabIndex = 6;
            this.rbShakeSort.TabStop = true;
            this.rbShakeSort.Text = "ShakeSort";
            this.rbShakeSort.UseVisualStyleBackColor = true;
            // 
            // OrdenamientosPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 372);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdenamientosPc";
            this.Text = "Ordenamientos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPrecio;
        private System.Windows.Forms.RadioButton rbCantidad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbBubbleSort;
        private System.Windows.Forms.RadioButton rbSelectionSort;
        private System.Windows.Forms.RadioButton rbHeapSort;
        private System.Windows.Forms.RadioButton rbShellSort;
        private System.Windows.Forms.RadioButton rbShakeSort;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
>>>>>>> 24435b81521438c5429d4046db0dcb9d216746c6
}