using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tprepaso
{
    public partial class Form8ActividadUnivsitaria : Form
    {
        public Form8ActividadUnivsitaria()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblresta.Text = "Total";
            lblSuma.Text = "Total";
            lsbNumeros.Items.Clear();
            txtInput.Text = "";
        }

        private void Form8ActividadUnivsitaria_Load(object sender, EventArgs e)
        {
            lblresta.Visible = false;
            lblSuma.Visible = false;
            chkResta.Text = "Producto";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkSuma_CheckedChanged(object sender, EventArgs e)
        {
            lblSuma.Visible = chkSuma.Checked;
        }

        private void chkResta_CheckedChanged(object sender, EventArgs e)
        {
            lblresta.Visible = chkResta.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsbNumeros.Items.Add(txtInput.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            double producto = 1;
            if (lsbNumeros.Items.Count >= 10)
            {
                foreach (var i in lsbNumeros.Items)
                {
                    resultado += Convert.ToDouble(i);
                    producto = producto * Convert.ToDouble(i);
                }
                lblresta.Text = Convert.ToString(producto);
                lblSuma.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Deben haber 10 items");
            }
        }
    }
}
