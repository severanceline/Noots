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

namespace Noots
{
    public partial class Form2: Form
    {
        private TextBox txtFirstNameUp;
        private TextBox txtLastNameUp;
        private TextBox txtUserNameUp;
        private TextBox txtEmailUp;
        private TextBox txtPasswordUp;
        private TextBox txtDateOfBirthUp;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLS_Click(object sender, EventArgs e)
        {
            Form1 myform = new Form1();
            myform.Show();
        }

        private void btnCreatAcountUp_Click(object sender, EventArgs e)
        {
            if (txtUserNameUp == null || txtFirstNameUp == null || txtLastNameUp == null || txtEmailUp == null || txtPasswordUp == null || txtDateOfBirthUp == null)
            {
                MessageBox.Show("Please make sure all fields are properly initialized.");
                return;
            }

            string ConnectionString = "Persist Security Info=False; User ID=sa; Password=490078; Initial Catalog=NOOTS; Data Source=.\\DEVELOP2";
            string query = "INSERT INTO Users([User Name],[First Name],[Last Name],[Email],[Password],[Date Of Birth]) VALUES (@UserName,@FirstName,@LastName,@Email,@Password,@DateOfBirth);";

            string UserNameUp = txtUserNameUp.Text;
            string FirstNameUp = txtFirstNameUp.Text;
            string LastNameUp = txtLastNameUp.Text;
            string EmailUp = txtEmailUp.Text;
            string PasswordUp = txtPasswordUp.Text;
            string DateOfBirthUp = txtDateOfBirthUp.Text;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserNameUp);
                        command.Parameters.AddWithValue("@FirstName", FirstNameUp);
                        command.Parameters.AddWithValue("@LastName", LastNameUp);
                        command.Parameters.AddWithValue("@Email", EmailUp);
                        command.Parameters.AddWithValue("@Password", PasswordUp);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirthUp);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Created Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to Create Account.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Persist Security Info = False; User ID = sa; Password = 490078; Initial Catalog = NOOTS; Data Source = .\\DEVELOP2";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connected");
                }
                catch
                {
                    MessageBox.Show("Not connected");
                    
                }
            }
        }
    }
}
