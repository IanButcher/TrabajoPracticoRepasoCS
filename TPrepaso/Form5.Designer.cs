namespace tprepaso
{
    partial class Form5
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
            groupBox2 = new GroupBox();
            cmbColores = new ComboBox();
            txtCantidad = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            btnOk = new Button();
            btnClear = new Button();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            rdbTres = new RadioButton();
            rdbCinco = new RadioButton();
            rdbSeis = new RadioButton();
            rdbCuatro = new RadioButton();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColores);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(21, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 101);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conversiones";
            // 
            // cmbColores
            // 
            cmbColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColores.FormattingEnabled = true;
            cmbColores.Items.AddRange(new object[] { "", "Color", "Blanco/Negro" });
            cmbColores.Location = new Point(203, 27);
            cmbColores.Name = "cmbColores";
            cmbColores.Size = new Size(121, 23);
            cmbColores.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(42, 53);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(72, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 5;
            label1.Text = "Cantidad de Fotos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 27);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(121, 334);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(72, 23);
            txtTotal.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 334);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Total";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(22, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 514);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Impresiones";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnOk);
            groupBox4.Controls.Add(btnClear);
            groupBox4.Location = new Point(27, 429);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(340, 66);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Botones";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(27, 22);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(116, 38);
            btnOk.TabIndex = 10;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(173, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 38);
            btnClear.TabIndex = 12;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 401);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = " ";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rdbTres);
            groupBox5.Controls.Add(rdbCinco);
            groupBox5.Controls.Add(rdbSeis);
            groupBox5.Controls.Add(rdbCuatro);
            groupBox5.Location = new Point(21, 152);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(269, 147);
            groupBox5.TabIndex = 37;
            groupBox5.TabStop = false;
            groupBox5.Text = "Medidas";
            // 
            // rdbTres
            // 
            rdbTres.AutoSize = true;
            rdbTres.Location = new Point(16, 47);
            rdbTres.Name = "rdbTres";
            rdbTres.Size = new Size(43, 19);
            rdbTres.TabIndex = 31;
            rdbTres.TabStop = true;
            rdbTres.Text = "3x4";
            rdbTres.UseVisualStyleBackColor = true;
            // 
            // rdbCinco
            // 
            rdbCinco.AutoSize = true;
            rdbCinco.Location = new Point(144, 47);
            rdbCinco.Name = "rdbCinco";
            rdbCinco.Size = new Size(43, 19);
            rdbCinco.TabIndex = 32;
            rdbCinco.TabStop = true;
            rdbCinco.Text = "5x7";
            rdbCinco.UseVisualStyleBackColor = true;
            // 
            // rdbSeis
            // 
            rdbSeis.AutoSize = true;
            rdbSeis.Location = new Point(144, 101);
            rdbSeis.Name = "rdbSeis";
            rdbSeis.Size = new Size(43, 19);
            rdbSeis.TabIndex = 34;
            rdbSeis.TabStop = true;
            rdbSeis.Text = "6x8";
            rdbSeis.UseVisualStyleBackColor = true;
            // 
            // rdbCuatro
            // 
            rdbCuatro.AutoSize = true;
            rdbCuatro.Location = new Point(16, 101);
            rdbCuatro.Name = "rdbCuatro";
            rdbCuatro.Size = new Size(43, 19);
            rdbCuatro.TabIndex = 33;
            rdbCuatro.TabStop = true;
            rdbCuatro.Text = "4x6";
            rdbCuatro.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 550);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtCantidad;
        private TextBox txtTotal;
        private Label label1;
        private Label label4;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnOk;
        private Button btnClear;
        private ComboBox cmbColores;
        private GroupBox groupBox5;
        private RadioButton rdbTres;
        private RadioButton rdbCinco;
        private RadioButton rdbSeis;
        private RadioButton rdbCuatro;
    }
}