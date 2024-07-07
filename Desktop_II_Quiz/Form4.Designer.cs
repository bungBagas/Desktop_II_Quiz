namespace Desktop_II_Quiz
{
    partial class Form4
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
            label4 = new Label();
            qCode_txt = new TextBox();
            optB_radio = new GroupBox();
            optD_txt = new TextBox();
            optC_txt = new TextBox();
            optB_txt = new TextBox();
            optA_txt = new TextBox();
            question_txt = new TextBox();
            dataGridViewques = new DataGridView();
            button1 = new Button();
            optD_radio = new RadioButton();
            optC_radio = new RadioButton();
            optiB_radio = new RadioButton();
            optA_radio = new RadioButton();
            label6 = new Label();
            savebtn = new Button();
            Cncelbtn = new Button();
            qDescription_txt = new TextBox();
            label5 = new Label();
            quiznm_txt = new TextBox();
            Question = new DataGridViewTextBoxColumn();
            OptionA = new DataGridViewTextBoxColumn();
            OptionB = new DataGridViewTextBoxColumn();
            OptionC = new DataGridViewTextBoxColumn();
            OptionD = new DataGridViewTextBoxColumn();
            Correct = new DataGridViewTextBoxColumn();
            optB_radio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewques).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 0;
            label1.Text = "Add New Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 53);
            label2.Name = "label2";
            label2.Size = new Size(147, 13);
            label2.TabIndex = 1;
            label2.Text = "Fill in the quiz detail below";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 84);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Quiz Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 128);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Quiz Code";
            label4.UseWaitCursor = true;
            // 
            // qCode_txt
            // 
            qCode_txt.BackColor = SystemColors.Control;
            qCode_txt.Location = new Point(17, 146);
            qCode_txt.Name = "qCode_txt";
            qCode_txt.Size = new Size(276, 23);
            qCode_txt.TabIndex = 5;
            // 
            // optB_radio
            // 
            optB_radio.Controls.Add(optD_txt);
            optB_radio.Controls.Add(optC_txt);
            optB_radio.Controls.Add(optB_txt);
            optB_radio.Controls.Add(optA_txt);
            optB_radio.Controls.Add(question_txt);
            optB_radio.Controls.Add(dataGridViewques);
            optB_radio.Controls.Add(button1);
            optB_radio.Controls.Add(optD_radio);
            optB_radio.Controls.Add(optC_radio);
            optB_radio.Controls.Add(optiB_radio);
            optB_radio.Controls.Add(optA_radio);
            optB_radio.Controls.Add(label6);
            optB_radio.Location = new Point(17, 188);
            optB_radio.Name = "optB_radio";
            optB_radio.Size = new Size(771, 276);
            optB_radio.TabIndex = 6;
            optB_radio.TabStop = false;
            optB_radio.Text = "Question Data ";
            optB_radio.Enter += groupBox1_Enter;
            // 
            // optD_txt
            // 
            optD_txt.Location = new Point(350, 114);
            optD_txt.Name = "optD_txt";
            optD_txt.Size = new Size(100, 23);
            optD_txt.TabIndex = 13;
            optD_txt.Text = "oD";
            // 
            // optC_txt
            // 
            optC_txt.Location = new Point(350, 93);
            optC_txt.Name = "optC_txt";
            optC_txt.Size = new Size(100, 23);
            optC_txt.TabIndex = 12;
            optC_txt.Text = "oC";
            // 
            // optB_txt
            // 
            optB_txt.Location = new Point(350, 64);
            optB_txt.Name = "optB_txt";
            optB_txt.Size = new Size(100, 23);
            optB_txt.TabIndex = 11;
            optB_txt.Text = "oB";
            // 
            // optA_txt
            // 
            optA_txt.Location = new Point(350, 41);
            optA_txt.Name = "optA_txt";
            optA_txt.Size = new Size(100, 23);
            optA_txt.TabIndex = 10;
            optA_txt.Text = "qA";
            optA_txt.TextChanged += optA_txt_TextChanged;
            // 
            // question_txt
            // 
            question_txt.Location = new Point(16, 42);
            question_txt.Multiline = true;
            question_txt.Name = "question_txt";
            question_txt.Size = new Size(260, 82);
            question_txt.TabIndex = 9;
            question_txt.TextChanged += question_txt_TextChanged;
            // 
            // dataGridViewques
            // 
            dataGridViewques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewques.Columns.AddRange(new DataGridViewColumn[] { Question, OptionA, OptionB, OptionC, OptionD, Correct });
            dataGridViewques.Location = new Point(6, 143);
            dataGridViewques.Name = "dataGridViewques";
            dataGridViewques.RowTemplate.Height = 25;
            dataGridViewques.Size = new Size(759, 127);
            dataGridViewques.TabIndex = 8;
            dataGridViewques.CellContentClick += dataGridViewques_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(453, 51);
            button1.Name = "button1";
            button1.Size = new Size(93, 25);
            button1.TabIndex = 7;
            button1.Text = "Add Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // optD_radio
            // 
            optD_radio.AutoSize = true;
            optD_radio.Location = new Point(330, 118);
            optD_radio.Name = "optD_radio";
            optD_radio.Size = new Size(14, 13);
            optD_radio.TabIndex = 6;
            optD_radio.TabStop = true;
            optD_radio.UseVisualStyleBackColor = true;
            // 
            // optC_radio
            // 
            optC_radio.AutoSize = true;
            optC_radio.Location = new Point(330, 97);
            optC_radio.Name = "optC_radio";
            optC_radio.Size = new Size(14, 13);
            optC_radio.TabIndex = 5;
            optC_radio.TabStop = true;
            optC_radio.UseVisualStyleBackColor = true;
            // 
            // optiB_radio
            // 
            optiB_radio.AutoSize = true;
            optiB_radio.Location = new Point(330, 74);
            optiB_radio.Name = "optiB_radio";
            optiB_radio.Size = new Size(14, 13);
            optiB_radio.TabIndex = 4;
            optiB_radio.TabStop = true;
            optiB_radio.UseVisualStyleBackColor = true;
            // 
            // optA_radio
            // 
            optA_radio.AutoSize = true;
            optA_radio.Location = new Point(330, 46);
            optA_radio.Name = "optA_radio";
            optA_radio.Size = new Size(14, 13);
            optA_radio.TabIndex = 3;
            optA_radio.TabStop = true;
            optA_radio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 23);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 1;
            label6.Text = "Question";
            // 
            // savebtn
            // 
            savebtn.Location = new Point(626, 470);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 7;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // Cncelbtn
            // 
            Cncelbtn.Location = new Point(707, 470);
            Cncelbtn.Name = "Cncelbtn";
            Cncelbtn.Size = new Size(75, 23);
            Cncelbtn.TabIndex = 8;
            Cncelbtn.Text = "Cancel";
            Cncelbtn.UseVisualStyleBackColor = true;
            Cncelbtn.Click += Cncelbtn_Click;
            // 
            // qDescription_txt
            // 
            qDescription_txt.Location = new Point(335, 102);
            qDescription_txt.Multiline = true;
            qDescription_txt.Name = "qDescription_txt";
            qDescription_txt.ScrollBars = ScrollBars.Vertical;
            qDescription_txt.Size = new Size(432, 67);
            qDescription_txt.TabIndex = 9;
            qDescription_txt.Text = "Some Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 84);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 10;
            label5.Text = "Quiz Description";
            // 
            // quiznm_txt
            // 
            quiznm_txt.Location = new Point(17, 102);
            quiznm_txt.Multiline = true;
            quiznm_txt.Name = "quiznm_txt";
            quiznm_txt.Size = new Size(276, 23);
            quiznm_txt.TabIndex = 4;
            quiznm_txt.TextChanged += textBox1_TextChanged;
            // 
            // Question
            // 
            Question.HeaderText = "Question";
            Question.Name = "Question";
            // 
            // OptionA
            // 
            OptionA.HeaderText = "OptionA";
            OptionA.Name = "OptionA";
            // 
            // OptionB
            // 
            OptionB.HeaderText = "OptionB";
            OptionB.Name = "OptionB";
            // 
            // OptionC
            // 
            OptionC.HeaderText = "OptionC";
            OptionC.Name = "OptionC";
            // 
            // OptionD
            // 
            OptionD.HeaderText = "OptionD";
            OptionD.Name = "OptionD";
            // 
            // Correct
            // 
            Correct.HeaderText = "CorrectAnswer";
            Correct.Name = "Correct";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(label5);
            Controls.Add(qDescription_txt);
            Controls.Add(Cncelbtn);
            Controls.Add(savebtn);
            Controls.Add(optB_radio);
            Controls.Add(qCode_txt);
            Controls.Add(quiznm_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            optB_radio.ResumeLayout(false);
            optB_radio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewques).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox qCode_txt;
        private GroupBox optB_radio;
        private Button savebtn;
        private Button Cncelbtn;
        private TextBox qDescription_txt;
        private Label label5;
        private Button button1;
        private RadioButton optD_radio;
        private RadioButton optC_radio;
        private RadioButton optiB_radio;
        private RadioButton optA_radio;
        private Label label6;
        private DataGridView dataGridViewques;
        private TextBox question_txt;
        private TextBox optB_txt;
        private TextBox optA_txt;
        private TextBox optD_txt;
        private TextBox optC_txt;
        private TextBox quiznm_txt;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn OptionA;
        private DataGridViewTextBoxColumn OptionB;
        private DataGridViewTextBoxColumn OptionC;
        private DataGridViewTextBoxColumn OptionD;
        private DataGridViewTextBoxColumn Correct;
    }
}