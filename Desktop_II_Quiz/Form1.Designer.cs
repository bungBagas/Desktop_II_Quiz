namespace Desktop_II_Quiz
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
            linkLabel1 = new LinkLabel();
            button_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            username_txt = new TextBox();
            password_txt = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(337, 303);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button_login
            // 
            button_login.Location = new Point(121, 265);
            button_login.Name = "button_login";
            button_login.Size = new Size(311, 23);
            button_login.TabIndex = 1;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 56);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 2;
            label1.Text = "QuizinAja";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 93);
            label2.Name = "label2";
            label2.Size = new Size(209, 15);
            label2.TabIndex = 3;
            label2.Text = "Infinite Learning. Learn Without Limits";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 126);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 180);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(321, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 303);
            label5.Name = "label5";
            label5.Size = new Size(216, 15);
            label5.TabIndex = 9;
            label5.Text = "Don't have an account? Create Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 334);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 10;
            label6.Text = "or";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(231, 362);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(99, 15);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Join quiz as guest";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // username_txt
            // 
            username_txt.Location = new Point(118, 154);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(311, 23);
            username_txt.TabIndex = 12;
            username_txt.TextChanged += username_txt_TextChanged;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(118, 200);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(311, 23);
            password_txt.TabIndex = 13;
            password_txt.UseSystemPasswordChar = true;
            password_txt.TextChanged += password_txt_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 446);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_login);
            Controls.Add(linkLabel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button button_login;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel2;
        private TextBox username_txt;
        private TextBox password_txt;
    }
}
