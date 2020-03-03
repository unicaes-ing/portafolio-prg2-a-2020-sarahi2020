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
    public partial class E4 : Form
    {
        public E4()
        {
            InitializeComponent();
        }
        private void cboLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLibros.SelectedItem.Equals("EL PRINCIPITO"))
            {
                txtPrecio.Text = "10.99";
            }
            else if (cboLibros.SelectedItem.Equals("UN DIA EN LA VIDA"))
            {
                txtPrecio.Text = "23.20";

            }
            else if (cboLibros.SelectedItem.Equals("LA CABAÑA DEL TIO TOM"))
            {
                txtPrecio.Text = "15.00";
            }
            else if (cboLibros.SelectedItem.Equals("ROTA SE CAMINA IGUAL"))
            {
                txtPrecio.Text = "30.50";
            }
            else if (cboLibros.SelectedItem.Equals("BUSCANDO A ALASKA"))
            {
                txtPrecio.Text = "13.50";
            }
            else
            {
                txtPrecio.Text = "35.99";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnueva_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtImpuesto.Clear();
            txtPrecio.Clear();
            txtSub.Clear();
            txtTotal.Clear();
            
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double sub, total, imp;
            if (cboLibros.SelectedItem.Equals("EL PRINCIPITO"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("LA CABAÑA DEL TIO TOM"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("ROTA SE CAMINA IGUAL"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("UN DIA EN LA VIDA"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
            else if (cboLibros.SelectedItem.Equals("BUSCANDO A ALASKA"))
            {

                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");

            }
            else if (cboLibros.SelectedItem.Equals("LAS HISTORIAS DE PULGARCITO"))
            {
                sub = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);
                imp = sub * 0.13;
                total = sub + imp;
                txtSub.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotal.Text = total.ToString("C2");
            }
        }
    }
}
