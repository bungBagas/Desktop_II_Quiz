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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KUCJLI3S\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuizinAJa4");
        private void joinbtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("buton diklik");
          
                string code, nickname;
                code = qcode_txt.Text;
                nickname = nick_txt.Text;
                
                string query = "SELECT*FROM Quiz WHERE Code=@Code";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", code);
            try
            {
                conn.Open();
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    if (read["ID"] != DBNull.Value)
                    {
                        int quizId = Convert.ToInt32(read["ID"]);
                        read.Close();


                        Form7 form7 = new Form7();
                        form7.Show();
                        form7.Shownickname(nickname, code, quizId);
                        this.Hide();

                    }
                    else
                    {
                        read.Close();
                        conn.Close();
                        MessageBox.Show("Quiz ID tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    read.Close();
                    conn.Close();
                    MessageBox.Show("Kode Tidak ditemukan. Silahkan coba lagi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch
            {
                MessageBox.Show("Error cak", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
                
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void qcode_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
