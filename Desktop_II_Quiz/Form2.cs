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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Hide();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KUCJLI3S\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QuizinAJa4;");
        private void createbtn_Click(object sender, EventArgs e)
        {
            
            if (password_txt.Text == rpassword_txt.Text)
            {
                if (password_txt.Text.Length < 4)
                {
                    MessageBox.Show("Kata Sandi Minimal 4 Karakter");
                }
                else
                {
                    string UsernameQuery = "SELECT COUNT(*) FROM Pengguna WHERE Username = @Username";

                    // Buat dan konfigurasi command untuk memeriksa username
                    using (SqlCommand UsernameCmd = new SqlCommand(UsernameQuery, conn))
                    {
                        // Tambahkan parameter untuk username
                        UsernameCmd.Parameters.AddWithValue("@Username", uname_txt.Text);

                        // Buka koneksi
                        conn.Open();

                        // Eksekusi query untuk memeriksa username
                        int UsernameCount = (int)UsernameCmd.ExecuteScalar();

                        conn.Close();
                        // Jika count lebih dari 0, artinya username sudah ada dalam database
                        if (UsernameCount > 0)
                        {
                            MessageBox.Show("Username telah digunakan.");
                        }
                        else
                        {

                            string fullname = fname_txt.Text;

                            string Insertquer = "INSERT INTO Pengguna (Username, FullName, DateOfBirth, Password) Values (@Username, @FullName, @DateOfBirth, @Password)";
                           
                           using (SqlCommand cmd = new SqlCommand(Insertquer, conn))
                            {
                                cmd.Parameters.AddWithValue("@Username", uname_txt.Text);
                                cmd.Parameters.AddWithValue("@FullName", fname_txt.Text);
                                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(date.Text));
                                cmd.Parameters.AddWithValue("@Password", rpassword_txt.Text);

                                try
                                {
                                    conn.Open();

                                    cmd.ExecuteNonQuery();
                                    Form3 form3 = new Form3();
                                    form3.Show();
                                    form3.ShowFullName(fullname);
                            }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("error");
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }
                            
                           
                           
                            
                            }
                       
                            
                           
                            

                           
                        

                    }

                }
            }
            else
            {
                MessageBox.Show("KataSandi tidak Sama periksa kata sandi kembali");
                rpassword_txt.Clear();
                rpassword_txt.Focus();
            }





        }
       

        }
    }

