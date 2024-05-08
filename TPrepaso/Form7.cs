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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkASP.Checked = false;
            chkBD.Checked = false;
            chkJava.Checked = false;
            chkOracle.Checked = false;
            chkPHP.Checked = false;
            chkV8.Checked = false;
            rdbDie.Checked = false;
            rdbSei.Checked = false;
            rdbUno.Checked = false;
            txtEdad.Text = "";
            txtSueldo.Text = "";
            cmbGenero.SelectedIndex = 0;
            cmbNacionalidad.SelectedIndex = 0;
            txtTotal.Text = "";
        }

        private void cmbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double horas = 0;
            double Sueldazo = Convert.ToDouble(txtSueldo.Text);
            // Variables de sueldo especificas
            if (cmbGenero.SelectedIndex == 2)
            {
                Sueldazo += Sueldazo * 0.03;
            }
            if (Convert.ToDouble(txtEdad.Text) >= 45)
            {
                Sueldazo += Sueldazo * 0.02;
            }
            if (cmbNacionalidad.SelectedIndex == 1)
            {
                Sueldazo -= Sueldazo * 0.05;
            }
            // Antiguedad
            if (rdbUno.Checked == true)
            {
                Sueldazo += Sueldazo * 0.05;
            }
            else if (rdbSei.Checked)
            {
                Sueldazo += Sueldazo * 0.1;
            }
            else if (rdbDie.Checked == true)
            {
                Sueldazo += Sueldazo * 0.15;
            }
            // Cursos
            if (chkPHP.Checked == true)
            {
                horas += 20;
            }
            if (chkJava.Checked == true)
            {
                horas += 35;
            }
            if (chkASP.Checked == true)
            {
                horas += 40;
            }
            if (chkOracle.Checked == true)
            {
                horas += 60;
            }
            if (chkV8.Checked == true)
            {
                horas += 55;
            }
            if (chkBD.Checked == true)
            {
                horas += 15;
            }
            horas = horas * 3;
            txtTotal.Text = Convert.ToString(Sueldazo + horas);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cmbGenero.SelectedIndex = 0;
            cmbNacionalidad.SelectedIndex = 0;
        }
    }
}
