namespace ejer3
{
	partial class EJERC3
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
			this.lstlanzamientos = new System.Windows.Forms.ListBox();
			this.btnlanzar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstlanzamientos
			// 
			this.lstlanzamientos.FormattingEnabled = true;
			this.lstlanzamientos.Location = new System.Drawing.Point(23, 21);
			this.lstlanzamientos.Name = "lstlanzamientos";
			this.lstlanzamientos.Size = new System.Drawing.Size(131, 186);
			this.lstlanzamientos.TabIndex = 0;
			// 
			// btnlanzar
			// 
			this.btnlanzar.Location = new System.Drawing.Point(79, 220);
			this.btnlanzar.Name = "btnlanzar";
			this.btnlanzar.Size = new System.Drawing.Size(75, 23);
			this.btnlanzar.TabIndex = 1;
			this.btnlanzar.Text = "lanzar";
			this.btnlanzar.UseVisualStyleBackColor = true;
			this.btnlanzar.Click += new System.EventHandler(this.btnlanzar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnlanzar);
			this.Controls.Add(this.lstlanzamientos);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstlanzamientos;
		private System.Windows.Forms.Button btnlanzar;
	}
}

