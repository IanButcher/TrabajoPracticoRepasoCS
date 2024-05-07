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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbCinco.Checked = false;
            rdbCuatro.Checked = false;
            rdbSeis.Checked = false;
            rdbTres.Checked = false;
            txtCantidad.Text = "";
            txtTotal.Text = "";
            cmbColores.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double multiplicador = 0;
            if (cmbColores.SelectedIndex == 1)
            {
                multiplicador = 5.50;
            }
            else if (cmbColores.SelectedIndex == 2)
            {
                multiplicador = 4;
            }
            else
            {
                MessageBox.Show("Opcion invalida");
            }
            // Tamaño
            if (rdbTres.Checked == true)
            {
                multiplicador += 0;
            }
            else if(rdbCuatro.Checked == true && cmbColores.SelectedIndex == 2)
            {
                multiplicador += 1;
            }
            else if (rdbCuatro.Checked == true && cmbColores.SelectedIndex == 1)
            {
                multiplicador += 0.7;
            }
            else if (rdbCinco.Checked == true)
            {
                multiplicador += 2;
            }
            else if (rdbSeis.Checked == true && cmbColores.SelectedIndex == 1)
            {
                multiplicador += 3.5;
            }
            else if(rdbSeis.Checked && cmbColores.SelectedIndex == 2)
            {
                multiplicador += 3.9;
            }
            else
            {
                MessageBox.Show("Opcion invalida");
            }
            txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCantidad.Text) * multiplicador);
        }
    }
}
