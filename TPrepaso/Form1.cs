namespace tprepaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDolar.Text = "";
            txtEuro.Text = "";
            txtInput.Text = "";
            txtPesos.Text = "";
            txtPesos1.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtDolar.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 880);
            txtEuro.Text = Convert.ToString(Convert.ToDouble(txtInput.Text) * 947.8);
            txtPesos.Text = txtInput.Text;
            txtPesos1.Text = txtInput.Text;
        }
    }
}