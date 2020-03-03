namespace ejercicio2
{
    partial class E4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnueva = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo del libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subtotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Impuesto (13%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total a pagar";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(113, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(113, 79);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(113, 136);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(100, 20);
            this.txtSub.TabIndex = 9;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(113, 178);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtImpuesto.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(113, 213);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(194, 260);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnueva
            // 
            this.btnnueva.Location = new System.Drawing.Point(113, 260);
            this.btnnueva.Name = "btnnueva";
            this.btnnueva.Size = new System.Drawing.Size(75, 23);
            this.btnnueva.TabIndex = 13;
            this.btnnueva.Text = "Nueva";
            this.btnnueva.UseVisualStyleBackColor = true;
            this.btnnueva.Click += new System.EventHandler(this.btnnueva_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(27, 260);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 14;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // cboLibros
            // 
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Items.AddRange(new object[] {
            "EL PRINCIPITO",
            "LA CABAÑA DEL TIO TOM",
            "ROTA SE CAMINA IGUAL",
            "UN DIA EN LA VIDA ",
            "BUSCANDO A ALASKA",
            "LAS HISTORIAS DE PULGALCITO"});
            this.cboLibros.Location = new System.Drawing.Point(113, 13);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(121, 21);
            this.cboLibros.TabIndex = 15;
            // 
            // E4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboLibros);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnnueva);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "E4";
            this.Text = "EJERC4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnueva;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cboLibros;
    }
}