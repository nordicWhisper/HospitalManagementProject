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
            dataGridView3 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
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
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 366);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Bill Reports";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(34, 104);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(676, 225);
            dataGridView3.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private DataGridView dataGridView3;
        private GroupBox groupBox4;
        private Label label39;
        private Button button4;
        private Button button5;
        private ComboBox comboBox6;
        private Label label40;
        private ComboBox comboBox2;
    }
}