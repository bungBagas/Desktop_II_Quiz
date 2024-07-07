namespace Desktop_II_Quiz
{
    partial class Form7
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
            nicknme_lbl = new Label();
            time_lbl = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            timerlbl = new Label();
            questlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // nicknme_lbl
            // 
            nicknme_lbl.AutoSize = true;
            nicknme_lbl.Location = new Point(21, 20);
            nicknme_lbl.Name = "nicknme_lbl";
            nicknme_lbl.Size = new Size(38, 15);
            nicknme_lbl.TabIndex = 0;
            nicknme_lbl.Text = "label1";
            // 
            // time_lbl
            // 
            time_lbl.AutoSize = true;
            time_lbl.Location = new Point(22, 46);
            time_lbl.Name = "time_lbl";
            time_lbl.Size = new Size(82, 15);
            time_lbl.TabIndex = 1;
            time_lbl.Text = "Time elapsed :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 299);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(307, 29);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(481, 409);
            dataGridView2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 117);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Question List";
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // timerlbl
            // 
            timerlbl.AutoSize = true;
            timerlbl.Location = new Point(101, 46);
            timerlbl.Name = "timerlbl";
            timerlbl.Size = new Size(31, 15);
            timerlbl.TabIndex = 5;
            timerlbl.Text = "0:0:0";
            timerlbl.Click += label2_Click;
            // 
            // questlbl
            // 
            questlbl.AutoSize = true;
            questlbl.Location = new Point(398, 70);
            questlbl.Name = "questlbl";
            questlbl.Size = new Size(38, 15);
            questlbl.TabIndex = 6;
            questlbl.Text = "label2";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(questlbl);
            Controls.Add(timerlbl);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(time_lbl);
            Controls.Add(nicknme_lbl);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nicknme_lbl;
        private Label time_lbl;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private System.Windows.Forms.Timer Timer;
        private Label timerlbl;
        private Label questlbl;
    }
}