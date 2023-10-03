namespace WinFormsApp1
{
    partial class DashboardForm
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
            panel1 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 682);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.BackColor = Color.LightBlue;
            button9.Location = new Point(13, 444);
            button9.Name = "button9";
            button9.Size = new Size(197, 48);
            button9.TabIndex = 8;
            button9.Text = "EXIT";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightBlue;
            button8.Location = new Point(13, 390);
            button8.Name = "button8";
            button8.Size = new Size(197, 48);
            button8.TabIndex = 7;
            button8.Text = "LOG OUT";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightBlue;
            button7.Location = new Point(13, 336);
            button7.Name = "button7";
            button7.Size = new Size(197, 48);
            button7.TabIndex = 6;
            button7.Text = "ADMIN / REPORTS";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightBlue;
            button6.Location = new Point(13, 282);
            button6.Name = "button6";
            button6.Size = new Size(197, 48);
            button6.TabIndex = 5;
            button6.Text = "PAYMENT";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightBlue;
            button5.Location = new Point(13, 228);
            button5.Name = "button5";
            button5.Size = new Size(197, 48);
            button5.TabIndex = 4;
            button5.Text = "BILL";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightBlue;
            button4.Location = new Point(13, 174);
            button4.Name = "button4";
            button4.Size = new Size(197, 48);
            button4.TabIndex = 3;
            button4.Text = "ADD PATIENT";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightBlue;
            button3.Location = new Point(13, 120);
            button3.Name = "button3";
            button3.Size = new Size(197, 48);
            button3.TabIndex = 2;
            button3.Text = "ADD DOCTOR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Location = new Point(13, 66);
            button2.Name = "button2";
            button2.Size = new Size(197, 48);
            button2.TabIndex = 1;
            button2.Text = "ADD ROOM";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Location = new Point(13, 12);
            button1.Name = "button1";
            button1.Size = new Size(197, 48);
            button1.TabIndex = 0;
            button1.Text = "HOME";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Location = new Point(218, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 682);
            panel2.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}