namespace practica3_sarahi
{
    partial class EJERCC2
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo20 = new System.Windows.Forms.RadioButton();
            this.rdo15 = new System.Windows.Forms.RadioButton();
            this.rdo10 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo0 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(67, 24);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 4;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(54, 58);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 5;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(87, 141);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(87, 187);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(32, 96);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(32, 224);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(235, 259);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo20);
            this.groupBox1.Controls.Add(this.rdo15);
            this.groupBox1.Controls.Add(this.rdo10);
            this.groupBox1.Controls.Add(this.rdo5);
            this.groupBox1.Controls.Add(this.rdo0);
            this.groupBox1.Location = new System.Drawing.Point(210, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuento";
            // 
            // rdo20
            // 
            this.rdo20.AutoSize = true;
            this.rdo20.Location = new System.Drawing.Point(11, 136);
            this.rdo20.Name = "rdo20";
            this.rdo20.Size = new System.Drawing.Size(45, 17);
            this.rdo20.TabIndex = 4;
            this.rdo20.TabStop = true;
            this.rdo20.Text = "20%";
            this.rdo20.UseVisualStyleBackColor = true;
            this.rdo20.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rdo15
            // 
            this.rdo15.AutoSize = true;
            this.rdo15.Location = new System.Drawing.Point(11, 102);
            this.rdo15.Name = "rdo15";
            this.rdo15.Size = new System.Drawing.Size(45, 17);
            this.rdo15.TabIndex = 3;
            this.rdo15.TabStop = true;
            this.rdo15.Text = "15%";
            this.rdo15.UseVisualStyleBackColor = true;
            this.rdo15.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdo10
            // 
            this.rdo10.AutoSize = true;
            this.rdo10.Location = new System.Drawing.Point(11, 70);
            this.rdo10.Name = "rdo10";
            this.rdo10.Size = new System.Drawing.Size(45, 17);
            this.rdo10.TabIndex = 2;
            this.rdo10.TabStop = true;
            this.rdo10.Text = "10%";
            this.rdo10.UseVisualStyleBackColor = true;
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(11, 42);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(39, 17);
            this.rdo5.TabIndex = 1;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "5%";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // rdo0
            // 
            this.rdo0.AutoSize = true;
            this.rdo0.Location = new System.Drawing.Point(11, 16);
            this.rdo0.Name = "rdo0";
            this.rdo0.Size = new System.Drawing.Size(39, 17);
            this.rdo0.TabIndex = 0;
            this.rdo0.TabStop = true;
            this.rdo0.Text = "0%";
            this.rdo0.UseVisualStyleBackColor = true;
            // 
            // EJERCC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EJERCC2";
            this.Text = "EJERC2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo20;
        private System.Windows.Forms.RadioButton rdo15;
        private System.Windows.Forms.RadioButton rdo10;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo0;
    }
}