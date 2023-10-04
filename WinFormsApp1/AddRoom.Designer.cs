namespace WinFormsApp1
{
    partial class AddRoom
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataBaseConnectorBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaseConnectorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(301, 21);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 0;
            label1.Text = "ADD Room Detail";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(59, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(692, 340);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(684, 312);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ADD Rooms";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(98, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD Rooms Form";
            // 
            // button1
            // 
            button1.Location = new Point(140, 160);
            button1.Name = "button1";
            button1.Size = new Size(103, 24);
            button1.TabIndex = 6;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(102, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(102, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 122);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "Rate / Day:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 84);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "Total Room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 44);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 0;
            label2.Text = "Room Type:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(684, 312);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Room Reports";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 256);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSteelBlue;
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(684, 312);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Edit Room Detail";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(104, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(477, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ADD Rooms Form";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(238, 23);
            comboBox1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(282, 160);
            button3.Name = "button3";
            button3.Size = new Size(103, 24);
            button3.TabIndex = 7;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(140, 160);
            button2.Name = "button2";
            button2.Size = new Size(103, 24);
            button2.TabIndex = 6;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(147, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(102, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(147, 81);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(102, 23);
            textBox5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 122);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 2;
            label5.Text = "Rate / Day:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 84);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 1;
            label6.Text = "Total Room:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 44);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 0;
            label7.Text = "Room Type:";
            // 
            // dataBaseConnectorBindingSource
            // 
            dataBaseConnectorBindingSource.DataSource = typeof(DataBaseConnector);
            // 
            // AddRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRoom";
            Text = "AddRoom";
            Load += AddRoom_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaseConnectorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private Label label7;
        private BindingSource dataBaseConnectorBindingSource;
        private DataGridView dataGridView1;
    }
}