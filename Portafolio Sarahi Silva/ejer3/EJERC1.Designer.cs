namespace practica3_sarahi
{
	partial class numeros
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
			this.btnmostrar = new System.Windows.Forms.Button();
			this.lstnumeros = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtnumero = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnmostrar
			// 
			this.btnmostrar.Location = new System.Drawing.Point(168, 24);
			this.btnmostrar.Name = "btnmostrar";
			this.btnmostrar.Size = new System.Drawing.Size(75, 23);
			this.btnmostrar.TabIndex = 0;
			this.btnmostrar.Text = "MOSTRAR";
			this.btnmostrar.UseVisualStyleBackColor = true;
			this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
			// 
			// lstnumeros
			// 
			this.lstnumeros.FormattingEnabled = true;
			this.lstnumeros.Location = new System.Drawing.Point(40, 67);
			this.lstnumeros.Name = "lstnumeros";
			this.lstnumeros.Size = new System.Drawing.Size(120, 95);
			this.lstnumeros.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "NUMERO DE TABLA";
			// 
			// txtnumero
			// 
			this.txtnumero.Location = new System.Drawing.Point(40, 41);
			this.txtnumero.Name = "txtnumero";
			this.txtnumero.Size = new System.Drawing.Size(100, 20);
			this.txtnumero.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.txtnumero);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstnumeros);
			this.Controls.Add(this.btnmostrar);
			this.Name = "Form1";
			this.Text = "Numeros";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnmostrar;
		private System.Windows.Forms.ListBox lstnumeros;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnumero;
	}
}

