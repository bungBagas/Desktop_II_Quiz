namespace Desktop_II_Quiz
{
    partial class Form3
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
            fname_lbl = new Label();
            button1 = new Button();
            button2 = new Button();
            logoutbtn = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // fname_lbl
            // 
            fname_lbl.AutoSize = true;
            fname_lbl.Location = new Point(12, 41);
            fname_lbl.Name = "fname_lbl";
            fname_lbl.Size = new Size(16, 15);
            fname_lbl.TabIndex = 1;
            fname_lbl.Text = "...";
            fname_lbl.Click += fname_lbl_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 191);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 2;
            button1.Text = "Add Quiz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 220);
            button2.Name = "button2";
            button2.Size = new Size(117, 23);
            button2.TabIndex = 3;
            button2.Text = "View Quiz Report";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.Location = new Point(12, 336);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(117, 23);
            logoutbtn.TabIndex = 4;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 41);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Your Quiz";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete });
            dataGridView1.Location = new Point(135, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(653, 379);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(logoutbtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(fname_lbl);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label fname_lbl;
        private Button button1;
        private Button button2;
        private Button logoutbtn;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Delete;
    }
}