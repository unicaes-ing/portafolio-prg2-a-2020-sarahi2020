namespace ejercicio2
{
    partial class E1
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
            this.txtexamen1 = new System.Windows.Forms.TextBox();
            this.txtexamen2 = new System.Windows.Forms.TextBox();
            this.txtexamen3 = new System.Windows.Forms.TextBox();
            this.txtprom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Examen 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Examen 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Examen 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Promedio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtexamen1
            // 
            this.txtexamen1.Location = new System.Drawing.Point(114, 8);
            this.txtexamen1.Name = "txtexamen1";
            this.txtexamen1.Size = new System.Drawing.Size(100, 20);
            this.txtexamen1.TabIndex = 4;
            // 
            // txtexamen2
            // 
            this.txtexamen2.Location = new System.Drawing.Point(114, 40);
            this.txtexamen2.Name = "txtexamen2";
            this.txtexamen2.Size = new System.Drawing.Size(100, 20);
            this.txtexamen2.TabIndex = 5;
            // 
            // txtexamen3
            // 
            this.txtexamen3.Location = new System.Drawing.Point(114, 75);
            this.txtexamen3.Name = "txtexamen3";
            this.txtexamen3.Size = new System.Drawing.Size(100, 20);
            this.txtexamen3.TabIndex = 6;
            // 
            // txtprom
            // 
            this.txtprom.Location = new System.Drawing.Point(114, 124);
            this.txtprom.Name = "txtprom";
            this.txtprom.Size = new System.Drawing.Size(100, 20);
            this.txtprom.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // E1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 228);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprom);
            this.Controls.Add(this.txtexamen3);
            this.Controls.Add(this.txtexamen2);
            this.Controls.Add(this.txtexamen1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "E1";
            this.Text = "EJERC1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtexamen1;
        private System.Windows.Forms.TextBox txtexamen2;
        private System.Windows.Forms.TextBox txtexamen3;
        private System.Windows.Forms.TextBox txtprom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}