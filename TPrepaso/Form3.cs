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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void chkLeer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLOLO.Text = "";
            chkBailar.Checked = false;
            chkComer.Checked = false;
            chkLeer.Checked = false;
            chkVer.Checked = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (chkLeer.Checked == true)
            {
                txtLOLO.Text += chkLeer.Text + " ";
            }
            if (chkBailar.Checked == true)
            {
                txtLOLO.Text += chkBailar.Text + " ";
            }
            if (chkComer.Checked == true)
            {
                txtLOLO.Text += chkComer.Text + " ";
            }
            if (chkVer.Checked == true)
            {
                txtLOLO.Text += chkVer.Text + " ";
            }
        }
    }
}
