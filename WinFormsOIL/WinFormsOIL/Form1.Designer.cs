namespace WinFormsOIL
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AI 92",
            "AI 95",
            "Diesel"});
            this.comboBox1.Location = new System.Drawing.Point(86, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Топливо";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Литр";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "AZN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Оплата";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 500);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.button1);
            this.panel3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(3, 335);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 178);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(302, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 61);
            this.label14.TabIndex = 15;
            this.label14.Text = "Итоговая сумма";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(693, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 39);
            this.label13.TabIndex = 13;
            this.label13.Text = "AZN";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(505, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(142, 27);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заправка";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(63, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 113);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Оплата за топливо";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "AZN";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(606, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 336);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(37, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 324);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мини-Кафе";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            this.groupBox2.Leave += new System.EventHandler(this.groupBox2_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(243, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "AZN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(242, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "AZN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "AZN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(86, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 113);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оплата за кафе";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 67);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Оплата";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(297, 109);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(61, 27);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "0";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(176, 109);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(61, 27);
            this.textBox10.TabIndex = 19;
            this.textBox10.Text = "3";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(0, 112);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(128, 24);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Клаб Сендвич";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(0, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Бургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(176, 74);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(61, 27);
            this.textBox9.TabIndex = 16;
            this.textBox9.Text = "5";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(297, 73);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(61, 27);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "0";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "AZN";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Хот-дог";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Количество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Цена";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(175, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(61, 27);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "4";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(297, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(61, 27);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SocarOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Label label10;
        private Label label9;
        private TextBox textBox6;
        private Label label12;
        private Label label11;
        private Panel panel3;
        private Label label14;
        private Label label13;
        private TextBox textBox7;
        private TextBox textBox11;
        private TextBox textBox10;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private TextBox textBox9;
        private TextBox textBox8;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label17;
        private Label label16;
        private Label label15;
    }
}