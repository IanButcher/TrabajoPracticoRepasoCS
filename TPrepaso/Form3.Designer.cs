namespace tprepaso
{
    partial class Form3
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
            btnOk = new Button();
            chkLeer = new CheckBox();
            chkBailar = new CheckBox();
            chkComer = new CheckBox();
            chkVer = new CheckBox();
            btnClear = new Button();
            txtLOLO = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(243, 70);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 21;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // chkLeer
            // 
            chkLeer.AutoSize = true;
            chkLeer.Location = new Point(25, 40);
            chkLeer.Name = "chkLeer";
            chkLeer.Size = new Size(51, 19);
            chkLeer.TabIndex = 22;
            chkLeer.Text = "Leer ";
            chkLeer.UseVisualStyleBackColor = true;
            chkLeer.CheckedChanged += chkLeer_CheckedChanged;
            // 
            // chkBailar
            // 
            chkBailar.AutoSize = true;
            chkBailar.Location = new Point(25, 80);
            chkBailar.Name = "chkBailar";
            chkBailar.Size = new Size(58, 19);
            chkBailar.TabIndex = 23;
            chkBailar.Text = "Bailar ";
            chkBailar.UseVisualStyleBackColor = true;
            // 
            // chkComer
            // 
            chkComer.AutoSize = true;
            chkComer.Location = new Point(25, 124);
            chkComer.Name = "chkComer";
            chkComer.Size = new Size(65, 19);
            chkComer.TabIndex = 24;
            chkComer.Text = "Comer ";
            chkComer.UseVisualStyleBackColor = true;
            // 
            // chkVer
            // 
            chkVer.AutoSize = true;
            chkVer.Location = new Point(25, 175);
            chkVer.Name = "chkVer";
            chkVer.Size = new Size(61, 19);
            chkVer.TabIndex = 25;
            chkVer.Text = "Ver TV ";
            chkVer.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(342, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 26;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtLOLO
            // 
            txtLOLO.Enabled = false;
            txtLOLO.Location = new Point(243, 115);
            txtLOLO.Multiline = true;
            txtLOLO.Name = "txtLOLO";
            txtLOLO.Size = new Size(174, 137);
            txtLOLO.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkLeer);
            groupBox1.Controls.Add(chkBailar);
            groupBox1.Controls.Add(chkComer);
            groupBox1.Controls.Add(chkVer);
            groupBox1.Location = new Point(81, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(103, 210);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hobbies";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 313);
            Controls.Add(groupBox1);
            Controls.Add(txtLOLO);
            Controls.Add(btnClear);
            Controls.Add(btnOk);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private CheckBox chkLeer;
        private CheckBox chkBailar;
        private CheckBox chkComer;
        private CheckBox chkVer;
        private Button btnClear;
        private TextBox txtLOLO;
        private GroupBox groupBox1;
    }
}