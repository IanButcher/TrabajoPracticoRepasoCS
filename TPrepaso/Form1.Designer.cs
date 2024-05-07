namespace tprepaso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            txtPesos = new TextBox();
            txtDolar = new TextBox();
            txtEuro = new TextBox();
            txtPesos1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnOk = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(77, 11);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(51, 23);
            txtInput.TabIndex = 0;
            // 
            // txtPesos
            // 
            txtPesos.Enabled = false;
            txtPesos.Location = new Point(75, 22);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(72, 23);
            txtPesos.TabIndex = 1;
            // 
            // txtDolar
            // 
            txtDolar.Enabled = false;
            txtDolar.Location = new Point(238, 22);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(72, 23);
            txtDolar.TabIndex = 2;
            // 
            // txtEuro
            // 
            txtEuro.Enabled = false;
            txtEuro.Location = new Point(238, 63);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(72, 23);
            txtEuro.TabIndex = 3;
            // 
            // txtPesos1
            // 
            txtPesos1.Enabled = false;
            txtPesos1.Location = new Point(75, 63);
            txtPesos1.Name = "txtPesos1";
            txtPesos1.Size = new Size(72, 23);
            txtPesos1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Pesos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Pesos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 19);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Pesos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 27);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Dolares";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 71);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Euros";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(6, 22);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 10;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 65);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Location = new Point(202, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 55);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPesos);
            groupBox2.Controls.Add(txtDolar);
            groupBox2.Controls.Add(txtEuro);
            groupBox2.Controls.Add(txtPesos1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(41, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 93);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conversiones";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnOk);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Location = new Point(41, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(109, 100);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Botones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 294);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtPesos;
        private TextBox txtDolar;
        private TextBox txtEuro;
        private TextBox txtPesos1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnOk;
        private Button btnClear;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}