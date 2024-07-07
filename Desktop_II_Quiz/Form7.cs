using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Desktop_II_Quiz
{
    public partial class Form7 : Form
    {
        private string quizcode;
        private string nickname;
        private int quizId;

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KUCJLI3S\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuizinAJa4");
        public Form7()
        {
            InitializeComponent();

        }
        public void Shownickname(String nickname, String code, int quizId)
        {
            this.nickname = nickname;
            this.quizcode = code;
            this.quizId = quizId;
           nicknme_lbl.Text = nickname;
            LoadQuestion();

        }
            
        private void LoadQuestion()
        {
            List<string> question = new List<string>();

            string query = "Select*from Question where QuizID = (Select*from Quiz where ID = @ID )";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", quizId);

            try
            {
                conn.Open();
                SqlDataReader readquest = cmd.ExecuteReader();

                while (readquest.Read())
                {
                    question.Add(readquest["Question"].ToString());
                }
                readquest.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

            int startY = 10;
            int spacing = 30;

            for (int i = 0; i<question.Count; i++)
            {
                Label questionLabel = new Label
                {
                    Text = question[i],
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, startY + (i * spacing)),
                };
                this.Controls.Add(questionLabel);
            }
        }
        
        private void Form7_Load(object sender, EventArgs e)
        {
            Timer.Start();
            
        }

        private void question(int QuizID)
        {
            //string query = "SELECT Question FROM Question where QuizID=3 ";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //cmd.Parameters.AddWithValue("@QuizID", QuizID);
            //conn.Open();
            //if(reader.Read())
            //{
            //    quest_txt.Text = reader["Question"].ToString();
            //}
            //conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int Hour;
        int Minute;
        int Second;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Second <= 60)
            {
                Second += 1;
                timerlbl.Text = Hour + ":" + Minute + ":" + Second;
            }
            if (Second > 60)
            {
                Second = 0;
                Minute += 1;
                timerlbl.Text = Hour + ":" + Minute + ":" + Second;
            }
            if (Minute > 60)
            {
                Minute = 0;
                Hour += 1;
                timerlbl.Text = Hour + ":" + Minute + ":" + Second;
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
