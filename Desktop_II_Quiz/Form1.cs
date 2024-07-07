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


namespace Desktop_II_Quiz   
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
            

        }
        public void showdatabase() {
            string column = "Name, Code, Description";

            string query = $"Select {column} FROM Quiz where UserID";

            conn.Open();
            // Buat adapter dan dataset
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();

            // Isi dataset dengan data dari adapter
            adapter.Fill(dataTable);

            // Tampilkan data di DataGridView
          

          
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KUCJLI3S\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuizinAja4");
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Logika untuk mengubah properti TextBox
            if (checkBox1.Checked == true)
            {
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 create = new Form2();
            create.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username, user_password;
            Username = username_txt.Text;
            user_password = password_txt.Text;

            // Query untuk mencari data berdasarkan Username dan Password
            string query = "SELECT*FROM Pengguna WHERE Username = @Username AND Password = @Password ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", user_password);
            conn.Open();
            // Eksekusi query   
            SqlDataReader reader = cmd.ExecuteReader();
            SqlDataAdapter sda = new SqlDataAdapter();
            if (reader.Read()) // Jika data ditemukan
            {
                string fullName = reader["FullName"].ToString();

                conn.Close();
                //mengambil data 
                string quizQuery = "SELECT ID, Name,Code,Description,(SELECT COUNT(*) AS NumberOfQuestion FROM Question Where QuizID =(Select ID from Pengguna where Username=@Username))AS NumberOfQuestion FROM Quiz where UserID=(Select ID from Pengguna where Username=@Username)";
                SqlCommand quizCmd = new SqlCommand(quizQuery, conn);
                quizCmd.Parameters.AddWithValue("@Username", Username);
                conn.Open();
                SqlDataReader quizReader = quizCmd.ExecuteReader();
                DataTable quizData = new DataTable();
                quizData.Load(quizReader);
                conn.Close();

                
                


                // Buka form baru dan kirim FullName
                Form3 mainForm = new Form3();
                mainForm.Show();
                mainForm.ShowFullName(fullName);
                mainForm.showdatabase(quizData);
              

                this.Hide(); // Sembunyikan form login
            }
            else
            {
                MessageBox.Show("Login gagal! Username atau Password salah.");
                
            }
             
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 quizform = new Form6();
            quizform.Show();
            this.Hide();
        }




        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
