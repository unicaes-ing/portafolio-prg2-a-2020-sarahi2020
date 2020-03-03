namespace practica3_sarahi
{
    partial class EJERCC1
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblromano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(68, 14);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(174, 12);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(75, 23);
            this.btnconvertir.TabIndex = 2;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(126, 84);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblromano
            // 
            this.lblromano.AutoSize = true;
            this.lblromano.Location = new System.Drawing.Point(20, 138);
            this.lblromano.Name = "lblromano";
            this.lblromano.Size = new System.Drawing.Size(35, 13);
            this.lblromano.TabIndex = 4;
            this.lblromano.Text = "label2";
            // 
            // EJERC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 191);
            this.Controls.Add(this.lblromano);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "EJERC1";
            this.Text = "EJERC1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblromano;
    }
}