namespace tprepaso
{
    partial class Form8ActividadExtra
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
            lsbImpar = new ListBox();
            lsbPar = new ListBox();
            txtInput = new TextBox();
            btnOk = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lsbImpar
            // 
            lsbImpar.Enabled = false;
            lsbImpar.FormattingEnabled = true;
            lsbImpar.ItemHeight = 15;
            lsbImpar.Location = new Point(233, 128);
            lsbImpar.Name = "lsbImpar";
            lsbImpar.Size = new Size(131, 214);
            lsbImpar.TabIndex = 0;
            // 
            // lsbPar
            // 
            lsbPar.Enabled = false;
            lsbPar.FormattingEnabled = true;
            lsbPar.ItemHeight = 15;
            lsbPar.Location = new Point(66, 128);
            lsbPar.Name = "lsbPar";
            lsbPar.Size = new Size(131, 214);
            lsbPar.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(107, 69);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(90, 23);
            txtInput.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(241, 52);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(241, 81);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form8ActividadExtra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
            Controls.Add(btnClear);
            Controls.Add(btnOk);
            Controls.Add(txtInput);
            Controls.Add(lsbPar);
            Controls.Add(lsbImpar);
            Name = "Form8ActividadExtra";
            Text = "Form8ActividadExtra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbImpar;
        private ListBox lsbPar;
        private TextBox txtInput;
        private Button btnOk;
        private Button btnClear;
    }
}