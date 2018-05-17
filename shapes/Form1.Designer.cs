namespace shapes
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbColorCuadrado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarCuadrado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLadoCuadrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarRectangulo = new System.Windows.Forms.Button();
            this.cbColorRectangulo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbAlturaRectangulo = new System.Windows.Forms.TextBox();
            this.tbBaseRectangulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarCirculo = new System.Windows.Forms.Button();
            this.cbColorCirculo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRadioCirculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonAgregarTriangulo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbColorTriangulo = new System.Windows.Forms.ComboBox();
            this.tbAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.tbBaseTriangulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 634);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbColorCuadrado);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnAgregarCuadrado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbLadoCuadrado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 119);
            this.panel1.TabIndex = 4;
            // 
            // cbColorCuadrado
            // 
            this.cbColorCuadrado.FormattingEnabled = true;
            this.cbColorCuadrado.Location = new System.Drawing.Point(72, 54);
            this.cbColorCuadrado.Name = "cbColorCuadrado";
            this.cbColorCuadrado.Size = new System.Drawing.Size(173, 22);
            this.cbColorCuadrado.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 14);
            this.label13.TabIndex = 5;
            this.label13.Text = "Color";
            // 
            // btnAgregarCuadrado
            // 
            this.btnAgregarCuadrado.Location = new System.Drawing.Point(3, 91);
            this.btnAgregarCuadrado.Name = "btnAgregarCuadrado";
            this.btnAgregarCuadrado.Size = new System.Drawing.Size(249, 23);
            this.btnAgregarCuadrado.TabIndex = 3;
            this.btnAgregarCuadrado.Text = "Agregar";
            this.btnAgregarCuadrado.UseVisualStyleBackColor = true;
            this.btnAgregarCuadrado.Click += new System.EventHandler(this.btnAgregarCuadrado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lado";
            // 
            // tbLadoCuadrado
            // 
            this.tbLadoCuadrado.Location = new System.Drawing.Point(72, 28);
            this.tbLadoCuadrado.Name = "tbLadoCuadrado";
            this.tbLadoCuadrado.Size = new System.Drawing.Size(173, 20);
            this.tbLadoCuadrado.TabIndex = 1;
            this.tbLadoCuadrado.Text = "0";
            this.tbLadoCuadrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLadoCuadrado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuadrado";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAgregarRectangulo);
            this.panel2.Controls.Add(this.cbColorRectangulo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tbAlturaRectangulo);
            this.panel2.Controls.Add(this.tbBaseRectangulo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 171);
            this.panel2.TabIndex = 5;
            // 
            // btnAgregarRectangulo
            // 
            this.btnAgregarRectangulo.Location = new System.Drawing.Point(12, 128);
            this.btnAgregarRectangulo.Name = "btnAgregarRectangulo";
            this.btnAgregarRectangulo.Size = new System.Drawing.Size(235, 23);
            this.btnAgregarRectangulo.TabIndex = 9;
            this.btnAgregarRectangulo.Text = "Agregar";
            this.btnAgregarRectangulo.UseVisualStyleBackColor = true;
            this.btnAgregarRectangulo.Click += new System.EventHandler(this.btnAgregarRectangulo_Click);
            // 
            // cbColorRectangulo
            // 
            this.cbColorRectangulo.FormattingEnabled = true;
            this.cbColorRectangulo.Location = new System.Drawing.Point(73, 100);
            this.cbColorRectangulo.Name = "cbColorRectangulo";
            this.cbColorRectangulo.Size = new System.Drawing.Size(173, 22);
            this.cbColorRectangulo.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 14);
            this.label14.TabIndex = 7;
            this.label14.Text = "Color";
            // 
            // tbAlturaRectangulo
            // 
            this.tbAlturaRectangulo.Location = new System.Drawing.Point(73, 65);
            this.tbAlturaRectangulo.Name = "tbAlturaRectangulo";
            this.tbAlturaRectangulo.Size = new System.Drawing.Size(173, 20);
            this.tbAlturaRectangulo.TabIndex = 4;
            this.tbAlturaRectangulo.Text = "0";
            this.tbAlturaRectangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlturaRectangulo_KeyPress);
            // 
            // tbBaseRectangulo
            // 
            this.tbBaseRectangulo.Location = new System.Drawing.Point(73, 30);
            this.tbBaseRectangulo.Name = "tbBaseRectangulo";
            this.tbBaseRectangulo.Size = new System.Drawing.Size(173, 20);
            this.tbBaseRectangulo.TabIndex = 3;
            this.tbBaseRectangulo.Text = "0";
            this.tbBaseRectangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseRectangulo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Altura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rectangulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAgregarCirculo);
            this.panel3.Controls.Add(this.cbColorCirculo);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tbRadioCirculo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 131);
            this.panel3.TabIndex = 6;
            // 
            // btnAgregarCirculo
            // 
            this.btnAgregarCirculo.Location = new System.Drawing.Point(11, 97);
            this.btnAgregarCirculo.Name = "btnAgregarCirculo";
            this.btnAgregarCirculo.Size = new System.Drawing.Size(235, 23);
            this.btnAgregarCirculo.TabIndex = 5;
            this.btnAgregarCirculo.Text = "Agregar";
            this.btnAgregarCirculo.UseVisualStyleBackColor = true;
            this.btnAgregarCirculo.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbColorCirculo
            // 
            this.cbColorCirculo.FormattingEnabled = true;
            this.cbColorCirculo.Location = new System.Drawing.Point(73, 57);
            this.cbColorCirculo.Name = "cbColorCirculo";
            this.cbColorCirculo.Size = new System.Drawing.Size(173, 22);
            this.cbColorCirculo.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 14);
            this.label12.TabIndex = 3;
            this.label12.Text = "Color";
            // 
            // tbRadioCirculo
            // 
            this.tbRadioCirculo.Location = new System.Drawing.Point(73, 24);
            this.tbRadioCirculo.Name = "tbRadioCirculo";
            this.tbRadioCirculo.Size = new System.Drawing.Size(173, 20);
            this.tbRadioCirculo.TabIndex = 2;
            this.tbRadioCirculo.Text = "0";
            this.tbRadioCirculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRadioCirculo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Radio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Circulo";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonAgregarTriangulo);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cbColorTriangulo);
            this.panel4.Controls.Add(this.tbAlturaTriangulo);
            this.panel4.Controls.Add(this.tbBaseTriangulo);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(13, 464);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 183);
            this.panel4.TabIndex = 7;
            // 
            // buttonAgregarTriangulo
            // 
            this.buttonAgregarTriangulo.Location = new System.Drawing.Point(11, 155);
            this.buttonAgregarTriangulo.Name = "buttonAgregarTriangulo";
            this.buttonAgregarTriangulo.Size = new System.Drawing.Size(235, 23);
            this.buttonAgregarTriangulo.TabIndex = 7;
            this.buttonAgregarTriangulo.Text = "Agregar";
            this.buttonAgregarTriangulo.UseVisualStyleBackColor = true;
            this.buttonAgregarTriangulo.Click += new System.EventHandler(this.buttonAgregarTriangulo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 14);
            this.label11.TabIndex = 6;
            this.label11.Text = "Color";
            // 
            // cbColorTriangulo
            // 
            this.cbColorTriangulo.FormattingEnabled = true;
            this.cbColorTriangulo.Location = new System.Drawing.Point(72, 106);
            this.cbColorTriangulo.Name = "cbColorTriangulo";
            this.cbColorTriangulo.Size = new System.Drawing.Size(173, 22);
            this.cbColorTriangulo.TabIndex = 5;
            // 
            // tbAlturaTriangulo
            // 
            this.tbAlturaTriangulo.Location = new System.Drawing.Point(72, 66);
            this.tbAlturaTriangulo.Name = "tbAlturaTriangulo";
            this.tbAlturaTriangulo.Size = new System.Drawing.Size(173, 20);
            this.tbAlturaTriangulo.TabIndex = 4;
            this.tbAlturaTriangulo.Text = "0";
            this.tbAlturaTriangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlturaTriangulo_KeyPress);
            // 
            // tbBaseTriangulo
            // 
            this.tbBaseTriangulo.Location = new System.Drawing.Point(72, 29);
            this.tbBaseTriangulo.Name = "tbBaseTriangulo";
            this.tbBaseTriangulo.Size = new System.Drawing.Size(173, 20);
            this.tbBaseTriangulo.TabIndex = 3;
            this.tbBaseTriangulo.Text = "0";
            this.tbBaseTriangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseTriangulo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 14);
            this.label10.TabIndex = 2;
            this.label10.Text = "Altura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Triangulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 659);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAgregarCuadrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLadoCuadrado;
        private System.Windows.Forms.TextBox tbAlturaRectangulo;
        private System.Windows.Forms.TextBox tbBaseRectangulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRadioCirculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbColorTriangulo;
        private System.Windows.Forms.TextBox tbAlturaTriangulo;
        private System.Windows.Forms.TextBox tbBaseTriangulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAgregarTriangulo;
        private System.Windows.Forms.ComboBox cbColorCirculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbColorCuadrado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbColorRectangulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAgregarCirculo;
        private System.Windows.Forms.Button btnAgregarRectangulo;
    }
}

