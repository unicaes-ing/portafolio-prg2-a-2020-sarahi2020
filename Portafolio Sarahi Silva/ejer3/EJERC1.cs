﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3_sarahi
{
	public partial class numeros : Form
	{
		public numeros()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnmostrar_Click(object sender, EventArgs e)
		{
			int nt;
			if (int.TryParse(txtnumero.Text, out nt))
			{
				lstnumeros.Items.Clear();
				for (int i = 1; i <= 10; i++)
				{
					lstnumeros.Items.Add(nt + "*" + i + "=" + nt * i);
				}
			}
			else
			{
				MessageBox.Show("ingrese un numero");
			}
			}
		}
	}

