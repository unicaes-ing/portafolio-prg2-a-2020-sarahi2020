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
    public partial class E2 : Form
    {
        public E2()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtbinario.Text = Convert.ToString(Convert.ToInt32(txtdecimal.Text), 2);
            txtoctal.Text = Convert.ToString(Convert.ToInt32(txtdecimal.Text), 8);
            txthexa.Text = Convert.ToString(Convert.ToInt32(txtdecimal.Text), 16);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbinario.Clear();
            txtdecimal.Clear();
            txthexa.Clear();
            txtoctal.Clear();
            txtdecimal.Focus();
        }
    }
}
