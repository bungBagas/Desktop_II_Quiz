using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace Desktop_II_Quiz
{
    public partial class Form3 : Form
    {


        private string fullname;
        public Form3()
        
        {

            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        public void data(DataTable datatable)
        {
           
        }
        public void ShowFullName(string fullname)
        {
            fname_lbl.Text = fullname;
            
        }
        public void showdatabase(DataTable quizData)
        {
            if (quizData.Rows.Count > 0) // Jika ada data quiz
            {
                dataGridView1.DataSource = quizData; // Set data source dari DataGridView ke DataTable

                if (!dataGridView1.Columns.Contains("DeleteButtonColumn")) {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();

                    deleteButtonColumn.Name = "Delete";
                    deleteButtonColumn.Text = "Delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(deleteButtonColumn);
                    dataGridView1.Columns["ID"].Visible = false;
                    // Periksa apakah tombol di kolom "Delete" ditekan
                }

            }
            else
            {
                dataGridView1.DataSource = null; // Kosongkan data source

            }

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KUCJLI3S\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuizinAJa4 ");
        private string connectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            this.fullname = fullname;
            string query = "Select*from Quiz where UserID=(Select ID FROM Pengguna where Fullname = @Fullname)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Fullname", fullname);
            Form4 form4 = new Form4();
            form4.Show();
            

            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string quer = @"SELECT 
            p.ID, 
            p.ParticipantNickname, 
            p.TimeTaken
            FROM 
            Participant p
            JOIN 
            (SELECT 
                pa.ParticipantID, pa.Answer,
                ROUND(SUM(CASE WHEN pa.Answer = q.CorrectAnswer THEN 1 ELSE 0 END)*100.0/COUNT(pa.QuestionID), 0) AS FormattedPercentage
                FROM 
                ParticipantAnswer pa
                JOIN
                Question q ON pa.QuestionID =q.ID
                GROUP BY 
                pa.ParticipantID, pa.Answer)
                pa ON p.ID = pa.ParticipantID";
            //            string query = @"SELECT
            //    p.ID,
            //    p.ParticipantNickName,
            //    p.TimeTaken,
            //    pa.Answer
            //FROM
            //    Participant p
            //JOIN
            //        SELECT
            //            pa.ParticipantID,
            //            ROUND(SUM(CASE WHEN pa.Answer = q.CorrectAnswer THEN 1 ELSE 0 END) * 100.0/COUNT(pa.QuestionID), 0) AS CorrectPercentage
            //        FROM
            //           ParticipantAnswer pa
            //        JOIN
            //            Question q ON pa.QuestionID = q.ID
            //        GROUP BY
            //            pa.ParticipantID
            //    pa ON p.ID = pa.ParticipantID;";

            SqlCommand cmd = new SqlCommand(quer, conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            
            conn.Close();

            double averageTimeTaken = dt.AsEnumerable()
                        .Select(row => row.Field<int>("TimeTaken"))
                        .Average();

            int participantCount = dt.Rows.Count;
            // Menambahkan kolom baru untuk waktu yang telah diformat
            dt.Columns.Add("FormattedTime", typeof(string));

            // Mengisi kolom baru dengan waktu yang diformat
            foreach (DataRow row in dt.Rows)
            {
                int timeTakenInSeconds = Convert.ToInt32(row["TimeTaken"]);
                TimeSpan timeSpan = TimeSpan.FromSeconds(timeTakenInSeconds);
                string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                                     (int)timeSpan.TotalHours,
                                                     timeSpan.Minutes,
                                                     timeSpan.Seconds);
                row["FormattedTime"] = formattedTime;
            }

            
    
            dt.Columns.Add("FormattedPercentage", typeof (string));
            foreach (DataRow row in dt.Rows)
            {
                int percentageCorrect = Convert.ToInt16(row["FormattedPercentage"]);
                row["FormattedPercentage"] = percentageCorrect.ToString("F0") + "%";
            }
            Form5 form5 = new Form5();
            form5.Show();
            form5.showdatasource(dt, averageTimeTaken, participantCount);
            //form5.shownick(nick);
            this.Hide();
        }
        public void Quizlist()
        {
             
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Memeriksa apakah tombol hapus diklik
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                // Mendapatkan IDUtama dari baris yang dipilih
                int idUtamaToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                // Hapus baris yang sesuai dari database
                DeleteRowFromDatabase(idUtamaToDelete);

                // Hapus baris dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
           
        }
        private void DeleteRowFromDatabase(int idUtamaToDelete)
        {
            try
            {
               
                    conn.Open();
                    string deleteCommand = "DELETE FROM Quiz WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(deleteCommand, conn))
                    {
                        command.Parameters.AddWithValue("@ID", idUtamaToDelete);

                    DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus data", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("database berhasil dihapus");
                        }
                        else
                        {
                            MessageBox.Show("Tidak ada baris yang terhapus.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("penghapusan dibatalkan");
                    }    
                       
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    











    private void Form3_Load(object sender, EventArgs e)
            {  // Menambahkan kolom tombol hapus




                // Menambahkan kolom tombol hapus ke DataGridView



            }


            private void fname_lbl_Click(object sender, EventArgs e)
            {

            }




        }
    }
