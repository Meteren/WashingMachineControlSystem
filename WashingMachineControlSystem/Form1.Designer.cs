namespace WashingMachineControlSystem
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
            dirtiness = new TextBox();
            sensitivity = new TextBox();
            belongingsAmount = new TextBox();
            rotationMamdanis = new ListBox();
            durationMamdanis = new ListBox();
            detergentMamdanis = new ListBox();
            rotationSpeedWAvarage = new TextBox();
            durationWAvarage = new TextBox();
            detergentWAvarage = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox7 = new GroupBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            d_lowText = new TextBox();
            d_mediumText = new TextBox();
            d_highText = new TextBox();
            groupBox6 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label12 = new Label();
            a_smallText = new TextBox();
            a_mediumText = new TextBox();
            a_largeText = new TextBox();
            groupBox5 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label6 = new Label();
            s_robustText = new TextBox();
            s_mediumText = new TextBox();
            s_sensitiveText = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dirtiness
            // 
            dirtiness.Location = new Point(113, 136);
            dirtiness.Name = "dirtiness";
            dirtiness.Size = new Size(112, 27);
            dirtiness.TabIndex = 0;
            // 
            // sensitivity
            // 
            sensitivity.Location = new Point(113, 38);
            sensitivity.Name = "sensitivity";
            sensitivity.Size = new Size(112, 27);
            sensitivity.TabIndex = 2;
            // 
            // belongingsAmount
            // 
            belongingsAmount.Location = new Point(113, 85);
            belongingsAmount.Name = "belongingsAmount";
            belongingsAmount.Size = new Size(112, 27);
            belongingsAmount.TabIndex = 3;
            // 
            // rotationMamdanis
            // 
            rotationMamdanis.FormattingEnabled = true;
            rotationMamdanis.Location = new Point(33, 255);
            rotationMamdanis.Name = "rotationMamdanis";
            rotationMamdanis.Size = new Size(214, 144);
            rotationMamdanis.TabIndex = 7;
            // 
            // durationMamdanis
            // 
            durationMamdanis.FormattingEnabled = true;
            durationMamdanis.Location = new Point(36, 61);
            durationMamdanis.Name = "durationMamdanis";
            durationMamdanis.Size = new Size(211, 144);
            durationMamdanis.TabIndex = 8;
            // 
            // detergentMamdanis
            // 
            detergentMamdanis.FormattingEnabled = true;
            detergentMamdanis.Location = new Point(31, 443);
            detergentMamdanis.Name = "detergentMamdanis";
            detergentMamdanis.Size = new Size(216, 144);
            detergentMamdanis.TabIndex = 9;
            // 
            // rotationSpeedWAvarage
            // 
            rotationSpeedWAvarage.Location = new Point(118, 85);
            rotationSpeedWAvarage.Name = "rotationSpeedWAvarage";
            rotationSpeedWAvarage.Size = new Size(107, 27);
            rotationSpeedWAvarage.TabIndex = 13;
            // 
            // durationWAvarage
            // 
            durationWAvarage.Location = new Point(118, 133);
            durationWAvarage.Name = "durationWAvarage";
            durationWAvarage.Size = new Size(107, 27);
            durationWAvarage.TabIndex = 14;
            // 
            // detergentWAvarage
            // 
            detergentWAvarage.Location = new Point(118, 38);
            detergentWAvarage.Name = "detergentWAvarage";
            detergentWAvarage.Size = new Size(107, 27);
            detergentWAvarage.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(167, 3);
            button1.Name = "button1";
            button1.Size = new Size(80, 29);
            button1.TabIndex = 19;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += calculate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(674, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 847);
            dataGridView1.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(sensitivity);
            groupBox1.Controls.Add(belongingsAmount);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dirtiness);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(38, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 174);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Inputs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 24;
            label3.Text = "Dirtiness  =>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 23;
            label2.Text = "Amount   =>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 22;
            label1.Text = "Sensitivity =>";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(groupBox7);
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(23, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 617);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fuzzification Values";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.ActiveCaption;
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(label15);
            groupBox7.Controls.Add(d_lowText);
            groupBox7.Controls.Add(d_mediumText);
            groupBox7.Controls.Add(d_highText);
            groupBox7.Location = new Point(20, 419);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(250, 169);
            groupBox7.TabIndex = 33;
            groupBox7.TabStop = false;
            groupBox7.Text = "Dirtiness";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 122);
            label13.Name = "label13";
            label13.Size = new Size(68, 20);
            label13.TabIndex = 30;
            label13.Text = "High =>";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 75);
            label14.Name = "label14";
            label14.Size = new Size(93, 20);
            label14.TabIndex = 29;
            label14.Text = "Medium =>";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 29);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 28;
            label15.Text = "Low  =>";
            // 
            // d_lowText
            // 
            d_lowText.Location = new Point(107, 26);
            d_lowText.Name = "d_lowText";
            d_lowText.Size = new Size(112, 27);
            d_lowText.TabIndex = 2;
            // 
            // d_mediumText
            // 
            d_mediumText.Location = new Point(107, 72);
            d_mediumText.Name = "d_mediumText";
            d_mediumText.Size = new Size(112, 27);
            d_mediumText.TabIndex = 26;
            // 
            // d_highText
            // 
            d_highText.Location = new Point(107, 119);
            d_highText.Name = "d_highText";
            d_highText.Size = new Size(112, 27);
            d_highText.TabIndex = 27;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ActiveCaption;
            groupBox6.Controls.Add(label4);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(label12);
            groupBox6.Controls.Add(a_smallText);
            groupBox6.Controls.Add(a_mediumText);
            groupBox6.Controls.Add(a_largeText);
            groupBox6.Location = new Point(18, 232);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(250, 169);
            groupBox6.TabIndex = 33;
            groupBox6.TabStop = false;
            groupBox6.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 122);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 30;
            label4.Text = "Large =>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 75);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 29;
            label5.Text = "Medium =>";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 29);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 28;
            label12.Text = "Small  =>";
            // 
            // a_smallText
            // 
            a_smallText.Location = new Point(107, 26);
            a_smallText.Name = "a_smallText";
            a_smallText.Size = new Size(112, 27);
            a_smallText.TabIndex = 2;
            // 
            // a_mediumText
            // 
            a_mediumText.Location = new Point(107, 72);
            a_mediumText.Name = "a_mediumText";
            a_mediumText.Size = new Size(112, 27);
            a_mediumText.TabIndex = 26;
            // 
            // a_largeText
            // 
            a_largeText.Location = new Point(107, 119);
            a_largeText.Name = "a_largeText";
            a_largeText.Size = new Size(112, 27);
            a_largeText.TabIndex = 27;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ActiveCaption;
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(s_robustText);
            groupBox5.Controls.Add(s_mediumText);
            groupBox5.Controls.Add(s_sensitiveText);
            groupBox5.Location = new Point(18, 41);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 169);
            groupBox5.TabIndex = 32;
            groupBox5.TabStop = false;
            groupBox5.Text = "Sensitivity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 122);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 30;
            label11.Text = "Sensitive =>";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 75);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 29;
            label10.Text = "Medium =>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 29);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 28;
            label6.Text = "Robust  =>";
            // 
            // s_robustText
            // 
            s_robustText.Location = new Point(107, 26);
            s_robustText.Name = "s_robustText";
            s_robustText.Size = new Size(112, 27);
            s_robustText.TabIndex = 2;
            // 
            // s_mediumText
            // 
            s_mediumText.Location = new Point(107, 72);
            s_mediumText.Name = "s_mediumText";
            s_mediumText.Size = new Size(112, 27);
            s_mediumText.TabIndex = 26;
            // 
            // s_sensitiveText
            // 
            s_sensitiveText.Location = new Point(107, 119);
            s_sensitiveText.Name = "s_sensitiveText";
            s_sensitiveText.Size = new Size(112, 27);
            s_sensitiveText.TabIndex = 27;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientActiveCaption;
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(detergentWAvarage);
            groupBox3.Controls.Add(rotationSpeedWAvarage);
            groupBox3.Controls.Add(durationWAvarage);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(356, 688);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(258, 174);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Weighted Avarages";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 136);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 24;
            label7.Text = "Duration   =>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 88);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 23;
            label8.Text = "RSpeed    =>";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 41);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 22;
            label9.Text = "Detergent =>";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientActiveCaption;
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(durationMamdanis);
            groupBox4.Controls.Add(rotationMamdanis);
            groupBox4.Controls.Add(detergentMamdanis);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(341, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(286, 617);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mamdani Values";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(27, 420);
            label18.Name = "label18";
            label18.Size = new Size(161, 20);
            label18.TabIndex = 12;
            label18.Text = "Detergent Mamdanis:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(31, 232);
            label17.Name = "label17";
            label17.Size = new Size(197, 20);
            label17.TabIndex = 11;
            label17.Text = "Rotation Speed Mamdanis:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(33, 38);
            label16.Name = "label16";
            label16.Size = new Size(152, 20);
            label16.TabIndex = 10;
            label16.Text = "Duration Mamdanis:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1446, 921);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox dirtiness;
        private TextBox sensitivity;
        private TextBox belongingsAmount;
        private ListBox rotationMamdanis;
        private ListBox durationMamdanis;
        private ListBox detergentMamdanis;
        private TextBox rotationSpeedWAvarage;
        private TextBox durationWAvarage;
        private TextBox detergentWAvarage;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox s_robustText;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox s_mediumText;
        private TextBox s_sensitiveText;
        private Label label11;
        private Label label10;
        private Label label6;
        private GroupBox groupBox7;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox d_lowText;
        private TextBox d_mediumText;
        private TextBox d_highText;
        private GroupBox groupBox6;
        private Label label4;
        private Label label5;
        private Label label12;
        private TextBox a_smallText;
        private TextBox a_mediumText;
        private TextBox a_largeText;
        private Label label16;
        private Label label18;
        private Label label17;
    }
}
