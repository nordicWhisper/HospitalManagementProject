namespace WinFormsApp1
{
    partial class Bill
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
            tabPage2 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label7 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            tabPage3 = new TabPage();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            label27 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label50 = new Label();
            label49 = new Label();
            label48 = new Label();
            label47 = new Label();
            label46 = new Label();
            label45 = new Label();
            label44 = new Label();
            label43 = new Label();
            label42 = new Label();
            label41 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            groupBox4 = new GroupBox();
            comboBox2 = new ComboBox();
            label39 = new Label();
            button4 = new Button();
            button5 = new Button();
            comboBox6 = new ComboBox();
            label40 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 5;
            label1.Text = "ADD Bill Detail";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 394);
            tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 366);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ADD Patient Bill";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 90);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 10;
            label3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 90);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 9;
            label2.Text = "Total Result:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(756, 246);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(42, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(676, 65);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Patient Bill";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 29);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 6;
            label7.Text = "Mobile:";
            // 
            // button3
            // 
            button3.Location = new Point(549, 26);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "SELECT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 1;
            label6.Text = "Patient Name:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSteelBlue;
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 366);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bill Reports";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(0, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(769, 287);
            panel4.TabIndex = 4;
            panel4.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MintCream;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label27);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(774, 121);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(498, 78);
            panel6.Name = "panel6";
            panel6.Size = new Size(81, 2);
            panel6.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(34, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(737, 4);
            panel5.TabIndex = 47;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(532, 83);
            label27.Name = "label27";
            label27.Size = new Size(47, 15);
            label27.TabIndex = 46;
            label27.Text = "label27";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(532, 53);
            label16.Name = "label16";
            label16.Size = new Size(47, 15);
            label16.TabIndex = 45;
            label16.Text = "label16";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Green;
            label15.Location = new Point(532, 24);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 44;
            label15.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(237, 83);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 43;
            label14.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(237, 53);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 42;
            label13.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(237, 24);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 41;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(464, 83);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 40;
            label11.Text = "Total Bill =";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(432, 53);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 39;
            label10.Text = "Remaining Bill =";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(463, 24);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 38;
            label9.Text = "Paid Bill = ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(153, 83);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 37;
            label8.Text = "Medicine Bill:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(166, 53);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 36;
            label5.Text = "Doctor Bill:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(170, 24);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 35;
            label4.Text = "Room Bill:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(31, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 8);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(label50);
            panel1.Controls.Add(label49);
            panel1.Controls.Add(label48);
            panel1.Controls.Add(label47);
            panel1.Controls.Add(label46);
            panel1.Controls.Add(label45);
            panel1.Controls.Add(label44);
            panel1.Controls.Add(label43);
            panel1.Controls.Add(label42);
            panel1.Controls.Add(label41);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(0, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 159);
            panel1.TabIndex = 3;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(573, 117);
            label50.Name = "label50";
            label50.Size = new Size(44, 15);
            label50.TabIndex = 34;
            label50.Text = "label50";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(573, 89);
            label49.Name = "label49";
            label49.Size = new Size(44, 15);
            label49.TabIndex = 33;
            label49.Text = "label49";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(573, 61);
            label48.Name = "label48";
            label48.Size = new Size(44, 15);
            label48.TabIndex = 32;
            label48.Text = "label48";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(573, 36);
            label47.Name = "label47";
            label47.Size = new Size(44, 15);
            label47.TabIndex = 31;
            label47.Text = "label47";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(573, 9);
            label46.Name = "label46";
            label46.Size = new Size(44, 15);
            label46.TabIndex = 30;
            label46.Text = "label46";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(166, 117);
            label45.Name = "label45";
            label45.Size = new Size(44, 15);
            label45.TabIndex = 29;
            label45.Text = "label45";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(166, 89);
            label44.Name = "label44";
            label44.Size = new Size(44, 15);
            label44.TabIndex = 28;
            label44.Text = "label44";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(166, 61);
            label43.Name = "label43";
            label43.Size = new Size(44, 15);
            label43.TabIndex = 27;
            label43.Text = "label43";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(166, 36);
            label42.Name = "label42";
            label42.Size = new Size(44, 15);
            label42.TabIndex = 26;
            label42.Text = "label42";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(166, 9);
            label41.Name = "label41";
            label41.Size = new Size(44, 15);
            label41.TabIndex = 25;
            label41.Text = "label41";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(486, 117);
            label26.Name = "label26";
            label26.Size = new Size(81, 15);
            label26.TabIndex = 9;
            label26.Text = "Estimated Bill:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(498, 89);
            label25.Name = "label25";
            label25.Size = new Size(69, 15);
            label25.TabIndex = 8;
            label25.Text = "Room Type:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(464, 61);
            label24.Name = "label24";
            label24.Size = new Size(103, 15);
            label24.TabIndex = 7;
            label24.Text = "Handle By Doctor:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(518, 36);
            label23.Name = "label23";
            label23.Size = new Size(49, 15);
            label23.TabIndex = 6;
            label23.Text = "Disease:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(475, 9);
            label22.Name = "label22";
            label22.Size = new Size(92, 15);
            label22.TabIndex = 5;
            label22.Text = "Refer By Doctor:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(99, 117);
            label21.Name = "label21";
            label21.Size = new Size(53, 15);
            label21.TabIndex = 4;
            label21.Text = "Pincode:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(121, 89);
            label20.Name = "label20";
            label20.Size = new Size(31, 15);
            label20.TabIndex = 3;
            label20.Text = "City:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(100, 61);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 2;
            label19.Text = "Address:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(86, 36);
            label18.Name = "label18";
            label18.Size = new Size(66, 15);
            label18.TabIndex = 1;
            label18.Text = "Mobile No:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(70, 9);
            label17.Name = "label17";
            label17.Size = new Size(82, 15);
            label17.TabIndex = 0;
            label17.Text = "Patient Name:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(label39);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(comboBox6);
            groupBox4.Controls.Add(label40);
            groupBox4.Location = new Point(34, 17);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(676, 65);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Patient Bill Reports";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(452, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(385, 30);
            label39.Name = "label39";
            label39.Size = new Size(61, 15);
            label39.TabIndex = 6;
            label39.Text = "Bill Status:";
            // 
            // button4
            // 
            button4.Location = new Point(579, 26);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "SELECT";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(218, 26);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 3;
            button5.Text = "SELECT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(91, 26);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 2;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(6, 29);
            label40.Name = "label40";
            label40.Size = new Size(82, 15);
            label40.TabIndex = 1;
            label40.Text = "Patient Name:";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill";
            Text = "Bill";
            Load += Bill_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label7;
        private Button button3;
        private ComboBox comboBox1;
        private Label label6;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private Label label39;
        private Button button4;
        private Button button5;
        private ComboBox comboBox6;
        private Label label40;
        private ComboBox comboBox2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private Label label45;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Panel panel5;
        private Label label27;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label4;
        private Panel panel6;
    }
}