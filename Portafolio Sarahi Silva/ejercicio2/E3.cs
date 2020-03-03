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
    public partial class E3 : Form
    {
        public E3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txti1.Clear();
            txti2.Clear();
            txti3.Clear();
            txtp1.Clear();
            txtp2.Clear();
            txtp3.Clear();
            txttotal.Clear();
            txti1.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double total;
            total = Convert.ToDouble(txti1.Text) + Convert.ToDouble(txti2.Text) + Convert.ToDouble(txti3.Text);
            txtp1.Text = Convert.ToString(((Convert.ToDouble(txti1.Text) / total) * 100).ToString("N2") + "%");
            txtp2.Text = Convert.ToString(((Convert.ToDouble(txti2.Text) / total) * 100).ToString("N2") + "%");
            txtp3.Text = Convert.ToString(((Convert.ToDouble(txti3.Text) / total) * 100).ToString("N2") + "%");
            txttotal.Text = Convert.ToString("C2");
        }
    }
}
