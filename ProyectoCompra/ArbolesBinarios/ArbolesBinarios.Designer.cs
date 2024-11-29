namespace ProyectoCompra.ArbolesBinarios
{
    partial class ArbolesBinarios
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRecorridoPosorden = new System.Windows.Forms.Button();
            this.btnRecorridoInorden = new System.Windows.Forms.Button();
            this.btnRecorridoPreorden = new System.Windows.Forms.Button();
            this.txtRecorridos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(463, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 20;
            this.lstNumeros.Location = new System.Drawing.Point(20, 139);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(484, 404);
            this.lstNumeros.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(251, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(189, 26);
            this.txtNumero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el número:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(598, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRecorridoPosorden
            // 
            this.btnRecorridoPosorden.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoPosorden.Location = new System.Drawing.Point(659, 83);
            this.btnRecorridoPosorden.Name = "btnRecorridoPosorden";
            this.btnRecorridoPosorden.Size = new System.Drawing.Size(217, 28);
            this.btnRecorridoPosorden.TabIndex = 5;
            this.btnRecorridoPosorden.Text = "Recorrido Preorden";
            this.btnRecorridoPosorden.UseVisualStyleBackColor = true;
            this.btnRecorridoPosorden.Click += new System.EventHandler(this.btnRecorridoPosorden_Click);
            // 
            // btnRecorridoInorden
            // 
            this.btnRecorridoInorden.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoInorden.Location = new System.Drawing.Point(345, 83);
            this.btnRecorridoInorden.Name = "btnRecorridoInorden";
            this.btnRecorridoInorden.Size = new System.Drawing.Size(217, 28);
            this.btnRecorridoInorden.TabIndex = 6;
            this.btnRecorridoInorden.Text = "Recorrido Inorden";
            this.btnRecorridoInorden.UseVisualStyleBackColor = true;
            this.btnRecorridoInorden.Click += new System.EventHandler(this.btnRecorridoInorden_Click);
            // 
            // btnRecorridoPreorden
            // 
            this.btnRecorridoPreorden.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorridoPreorden.Location = new System.Drawing.Point(28, 83);
            this.btnRecorridoPreorden.Name = "btnRecorridoPreorden";
            this.btnRecorridoPreorden.Size = new System.Drawing.Size(217, 28);
            this.btnRecorridoPreorden.TabIndex = 7;
            this.btnRecorridoPreorden.Text = "Recorrido Posorden";
            this.btnRecorridoPreorden.UseVisualStyleBackColor = true;
            this.btnRecorridoPreorden.Click += new System.EventHandler(this.btnRecorridoPreorden_Click);
            // 
            // txtRecorridos
            // 
            this.txtRecorridos.Location = new System.Drawing.Point(533, 139);
            this.txtRecorridos.Multiline = true;
            this.txtRecorridos.Name = "txtRecorridos";
            this.txtRecorridos.Size = new System.Drawing.Size(358, 297);
            this.txtRecorridos.TabIndex = 8;
            // 
            // ArbolesBinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.txtRecorridos);
            this.Controls.Add(this.btnRecorridoPreorden);
            this.Controls.Add(this.btnRecorridoInorden);
            this.Controls.Add(this.btnRecorridoPosorden);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnAgregar);
            this.Name = "ArbolesBinarios";
            this.Text = "ArbolesBinarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRecorridoPosorden;
        private System.Windows.Forms.Button btnRecorridoInorden;
        private System.Windows.Forms.Button btnRecorridoPreorden;
        private System.Windows.Forms.TextBox txtRecorridos;
    }
}