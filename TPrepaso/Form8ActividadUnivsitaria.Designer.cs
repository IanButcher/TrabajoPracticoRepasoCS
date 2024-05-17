namespace tprepaso
{
    partial class Form8ActividadUnivsitaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsbNumeros = new ListBox();
            txtInput = new TextBox();
            btnOk = new Button();
            btnClear = new Button();
            chkSuma = new CheckBox();
            chkResta = new CheckBox();
            lblSuma = new Label();
            lblresta = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lsbNumeros
            // 
            lsbNumeros.Enabled = false;
            lsbNumeros.FormattingEnabled = true;
            lsbNumeros.ItemHeight = 15;
            lsbNumeros.Location = new Point(36, 188);
            lsbNumeros.Name = "lsbNumeros";
            lsbNumeros.Size = new Size(131, 214);
            lsbNumeros.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(77, 118);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(90, 23);
            txtInput.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(230, 346);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(215, 155);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // chkSuma
            // 
            chkSuma.AutoSize = true;
            chkSuma.Location = new Point(207, 209);
            chkSuma.Name = "chkSuma";
            chkSuma.Size = new Size(56, 19);
            chkSuma.TabIndex = 15;
            chkSuma.Text = "Suma";
            chkSuma.UseVisualStyleBackColor = true;
            chkSuma.CheckedChanged += chkSuma_CheckedChanged;
            // 
            // chkResta
            // 
            chkResta.AutoSize = true;
            chkResta.Location = new Point(207, 245);
            chkResta.Name = "chkResta";
            chkResta.Size = new Size(54, 19);
            chkResta.TabIndex = 16;
            chkResta.Text = "Resta";
            chkResta.UseVisualStyleBackColor = true;
            chkResta.CheckedChanged += chkResta_CheckedChanged;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(334, 206);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(32, 15);
            lblSuma.TabIndex = 17;
            lblSuma.Text = "Total";
            // 
            // lblresta
            // 
            lblresta.AutoSize = true;
            lblresta.Location = new Point(334, 249);
            lblresta.Name = "lblresta";
            lblresta.Size = new Size(32, 15);
            lblresta.TabIndex = 19;
            lblresta.Text = "Total";
            // 
            // button1
            // 
            button1.Location = new Point(215, 118);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form8ActividadUnivsitaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(button1);
            Controls.Add(lblresta);
            Controls.Add(lblSuma);
            Controls.Add(chkResta);
            Controls.Add(chkSuma);
            Controls.Add(btnClear);
            Controls.Add(btnOk);
            Controls.Add(txtInput);
            Controls.Add(lsbNumeros);
            Name = "Form8ActividadUnivsitaria";
            Text = "Form8ActividadUnivsitaria";
            Load += Form8ActividadUnivsitaria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbNumeros;
        private TextBox txtInput;
        private Button btnOk;
        private Button btnClear;
        private CheckBox chkSuma;
        private CheckBox chkResta;
        private Label lblSuma;
        private Label lblresta;
        private Button button1;
    }
}