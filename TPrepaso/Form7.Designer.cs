namespace tprepaso
{
    partial class Form7
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
            groupBox4 = new GroupBox();
            btnClear = new Button();
            btnOk = new Button();
            btnSalir = new Button();
            grbCant = new GroupBox();
            rdbUno = new RadioButton();
            rdbSei = new RadioButton();
            rdbDie = new RadioButton();
            groupBox1 = new GroupBox();
            chkBD = new CheckBox();
            chkOracle = new CheckBox();
            chkPHP = new CheckBox();
            chkASP = new CheckBox();
            chkV8 = new CheckBox();
            chkJava = new CheckBox();
            cmbNacionalidad = new ComboBox();
            cmbGenero = new ComboBox();
            txtEdad = new TextBox();
            txtSueldo = new TextBox();
            lblSueldo = new Label();
            lblEdad = new Label();
            groupBox2 = new GroupBox();
            txtTotal = new TextBox();
            groupBox4.SuspendLayout();
            grbCant.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnClear);
            groupBox4.Controls.Add(btnOk);
            groupBox4.Controls.Add(btnSalir);
            groupBox4.Location = new Point(86, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(519, 66);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Botones";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(352, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 38);
            btnClear.TabIndex = 13;
            btnClear.Text = "Nuevo";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
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
            // btnSalir
            // 
            btnSalir.Location = new Point(197, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 38);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // grbCant
            // 
            grbCant.Controls.Add(rdbUno);
            grbCant.Controls.Add(rdbSei);
            grbCant.Controls.Add(rdbDie);
            grbCant.Location = new Point(400, 224);
            grbCant.Name = "grbCant";
            grbCant.Size = new Size(159, 112);
            grbCant.TabIndex = 38;
            grbCant.TabStop = false;
            grbCant.Text = "Cantidad";
            // 
            // rdbUno
            // 
            rdbUno.AutoSize = true;
            rdbUno.Location = new Point(6, 24);
            rdbUno.Name = "rdbUno";
            rdbUno.Size = new Size(70, 19);
            rdbUno.TabIndex = 31;
            rdbUno.TabStop = true;
            rdbUno.Text = "1-5 años";
            rdbUno.UseVisualStyleBackColor = true;
            // 
            // rdbSei
            // 
            rdbSei.AutoSize = true;
            rdbSei.Location = new Point(6, 53);
            rdbSei.Name = "rdbSei";
            rdbSei.Size = new Size(76, 19);
            rdbSei.TabIndex = 32;
            rdbSei.TabStop = true;
            rdbSei.Text = "6-10 años";
            rdbSei.UseVisualStyleBackColor = true;
            // 
            // rdbDie
            // 
            rdbDie.AutoSize = true;
            rdbDie.Location = new Point(6, 78);
            rdbDie.Name = "rdbDie";
            rdbDie.Size = new Size(73, 19);
            rdbDie.TabIndex = 33;
            rdbDie.TabStop = true;
            rdbDie.Text = "+10 años";
            rdbDie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkBD);
            groupBox1.Controls.Add(chkOracle);
            groupBox1.Controls.Add(chkPHP);
            groupBox1.Controls.Add(chkASP);
            groupBox1.Controls.Add(chkV8);
            groupBox1.Controls.Add(chkJava);
            groupBox1.Location = new Point(104, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 210);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hobbies";
            // 
            // chkBD
            // 
            chkBD.AutoSize = true;
            chkBD.Location = new Point(6, 147);
            chkBD.Name = "chkBD";
            chkBD.Size = new Size(41, 19);
            chkBD.TabIndex = 27;
            chkBD.Text = "BD";
            chkBD.UseVisualStyleBackColor = true;
            // 
            // chkOracle
            // 
            chkOracle.AutoSize = true;
            chkOracle.Location = new Point(6, 122);
            chkOracle.Name = "chkOracle";
            chkOracle.Size = new Size(60, 19);
            chkOracle.TabIndex = 26;
            chkOracle.Text = "Oracle";
            chkOracle.UseVisualStyleBackColor = true;
            // 
            // chkPHP
            // 
            chkPHP.AutoSize = true;
            chkPHP.Location = new Point(9, 22);
            chkPHP.Name = "chkPHP";
            chkPHP.Size = new Size(49, 19);
            chkPHP.TabIndex = 22;
            chkPHP.Text = "PHP";
            chkPHP.UseVisualStyleBackColor = true;
            // 
            // chkASP
            // 
            chkASP.AutoSize = true;
            chkASP.Location = new Point(9, 47);
            chkASP.Name = "chkASP";
            chkASP.Size = new Size(71, 19);
            chkASP.TabIndex = 23;
            chkASP.Text = "ASP.NET";
            chkASP.UseVisualStyleBackColor = true;
            // 
            // chkV8
            // 
            chkV8.AutoSize = true;
            chkV8.Location = new Point(6, 72);
            chkV8.Name = "chkV8";
            chkV8.Size = new Size(59, 19);
            chkV8.TabIndex = 24;
            chkV8.Text = "V8 net";
            chkV8.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(6, 97);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(48, 19);
            chkJava.TabIndex = 25;
            chkJava.Text = "Java";
            chkJava.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Items.AddRange(new object[] { "Nacional", "Extranjero" });
            cmbNacionalidad.Location = new Point(59, 90);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(121, 23);
            cmbNacionalidad.TabIndex = 39;
            cmbNacionalidad.SelectedIndexChanged += cmbNacionalidad_SelectedIndexChanged;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Genero", "Masculino", "Femenino" });
            cmbGenero.Location = new Point(59, 135);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 40;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(59, 51);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(99, 23);
            txtEdad.TabIndex = 41;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(59, 22);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(99, 23);
            txtSueldo.TabIndex = 42;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(10, 22);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(43, 15);
            lblSueldo.TabIndex = 43;
            lblSueldo.Text = "Sueldo";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(21, 51);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 44;
            lblEdad.Text = "Edad";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(lblEdad);
            groupBox2.Controls.Add(cmbNacionalidad);
            groupBox2.Controls.Add(lblSueldo);
            groupBox2.Controls.Add(cmbGenero);
            groupBox2.Controls.Add(txtSueldo);
            groupBox2.Location = new Point(391, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 165);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(217, 74);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(72, 23);
            txtTotal.TabIndex = 46;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grbCant);
            Controls.Add(groupBox4);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            groupBox4.ResumeLayout(false);
            grbCant.ResumeLayout(false);
            grbCant.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnClear;
        private Button btnOk;
        private Button btnSalir;
        private GroupBox grbCant;
        private RadioButton rdbUno;
        private RadioButton rdbSei;
        private RadioButton rdbDie;
        private GroupBox groupBox1;
        private CheckBox chkPHP;
        private CheckBox chkASP;
        private CheckBox chkV8;
        private CheckBox chkJava;
        private CheckBox chkBD;
        private CheckBox chkOracle;
        private ComboBox cmbNacionalidad;
        private ComboBox cmbGenero;
        private TextBox txtEdad;
        private TextBox txtSueldo;
        private Label lblSueldo;
        private Label lblEdad;
        private GroupBox groupBox2;
        private TextBox txtTotal;
    }
}