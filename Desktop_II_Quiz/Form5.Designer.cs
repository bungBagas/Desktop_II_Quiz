namespace Desktop_II_Quiz
{
    partial class Form5
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            correctlbl = new Label();
            label5 = new Label();
            lblfill_timetaken = new Label();
            correctlbl_txt = new Label();
            participant_count = new Label();
            listcombobox = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "View Quiz Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 57);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Quiz";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 314);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail Data ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(764, 287);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 57);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 4;
            label3.Text = "Average Time Taken :";
            // 
            // correctlbl
            // 
            correctlbl.AutoSize = true;
            correctlbl.Location = new Point(326, 72);
            correctlbl.Name = "correctlbl";
            correctlbl.Size = new Size(166, 15);
            correctlbl.TabIndex = 5;
            correctlbl.Text = "Average Connect Percentage :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 87);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 6;
            label5.Text = "Total Participant :";
            // 
            // lblfill_timetaken
            // 
            lblfill_timetaken.AutoSize = true;
            lblfill_timetaken.Location = new Point(441, 57);
            lblfill_timetaken.Name = "lblfill_timetaken";
            lblfill_timetaken.Size = new Size(16, 15);
            lblfill_timetaken.TabIndex = 7;
            lblfill_timetaken.Text = "...";
            // 
            // correctlbl_txt
            // 
            correctlbl_txt.AutoSize = true;
            correctlbl_txt.Location = new Point(489, 72);
            correctlbl_txt.Name = "correctlbl_txt";
            correctlbl_txt.Size = new Size(16, 15);
            correctlbl_txt.TabIndex = 8;
            correctlbl_txt.Text = "...";
            // 
            // participant_count
            // 
            participant_count.AutoSize = true;
            participant_count.Location = new Point(422, 88);
            participant_count.Name = "participant_count";
            participant_count.Size = new Size(16, 15);
            participant_count.TabIndex = 9;
            participant_count.Text = "...";
            // 
            // listcombobox
            // 
            listcombobox.FormattingEnabled = true;
            listcombobox.Location = new Point(47, 54);
            listcombobox.Name = "listcombobox";
            listcombobox.Size = new Size(177, 23);
            listcombobox.TabIndex = 10;
            listcombobox.SelectedIndexChanged += listcombobox_SelectedIndexChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listcombobox);
            Controls.Add(participant_count);
            Controls.Add(correctlbl_txt);
            Controls.Add(lblfill_timetaken);
            Controls.Add(label5);
            Controls.Add(correctlbl);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label correctlbl;
        private Label label5;
        private Label lblfill_timetaken;
        private Label correctlbl_txt;
        private Label participant_count;
        private DataGridView dataGridView1;
        private ComboBox listcombobox;
    }
}