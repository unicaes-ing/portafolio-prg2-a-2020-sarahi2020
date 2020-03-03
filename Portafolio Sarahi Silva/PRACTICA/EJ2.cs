using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA
{
    public partial class EJ2 : Form
    {
        public EJ2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EJ2_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                int numero = Convert.ToInt32(txtnum.Text);
                lstNumeros.Items.Add(numero);
                txtnum.Clear();
                txtBuscar.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
                txtnum.SelectAll();
                txtnum.Focus();
            }
        }
        public static int buscar(int numBuscar, ListBox lista)
        {
            int cont = 0;

            foreach (int n in lista.Items)
            {
                if (n == numBuscar) cont++;

            }
            return cont;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtBuscar.Text);
                int cant = buscar(num, lstNumeros);
                MessageBox.Show(" Se encuentra " + cant + " veces ");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
                txtBuscar.SelectAll();
                txtBuscar.Focus();
            }
        }
    }
}
