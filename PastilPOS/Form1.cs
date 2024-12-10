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

namespace PastilPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string pass = password.Text;

            try
            {

                using (SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=PASTILDB;Trusted_Connection=True;"))
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Role from Users WHERE Username = @Username AND Password = @Password", connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    object role = cmd.ExecuteScalar();

                    if (role != null)
                    {
                        MessageBox.Show("Login successful! Role:" + role.ToString());
                        Order order = new Order();
                        order.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
                

            }
        }
    }
