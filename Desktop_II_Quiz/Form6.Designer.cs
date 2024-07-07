namespace Desktop_II_Quiz
{
    partial class Form6
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
            qcode_txt = new TextBox();
            nick_label = new Label();
            nick_txt = new TextBox();
            joinbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 51);
            label1.Name = "label1";
            label1.Size = new Size(331, 50);
            label1.TabIndex = 0;
            label1.Text = "Enter Quiz Code : ";
            label1.Click += label1_Click;
            // 
            // qcode_txt
            // 
            qcode_txt.Location = new Point(33, 124);
            qcode_txt.Multiline = true;
            qcode_txt.Name = "qcode_txt";
            qcode_txt.Size = new Size(352, 42);
            qcode_txt.TabIndex = 1;
            qcode_txt.TextChanged += qcode_txt_TextChanged;
            // 
            // nick_label
            // 
            nick_label.AutoSize = true;
            nick_label.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            nick_label.Location = new Point(53, 196);
            nick_label.Name = "nick_label";
            nick_label.Size = new Size(307, 50);
            nick_label.TabIndex = 2;
            nick_label.Text = "Enter Nickname :";
            // 
            // nick_txt
            // 
            nick_txt.Location = new Point(33, 259);
            nick_txt.Multiline = true;
            nick_txt.Name = "nick_txt";
            nick_txt.Size = new Size(352, 40);
            nick_txt.TabIndex = 3;
            // 
            // joinbtn
            // 
            joinbtn.Location = new Point(34, 316);
            joinbtn.Name = "joinbtn";
            joinbtn.Size = new Size(351, 40);
            joinbtn.TabIndex = 4;
            joinbtn.Text = "Join";
            joinbtn.UseVisualStyleBackColor = true;
            joinbtn.Click += joinbtn_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 379);
            Controls.Add(joinbtn);
            Controls.Add(nick_txt);
            Controls.Add(nick_label);
            Controls.Add(qcode_txt);
            Controls.Add(label1);
            Name = "Form6";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox qcode_txt;
        private Label nick_label;
        private TextBox nick_txt;
        private Button joinbtn;
    }
}