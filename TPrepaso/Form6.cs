using Microsoft.VisualBasic;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            rdbCien.Enabled = false;
            rdbCincuenta.Enabled = false;
            rdbDocientos.Enabled = false;
            rdbTreinta.Enabled = false;
            rdbTrescientos.Enabled = false;
            cmbCelu.Enabled = false;
            btnCelu.Enabled = false;
            rdbCien.Checked = false;
            rdbCincuenta.Checked = false;
            rdbDocientos.Checked = false;
            rdbTreinta.Checked = false;
            rdbTrescientos.Checked = false;
            cmbCelu.SelectedIndex = 0;
            btnOk.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbCien.Enabled = false;
            rdbCincuenta.Enabled = false;
            rdbDocientos.Enabled = false;
            rdbTreinta.Enabled = false;
            rdbTrescientos.Enabled = false;
            cmbCelu.Enabled = false;
            btnCelu.Enabled = false;
            rdbCien.Checked = false;
            rdbCincuenta.Checked = false;
            rdbDocientos.Checked = false;
            rdbTreinta.Checked = false;
            rdbTrescientos.Checked = false;
            cmbCelu.SelectedIndex = 0;
            btnOk.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sumandoCarga = 0;
            grbCant.Enabled = true;
            switch (cmbCelu.SelectedItem)
            {
                case "Motorola":
                    {
                        rdbCien.Enabled = true;
                        rdbCincuenta.Enabled = true;
                        rdbDocientos.Enabled = true;
                        rdbTreinta.Enabled = true;
                        rdbTrescientos.Enabled = true;

                        if (rdbCien.Checked == true)
                        {
                            sumandoCarga = 50;
                        }
                        else if (rdbDocientos.Checked == true)
                        {
                            sumandoCarga = 100;
                        }
                        else if (rdbTrescientos.Checked == true)
                        {
                            sumandoCarga = 500;
                        }
                        lblSumando.Text = sumandoCarga.ToString();
                        break;
                    }
                case "Telcel":
                    {
                        rdbCien.Enabled = true;
                        rdbDocientos.Enabled = true;
                        rdbTrescientos.Enabled = true;
                        rdbTreinta.Enabled = false;
                        rdbCincuenta.Enabled = false;
                        break;
                    }

                case "Nextel":
                    {
                        rdbCien.Enabled = true;
                        rdbCincuenta.Enabled = true;
                        rdbDocientos.Enabled = true;
                        rdbTreinta.Enabled = true;
                        rdbTrescientos.Enabled = true;
                        break;
                    }

                case "Seleccionar":
                    {
                        rdbCien.Enabled = false;
                        rdbCincuenta.Enabled = false;
                        rdbDocientos.Enabled = false;
                        rdbTreinta.Enabled = false;
                        rdbTrescientos.Enabled = false;
                        break;
                    }
            }
        }

        private void btnCelu_Click(object sender, EventArgs e)
        {
            double total = 0;
        

            if (rdbTreinta.Checked == true)
            {
                total = 30;
            }
            else if (rdbCincuenta.Checked == true)
            {
                total = 50;
            }
            else if (rdbCien.Checked == true)
            {
                total = 100;
            }
            else if (rdbDocientos.Checked == true)
            {
                total = 200;
            }
            else if (rdbTrescientos.Checked == true)
            {
                total = 500;
            }
            else
            {
                MessageBox.Show("Cantidad invalida");
            }
            double sum = Convert.ToDouble(lblSumando.Text);
            total += sum;
            lblTotal.Text = "El numero " + lblNumero.Text + " ha recargado $" + total;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string numero1 = Interaction.InputBox("Ingrese su numero telefonico");
            string numero2 = Interaction.InputBox("Ingrese su numero telefonico");
            if (numero1 == numero2)
            {
                grbCel.Enabled = true;
                btnCelu.Enabled = true;
                cmbCelu.Enabled = true;
                lblNumero.Text = Convert.ToString(numero1);
            }
            else
            {
                MessageBox.Show("Numero Invalido");
            }
        }

        private void cmbCelu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
