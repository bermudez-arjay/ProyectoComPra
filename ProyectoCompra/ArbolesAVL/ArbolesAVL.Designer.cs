namespace ProyectoCompra.ArbolesAVL
{
    partial class ArbolesAVL
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
            this.txtRecorridos = new System.Windows.Forms.TextBox();
            this.btnRecorridoPosorden = new System.Windows.Forms.Button();
            this.btnRecorridoInorden = new System.Windows.Forms.Button();
            this.btnRecorridoPreorden = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecorridos
            // 
            this.txtRecorridos.Location = new System.Drawing.Point(525, 138);
            this.txtRecorridos.Multiline = true;
            this.txtRecorridos.Name = "txtRecorridos";
            this.txtRecorridos.Size = new System.Drawing.Size(358, 297);
            this.txtRecorridos.TabIndex = 17;
            // 
            // btnRecorridoPosorden
            // 
            this.btnRecorridoPosorden.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoPosorden.Location = new System.Drawing.Point(37, 82);
            this.btnRecorridoPosorden.Name = "btnRecorridoPosorden";
            this.btnRecorridoPosorden.Size = new System.Drawing.Size(217, 28);
            this.btnRecorridoPosorden.TabIndex = 16;
            this.btnRecorridoPosorden.Text = "Recorrido Posorden";
            this.btnRecorridoPosorden.UseVisualStyleBackColor = true;
            this.btnRecorridoPosorden.Click += new System.EventHandler(this.btnRecorridoPosorden_Click);
            // 
            // btnRecorridoInorden
            // 
            this.btnRecorridoInorden.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoInorden.Location = new System.Drawing.Point(337, 82);
            this.btnRecorridoInorden.Name = "btnRecorridoInorden";
            this.btnRecorridoInorden.Size = new System.Drawing.Size(217, 28);
            this.btnRecorridoInorden.TabIndex = 15;
            this.btnRecorridoInorden.Text = "Recorrido Inorden";
            this.btnRecorridoInorden.UseVisualStyleBackColor = true;
            this.btnRecorridoInorden.Click += new System.EventHandler(this.btnRecorridoInorden_Click);
            // 
            // btnRecorridoPreorden
            // 
            this.btnRecorridoPreorden.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoPreorden.Location = new System.Drawing.Point(642, 82);
            this.btnRecorridoPreorden.Name = "btnRecorridoPreorden";
            this.btnRecorridoPreorden.Size = new System.Drawing.Size(217, 28);
            this.btnRecorridoPreorden.TabIndex = 14;
            this.btnRecorridoPreorden.Text = "Recorrido Preorden";
            this.btnRecorridoPreorden.UseVisualStyleBackColor = true;
            this.btnRecorridoPreorden.Click += new System.EventHandler(this.btnRecorridoPreorden_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(590, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 34);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese el número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(243, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(189, 26);
            this.txtNumero.TabIndex = 11;
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 20;
            this.lstNumeros.Location = new System.Drawing.Point(12, 138);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(484, 404);
            this.lstNumeros.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(455, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 34);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ArbolesAVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 558);
            this.Controls.Add(this.txtRecorridos);
            this.Controls.Add(this.btnRecorridoPosorden);
            this.Controls.Add(this.btnRecorridoInorden);
            this.Controls.Add(this.btnRecorridoPreorden);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnAgregar);
            this.Name = "ArbolesAVL";
            this.Text = "ArbolesAVL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecorridos;
        private System.Windows.Forms.Button btnRecorridoPosorden;
        private System.Windows.Forms.Button btnRecorridoInorden;
        private System.Windows.Forms.Button btnRecorridoPreorden;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnAgregar;
    }
}