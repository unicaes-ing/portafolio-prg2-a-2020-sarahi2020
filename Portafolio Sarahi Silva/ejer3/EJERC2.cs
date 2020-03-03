using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
	public partial class letras : Form
	{
		public letras()
		{
			InitializeComponent();
		}

		private void btnmostrar_Click(object sender, EventArgs e)
		{
			lstletras.ForeColor = Color.Red;
			lstletras.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Bold);
			lstletras.Items.Clear();
			for (char letra = 'A'; letra <= 'Z'; letra++)
				{
				lstletras.Items.Add(letra);
			}
			lstletras.Items.Insert(14, 'Ñ');
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
