namespace tprepaso
{
    partial class Form6
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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            btnClear = new Button();
            btnOk = new Button();
            btnSalir = new Button();
            groupBox3 = new GroupBox();
            grbCel = new GroupBox();
            btnCelu = new Button();
            cmbCelu = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            grbCant = new GroupBox();
            rdbCien = new RadioButton();
            rdbTreinta = new RadioButton();
            rdbDocientos = new RadioButton();
            rdbTrescientos = new RadioButton();
            rdbCincuenta = new RadioButton();
            lblTotal = new Label();
            lblNumero = new Label();
            lblSumando = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            grbCel.SuspendLayout();
            grbCant.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(26, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(690, 514);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Impresiones";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnClear);
            groupBox4.Controls.Add(btnOk);
            groupBox4.Controls.Add(btnSalir);
            groupBox4.Location = new Point(64, 39);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(519, 66);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Botones";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(352, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 38);
            btnClear.TabIndex = 13;
            btnClear.Text = "Nueva Recarga";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(27, 22);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(116, 38);
            btnOk.TabIndex = 10;
            btnOk.Text = "Cargar Celular";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(grbCel);
            groupBox3.Controls.Add(btnCelu);
            groupBox3.Controls.Add(grbCant);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Location = new Point(31, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(625, 375);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = " Datos del Cliente";
            // 
            // grbCel
            // 
            grbCel.Controls.Add(button1);
            grbCel.Controls.Add(cmbCelu);
            grbCel.Controls.Add(label3);
            grbCel.Controls.Add(label5);
            grbCel.Enabled = false;
            grbCel.Location = new Point(293, 148);
            grbCel.Name = "grbCel";
            grbCel.Size = new Size(330, 101);
            grbCel.TabIndex = 16;
            grbCel.TabStop = false;
            grbCel.Text = "Celular";
            // 
            // btnCelu
            // 
            btnCelu.Location = new Point(34, 293);
            btnCelu.Name = "btnCelu";
            btnCelu.Size = new Size(116, 38);
            btnCelu.TabIndex = 13;
            btnCelu.Text = "Aceptar";
            btnCelu.UseVisualStyleBackColor = true;
            btnCelu.Click += btnCelu_Click;
            // 
            // cmbCelu
            // 
            cmbCelu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCelu.FormattingEnabled = true;
            cmbCelu.Items.AddRange(new object[] { "Seleccionar", "Motorola", "Telcel", "Nextel" });
            cmbCelu.Location = new Point(203, 27);
            cmbCelu.Name = "cmbCelu";
            cmbCelu.Size = new Size(121, 23);
            cmbCelu.TabIndex = 9;
            cmbCelu.SelectedIndexChanged += cmbCelu_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 27);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Marca de Celular";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 27);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // grbCant
            // 
            grbCant.Controls.Add(rdbCien);
            grbCant.Controls.Add(rdbTreinta);
            grbCant.Controls.Add(rdbDocientos);
            grbCant.Controls.Add(rdbTrescientos);
            grbCant.Controls.Add(rdbCincuenta);
            grbCant.Enabled = false;
            grbCant.Location = new Point(18, 129);
            grbCant.Name = "grbCant";
            grbCant.Size = new Size(255, 147);
            grbCant.TabIndex = 37;
            grbCant.TabStop = false;
            grbCant.Text = "Cantidad";
            // 
            // rdbCien
            // 
            rdbCien.AutoSize = true;
            rdbCien.Location = new Point(87, 76);
            rdbCien.Name = "rdbCien";
            rdbCien.Size = new Size(43, 19);
            rdbCien.TabIndex = 35;
            rdbCien.TabStop = true;
            rdbCien.Text = "100";
            rdbCien.UseVisualStyleBackColor = true;
            // 
            // rdbTreinta
            // 
            rdbTreinta.AutoSize = true;
            rdbTreinta.Location = new Point(16, 47);
            rdbTreinta.Name = "rdbTreinta";
            rdbTreinta.Size = new Size(37, 19);
            rdbTreinta.TabIndex = 31;
            rdbTreinta.TabStop = true;
            rdbTreinta.Text = "30";
            rdbTreinta.UseVisualStyleBackColor = true;
            // 
            // rdbDocientos
            // 
            rdbDocientos.AutoSize = true;
            rdbDocientos.Location = new Point(144, 47);
            rdbDocientos.Name = "rdbDocientos";
            rdbDocientos.Size = new Size(43, 19);
            rdbDocientos.TabIndex = 32;
            rdbDocientos.TabStop = true;
            rdbDocientos.Text = "200";
            rdbDocientos.UseVisualStyleBackColor = true;
            // 
            // rdbTrescientos
            // 
            rdbTrescientos.AutoSize = true;
            rdbTrescientos.Location = new Point(144, 101);
            rdbTrescientos.Name = "rdbTrescientos";
            rdbTrescientos.Size = new Size(43, 19);
            rdbTrescientos.TabIndex = 34;
            rdbTrescientos.TabStop = true;
            rdbTrescientos.Text = "500";
            rdbTrescientos.UseVisualStyleBackColor = true;
            // 
            // rdbCincuenta
            // 
            rdbCincuenta.AutoSize = true;
            rdbCincuenta.Location = new Point(16, 101);
            rdbCincuenta.Name = "rdbCincuenta";
            rdbCincuenta.Size = new Size(37, 19);
            rdbCincuenta.TabIndex = 33;
            rdbCincuenta.TabStop = true;
            rdbCincuenta.Text = "50";
            rdbCincuenta.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(63, 334);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Enabled = false;
            lblNumero.Location = new Point(739, 86);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(32, 15);
            lblNumero.TabIndex = 38;
            lblNumero.Text = "Total";
            lblNumero.Visible = false;
            // 
            // lblSumando
            // 
            lblSumando.AutoSize = true;
            lblSumando.Enabled = false;
            lblSumando.Location = new Point(739, 113);
            lblSumando.Name = "lblSumando";
            lblSumando.Size = new Size(32, 15);
            lblSumando.TabIndex = 39;
            lblSumando.Text = "Total";
            lblSumando.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(10, 57);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 14;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(lblSumando);
            Controls.Add(lblNumero);
            Controls.Add(groupBox1);
            Name = "Form6";
            Text = "Recarga_Celular";
            Load += Form6_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            grbCel.ResumeLayout(false);
            grbCel.PerformLayout();
            grbCant.ResumeLayout(false);
            grbCant.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Button btnOk;
        private Button btnSalir;
        private GroupBox groupBox3;
        private GroupBox grbCant;
        private RadioButton rdbTreinta;
        private RadioButton rdbDocientos;
        private RadioButton rdbTrescientos;
        private RadioButton rdbCincuenta;
        private TextBox txtTotal;
        private GroupBox groupBox2;
        private ComboBox cmbColores;
        private TextBox txtCantidad;
        private Label label1;
        private Label label4;
        private Label lblTotal;
        private GroupBox grbCel;
        private Button btnCelu;
        private ComboBox cmbCelu;
        private Label label3;
        private Label label5;
        private RadioButton rdbCien;
        private Button btnClear;
        private Label lblNumero;
        private Label lblSumando;
        private Button button1;
    }
}