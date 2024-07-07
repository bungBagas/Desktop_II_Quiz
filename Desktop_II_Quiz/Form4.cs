using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desktop_II_Quiz
{
    public partial class Form4 : Form
    {
      
        public Form4()
        {
            InitializeComponent();
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KUCJLI3S\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuizinAja4");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void id(DataTable dt)
        {
           
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
           
            string code = qCode_txt.Text;
            if (!System.Text.RegularExpressions.Regex.IsMatch(code, "^[A-Z0-9]+$"))
            {
                MessageBox.Show("Kode hanya boleh terdiri dari huruf besar dan angka.");
                return; // Keluar dari metode untuk menghentikan penyimpanan
            }

            // Periksa apakah kode sudah ada dalam database
            using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Quiz WHERE Code = @Code", conn))
            {
                try
                {
                    checkCmd.Parameters.AddWithValue("@Code", code);
                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Kode sudah ada dalam database.");
                        return; // Keluar dari metode untuk menghentikan penyimpanan
                    }
                    else
                    {
                        conn.Close();
                        int UserID=1;
                        string quizquery = "INSERT INTO Quiz (UserID, Name, Code, Description, CreatedAt) VALUES (@UserID, @Name, @Code, @Description, @CreateAt); SELECT SCOPE_IDENTITY();";

                        SqlCommand quizcmd = new SqlCommand(quizquery, conn);
                        conn.Open();
                        DateTime createAt = DateTime.Now;
                        quizcmd.Parameters.AddWithValue("@UserID", UserID);
                        quizcmd.Parameters.AddWithValue("@Name", quiznm_txt.Text);
                        quizcmd.Parameters.AddWithValue("@Code", code);
                        quizcmd.Parameters.AddWithValue("@Description", qDescription_txt.Text);
                        quizcmd.Parameters.AddWithValue("@CreateAt", createAt);

                        //mendapatkan primarykey baru
                        int newPrimarykey = Convert.ToInt32(quizcmd.ExecuteScalar());
                        conn.Close();


                        foreach (DataGridViewRow row in dataGridViewques.Rows)
                        {
                            string quest = row.Cells["Question"].Value != null ? row.Cells["Question"].Value.ToString() : "";
                            string optA = row.Cells["OptionA"].Value != null ? row.Cells["OptionA"].Value.ToString() : "";
                            string optB = row.Cells["OptionB"].Value != null ? row.Cells["OptionB"].Value.ToString() : "";
                            string optC = row.Cells["OptionC"].Value != null ? row.Cells["OptionC"].Value.ToString() : "";
                            string optD = row.Cells["OptionD"].Value != null ? row.Cells["OptionD"].Value.ToString() : "";
                            string correct = row.Cells["Correct"].Value != null ? row.Cells["Correct"].Value.ToString() : "";

                            string question = "INSERT INTO Question (QuizID, Question, OptionA, OptionB, OptionC, OptionD, CorrectAnswer) VALUES (@QuizID,@Question, @OptionA, @OptionB, @OptionC, @OptionD, @CorrectAnswer) ";
                            SqlCommand questcmd = new SqlCommand(question, conn);
                            conn.Open();
                            questcmd.Parameters.AddWithValue("@QuizID", newPrimarykey);
                            questcmd.Parameters.AddWithValue("@Question", quest);
                            questcmd.Parameters.AddWithValue("@OptionA", optA);
                            questcmd.Parameters.AddWithValue("@OptionB", optB);
                            questcmd.Parameters.AddWithValue("@OptionC", optC);
                            questcmd.Parameters.AddWithValue("@OptionD", optD);
                            questcmd.Parameters.AddWithValue("@CorrectAnswer", correct);
                            questcmd.ExecuteNonQuery();
                            conn.Close();
                            Form3 show = new Form3();
                            show.Show();

                        }
                       
                    }
                
                    
                }
                catch
                {
                    MessageBox.Show("Sepuranya error cak");
                }
            }
        }

        private void Cncelbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string question = question_txt.Text;
            string optionA = optA_txt.Text;
            string optionB = optB_txt.Text;
            string optionC = optC_txt.Text;
            string optionD = optD_txt.Text;
            string correct = "";

            if (optA_radio.Checked == true)
            {
                correct = optionA;
            }
            else if (optiB_radio.Checked == true)
            {
                correct = optionB;
            }
            else if (optC_radio.Checked == true)
            {
                correct = optionC;
            }
            else if (optD_radio.Checked == true)
            {
                correct = optionD;
            }
            else
            {
                MessageBox.Show("Jawaban benar belum dipilih");
                return;
            }
            dataGridViewques.Rows.Add(question, optionA, optionB, optionC, optionD, correct);
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewques.Columns.Add(deleteButtonColumn);
          
           


        }



        private void question_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void optA_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewques.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Konfirmasi penghapusan dengan dialog konfirmasi
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus baris ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Hapus baris dari DataGridView
                    dataGridViewques.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
