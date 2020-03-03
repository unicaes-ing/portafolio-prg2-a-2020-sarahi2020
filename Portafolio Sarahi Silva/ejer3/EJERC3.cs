using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer3
{
	public partial class EJERC3 : Form
	{
		public EJERC3()
		{
			InitializeComponent();
		}

		private void btnlanzar_Click(object sender, EventArgs e)
		{
			int c = 0;
			Random r = new Random();
			lstlanzamientos.Items.Clear();
			for (int i = 1; i <= 5000; i++)
			{
				int numero = r.Next(1, 7);
				if (numero == 6) c++;
				lstlanzamientos.Items.Add(numero);
			}
			MessageBox.Show(" se obtuvo" + c + "veces el 6");
		}

	}
}
