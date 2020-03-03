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
    public partial class EJERC5 : Form
    {
        public EJERC5()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtNombre.Text);
            int hora = Convert.ToInt32(txtHorastrabajadas.Text);
            double valor = Convert.ToDouble(txtValor.Text);
            double sub, total, iva;
            sub = hora * valor;
            iva = sub * 0.13;
            total = sub + iva;
            dataGridView1.Rows.Add(nombre, hora, valor, sub, iva, total);

            dataGridView1.ClearSelection();
                 
            int tot = 0;
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                total += Convert.ToInt32(dataGridView1.Rows[f].Cells[3].Value);
              lblplanilla.Text = string.Format("{0:C2}", tot);
            }

        }

        private void btnLimiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtValor.Clear();
            txtHorastrabajadas.Clear();
            txtNombre.Focus();
        }
    }
    }

