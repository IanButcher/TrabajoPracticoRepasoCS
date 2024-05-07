namespace tprepaso
{
    partial class Form4
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
            txtLOLO = new TextBox();
            btnOk = new Button();
            btnClear = new Button();
            rdbSoltero = new RadioButton();
            rdbCasado = new RadioButton();
            rdbVuido = new RadioButton();
            rdbDivorciado = new RadioButton();
            rdbBuscado = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLOLO
            // 
            txtLOLO.Enabled = false;
            txtLOLO.Location = new Point(251, 134);
            txtLOLO.Multiline = true;
            txtLOLO.Name = "txtLOLO";
            txtLOLO.Size = new Size(174, 137);
            txtLOLO.TabIndex = 28;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(251, 90);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 29;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(350, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 30;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // rdbSoltero
            // 
            rdbSoltero.AutoSize = true;
            rdbSoltero.Location = new Point(16, 47);
            rdbSoltero.Name = "rdbSoltero";
            rdbSoltero.Size = new Size(73, 19);
            rdbSoltero.TabIndex = 31;
            rdbSoltero.TabStop = true;
            rdbSoltero.Text = "Soltero/a";
            rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            rdbCasado.AutoSize = true;
            rdbCasado.Location = new Point(16, 91);
            rdbCasado.Name = "rdbCasado";
            rdbCasado.Size = new Size(75, 19);
            rdbCasado.TabIndex = 32;
            rdbCasado.TabStop = true;
            rdbCasado.Text = "Casado/a";
            rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbVuido
            // 
            rdbVuido.AutoSize = true;
            rdbVuido.Location = new Point(16, 142);
            rdbVuido.Name = "rdbVuido";
            rdbVuido.Size = new Size(67, 19);
            rdbVuido.TabIndex = 33;
            rdbVuido.TabStop = true;
            rdbVuido.Text = "Viudo/a";
            rdbVuido.UseVisualStyleBackColor = true;
            // 
            // rdbDivorciado
            // 
            rdbDivorciado.AutoSize = true;
            rdbDivorciado.Location = new Point(16, 185);
            rdbDivorciado.Name = "rdbDivorciado";
            rdbDivorciado.Size = new Size(82, 19);
            rdbDivorciado.TabIndex = 34;
            rdbDivorciado.TabStop = true;
            rdbDivorciado.Text = "Divorciado";
            rdbDivorciado.UseVisualStyleBackColor = true;
            rdbDivorciado.CheckedChanged += rdbDivorciado_CheckedChanged;
            // 
            // rdbBuscado
            // 
            rdbBuscado.AutoSize = true;
            rdbBuscado.Location = new Point(16, 226);
            rdbBuscado.Name = "rdbBuscado";
            rdbBuscado.Size = new Size(70, 19);
            rdbBuscado.TabIndex = 35;
            rdbBuscado.TabStop = true;
            rdbBuscado.Text = "Buscado";
            rdbBuscado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbSoltero);
            groupBox1.Controls.Add(rdbBuscado);
            groupBox1.Controls.Add(rdbCasado);
            groupBox1.Controls.Add(rdbDivorciado);
            groupBox1.Controls.Add(rdbVuido);
            groupBox1.Location = new Point(60, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 267);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Civil";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 340);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnOk);
            Controls.Add(txtLOLO);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLOLO;
        private Button btnOk;
        private Button btnClear;
        private RadioButton rdbSoltero;
        private RadioButton rdbCasado;
        private RadioButton rdbVuido;
        private RadioButton rdbDivorciado;
        private RadioButton rdbBuscado;
        private GroupBox groupBox1;
    }
}