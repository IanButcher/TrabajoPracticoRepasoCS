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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void rdbDivorciado_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbBuscado.Checked = false;
            rdbCasado.Checked = false;
            rdbDivorciado.Checked = false;
            rdbSoltero.Checked = false;
            rdbVuido.Checked = false;
            txtLOLO.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdbBuscado.Checked == true)
            {
                txtLOLO.Text = "";
                txtLOLO.Text += rdbBuscado.Text + " ";
            }
            else if (rdbCasado.Checked == true)
            {
                txtLOLO.Text = "";
                txtLOLO.Text += rdbCasado.Text + " ";
            }
            else if (rdbDivorciado.Checked == true)
            {
                txtLOLO.Text = "";
                txtLOLO.Text += rdbDivorciado.Text + " ";
            }
            else if (rdbSoltero.Checked == true)
            {
                txtLOLO.Text = "";
                txtLOLO.Text += rdbSoltero.Text + " ";
            }
            else if (rdbVuido.Checked == true)
            {
                txtLOLO.Text = "";
                txtLOLO.Text += rdbVuido.Text + " ";
            }
        }
    }
}
