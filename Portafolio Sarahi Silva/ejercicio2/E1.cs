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
    public partial class E1 : Form
    {
        public E1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtexamen1.Clear();
            txtexamen2.Clear();
            txtexamen3.Clear();
            txtprom.Clear();
            txtexamen1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double e1, e2, e3;
            e1 = Convert.ToDouble(txtexamen1.Text);
            e2 = Convert.ToDouble(txtexamen2.Text);
            e3 = Convert.ToDouble(txtexamen3.Text);
            txtprom.Text = (e1 + e2 + e3 / 3).ToString("N2");
        }
    }
}
