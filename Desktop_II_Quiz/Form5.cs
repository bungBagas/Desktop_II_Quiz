using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_II_Quiz
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KUCJLI3S\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuizinAJa4");
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void shownick(string nick)
        {
            listcombobox.Text = nick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        public void showdatasource(DataTable dt, double averageTimeTaken, int participantCount)
        {

            //MergeDataTables(dt, datanilai);
             
            // Menghubungkan DataTable ke DataGridView
            dataGridView1.DataSource = dt;

            double rataRataPercentage = HitungRataRata(dt);
            correctlbl_txt.Text = rataRataPercentage.ToString("F0")+"%";
          
            TimeSpan averageTimeSpan = TimeSpan.FromSeconds(averageTimeTaken);
            string formattedAverageTime = string.Format("{0:D2}:{1:D2}:{2:D2}",
                (int)averageTimeSpan.TotalHours,
                averageTimeSpan.Minutes,
                averageTimeSpan.Seconds);
            lblfill_timetaken.Text = $"{formattedAverageTime}";
            participant_count.Text = $"{participantCount} participant(s)";

            //if (dt.Columns.Contains("TimeTaken"))
            //{
            //    dataGridView1.Columns["TimeTaken"].Visible = false;
            //}
            //if (dt.Columns.Contains("FormattedTime"))
            //{
            //    dataGridView1.Columns["FormattedTime"].HeaderText = "Time Taken";
            //}



            // Menyembunyikan kolom asli dan menampilkan kolom yang diformat
            dataGridView1.Columns["TimeTaken"].Visible = false;
            dataGridView1.Columns["FormattedTime"].HeaderText = "Time Taken";
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["correct"].Visible = false;
            dataGridView1.Columns["FormattedPercentage"].HeaderText = "CorrectPercentage";
          
        }
        //private void MergeDataTables(DataTable dt, DataTable datanilai)
        //{
        //    if (!dt.Columns.Contains("FormattedTime"))
        //    {
        //        dt.Columns.Add("FormattedTime", typeof(string));
        //    }
        //    if (!dt.Columns.Contains("FormattedPercentage"))
        //    {
        //        dt.Columns.Add("FormattedPercentage", typeof(string));
        //    }

        //    foreach (DataRow row in datanilai.Rows)
        //    {
        //        DataRow existingRow = dt.Rows.Find(row["ParticipantID"]);
        //        if (existingRow != null)
        //        {
        //            existingRow["percentage_correct"] = row["percentage_correct"];
        //            existingRow["average_timr_taken"] = row["TimeTaken"];
        //            existingRow["ParticipantNickName"] = row["ParticipantNickName"];
        //        }
        //        else
        //        {
        //            dt.ImportRow(row);
        //        }
        //    }
        //    // Format kolom baru
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        // Format waktu rata-rata
        //        if (row["average_time_taken"] != DBNull.Value)
        //        {
        //            TimeSpan averageTimeSpan = TimeSpan.FromSeconds(Convert.ToDouble(row["average_time_taken"]));
        //            string formattedAverageTime = string.Format("{0:D2}:{1:D2}:{2:D2}",
        //                (int)averageTimeSpan.TotalHours,
        //                averageTimeSpan.Minutes,
        //                averageTimeSpan.Seconds);
        //            row["FormattedTime"] = formattedAverageTime;
        //        }

        //        // Format persentase jawaban benar
        //        if (row["percentage_correct"] != DBNull.Value)
        //        {
        //            double percentageCorrect = Convert.ToDouble(row["percentage_correct"]);
        //            row["FormattedPercentage"] = percentageCorrect.ToString("F2") + "%";
        //        }
        //    }

        //}
        public double HitungRataRata(DataTable dataTable)
        {
            double totalPercentage = 0;

            // Iterasi melalui setiap baris dalam DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Ambil nilai percentage_correct dari setiap baris dan tambahkan ke totalPercentage
                totalPercentage += Convert.ToDouble(row["Percentage"]);
            }

            // Bagi total jumlah nilai dengan jumlah baris dalam DataTable untuk mendapatkan rata-rata
            double rataRata = totalPercentage / dataTable.Rows.Count;

            return rataRata;
        }

        private void listcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

