namespace ejercicio2
{
	partial class letras
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
			this.lstletras = new System.Windows.Forms.ListBox();
			this.btnmostrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstletras
			// 
			this.lstletras.FormattingEnabled = true;
			this.lstletras.Location = new System.Drawing.Point(31, 34);
			this.lstletras.Name = "lstletras";
			this.lstletras.Size = new System.Drawing.Size(120, 147);
			this.lstletras.TabIndex = 0;
			// 
			// btnmostrar
			// 
			this.btnmostrar.Location = new System.Drawing.Point(31, 198);
			this.btnmostrar.Name = "btnmostrar";
			this.btnmostrar.Size = new System.Drawing.Size(75, 23);
			this.btnmostrar.TabIndex = 1;
			this.btnmostrar.Text = "Mostrar";
			this.btnmostrar.UseVisualStyleBackColor = true;
			this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
			// 
			// letras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnmostrar);
			this.Controls.Add(this.lstletras);
			this.Name = "letras";
			this.Text = "letras";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstletras;
		private System.Windows.Forms.Button btnmostrar;
	}
}

