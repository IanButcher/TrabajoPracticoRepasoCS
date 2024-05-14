using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tprepaso
{
    public partial class Form8ActividadExtra : Form
    {
        public Form8ActividadExtra()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtInput.Text) % 2 == 0)
            {
                lsbPar.Items.Add(txtInput.Text);
            }
            else if(Convert.ToDouble(txtInput.Text) % 2 != 0)
            {
                lsbImpar.Items.Add(txtInput.Text);
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbImpar.Items.Clear();
            lsbPar.Items.Clear();
            txtInput.Text = "";
        }
    }
}
