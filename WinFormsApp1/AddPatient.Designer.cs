namespace WinFormsApp1
{
    partial class AddPatient
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            button1 = new Button();
            comboBox4 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox10 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            textBox9 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 4;
            label1.Text = "ADD Doctor Detail";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 394);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ADD Patient Detail";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(389, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(373, 382);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Patient Admit Detail";
            // 
            // button1
            // 
            button1.Location = new Point(115, 251);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 26;
            button1.Text = "ADD Patient";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(115, 147);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(146, 23);
            comboBox4.TabIndex = 25;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(115, 111);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(146, 23);
            comboBox2.TabIndex = 24;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(115, 180);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(244, 23);
            textBox10.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 183);
            label16.Name = "label16";
            label16.Size = new Size(81, 15);
            label16.TabIndex = 22;
            label16.Text = "Estimated Bill:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 150);
            label15.Name = "label15";
            label15.Size = new Size(69, 15);
            label15.TabIndex = 21;
            label15.Text = "Room Type:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 114);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 20;
            label14.Text = "Handle By Doctor:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(115, 75);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(244, 23);
            textBox9.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 76);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 18;
            label13.Text = "Disease:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(115, 38);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(244, 23);
            textBox8.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 42);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 17;
            label12.Text = "Refer By Doctor:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD Patient Form";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(93, 251);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 23);
            textBox7.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(93, 217);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 12;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(150, 76);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(93, 76);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 254);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 9;
            label11.Text = "Pincode:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 220);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 8;
            label10.Text = "City:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 183);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 7;
            label9.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 150);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 6;
            label8.Text = "Mobile:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 5;
            label4.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 78);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Gender:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Patient Name:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 366);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Patient Reports";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSteelBlue;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 366);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete Records";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPatient";
            Text = "AddPatient";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
        private TextBox textBox10;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox textBox9;
        private Label label13;
        private TextBox textBox8;
        private Label label12;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label3;
    }
}