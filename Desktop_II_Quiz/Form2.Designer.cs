namespace Desktop_II_Quiz
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            uname_txt = new TextBox();
            fname_txt = new TextBox();
            label4 = new Label();
            rpassword_txt = new TextBox();
            password_txt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            date = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            createbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.Click += Label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 60);
            label2.Name = "label2";
            label2.Size = new Size(293, 15);
            label2.TabIndex = 1;
            label2.Text = "Fill in below information to complete your registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 110);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // uname_txt
            // 
            uname_txt.Location = new Point(29, 128);
            uname_txt.Name = "uname_txt";
            uname_txt.Size = new Size(262, 23);
            uname_txt.TabIndex = 3;
            uname_txt.TextChanged += textBox1_TextChanged;
            // 
            // fname_txt
            // 
            fname_txt.Location = new Point(30, 178);
            fname_txt.Name = "fname_txt";
            fname_txt.Size = new Size(262, 23);
            fname_txt.TabIndex = 4;
            fname_txt.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 160);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Full Name";
            label4.Click += label4_Click;
            // 
            // rpassword_txt
            // 
            rpassword_txt.Location = new Point(351, 178);
            rpassword_txt.Name = "rpassword_txt";
            rpassword_txt.Size = new Size(260, 23);
            rpassword_txt.TabIndex = 6;
            rpassword_txt.TextChanged += textBox3_TextChanged;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(349, 128);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(262, 23);
            password_txt.TabIndex = 7;
            password_txt.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 110);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 160);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 9;
            label6.Text = "Retype Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 210);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 10;
            label7.Text = "Date of Birth";
            // 
            // date
            // 
            date.Location = new Point(33, 231);
            date.Name = "date";
            date.Size = new Size(259, 23);
            date.TabIndex = 11;
            date.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(390, 298);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 298);
            label8.Name = "label8";
            label8.Size = new Size(142, 15);
            label8.TabIndex = 14;
            label8.Text = "Already have an account?";
            // 
            // createbtn
            // 
            createbtn.Location = new Point(233, 267);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(214, 28);
            createbtn.TabIndex = 15;
            createbtn.Text = "Create Account";
            createbtn.UseVisualStyleBackColor = true;
            createbtn.Click += createbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createbtn);
            Controls.Add(label8);
            Controls.Add(linkLabel1);
            Controls.Add(date);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(password_txt);
            Controls.Add(rpassword_txt);
            Controls.Add(label4);
            Controls.Add(fname_txt);
            Controls.Add(uname_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox uname_txt;
        private TextBox fname_txt;
        private Label label4;
        private TextBox rpassword_txt;
        private TextBox password_txt;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker date;
        private LinkLabel linkLabel1;
        private Label label8;
        private Button createbtn;
    }
}