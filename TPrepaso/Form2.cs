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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeca.Text = "";
            txtGramos.Text = "";
            txtInput.Text = "";
            txtLibras.Text = "";
            txtMili.Text = "";
            txtOz.Text = "";
            txtTon.Text = "";
            txtTonMet.Text = "";
            txtInput.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            txtLibras.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 2.20462);
            txtMili.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 1000000);
            txtGramos.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 1000);
            txtTon.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 0.001);
            txtDeca.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 100);
            txtTonMet.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 0.98);
            txtOz.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 35.2740);
        }
    }
}
