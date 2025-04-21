using Noots.Security;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Noots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelSignUp.SendToBack();
            panelSignIn.Visible = true;
            panelSignUp.Visible = false;
        }

        private void btnloginLI_Click(object sender, EventArgs e)
        {
            if (txtusernameLI == null || txtpasswordLI == null)
            {
                MessageBox.Show("Please make sure all fields are properly initialized.");
                return;
            };
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = "SELECT [Id], [User Name], [Email] "
                + "FROM [NOOTS].[dbo].[Users]  WHERE [User Name] = @UsernameLI AND [Password] = @PasswordLI";
            string UsernameLI = txtusernameLI.Text;
            string HashedPasswordLI = SecurityHelper.HashPassword(txtpasswordLI.Text.Trim());
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UsernameLI", UsernameLI);
                        command.Parameters.AddWithValue("@PasswordLI", HashedPasswordLI);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Session.CurrentUser.userId = reader.GetGuid(0);
                                Session.CurrentUser.UserName = reader.GetString(1);
                                Session.CurrentUser.Email = reader.GetString(2);
                                this.Hide();
                                MessageBox.Show("Logged in successfully");
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

 

        private void panelSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackToSignInUp_Click(object sender, EventArgs e)
        {
            panelSignUp.SendToBack();
            panelSignIn.Visible = true;
            panelSignUp.Visible = false;
        }

        private void btnCreatAcountUp_Click_1(object sender, EventArgs e)
        {
            if (txtUserNameUp == null || txtFirstNameUp == null || txtLastNameUp == null || txtEmailUp1 == null || txtPasswordUp == null || txtDateOfBirthUp == null)
            {
                MessageBox.Show("Please make sure all fields are properly initialized.");
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = "INSERT INTO Users([User Name],[First Name],[Last Name],[Email],[Password],[Date Of Birth]) VALUES (@UserName,@FirstName,@LastName,@Email,@Password,@DateOfBirth);";
            string UserNameUp = txtUserNameUp.Text;
            string FirstNameUp = txtFirstNameUp.Text;
            string LastNameUp = txtLastNameUp.Text;
            string EmailUp = txtEmailUp1.Text;
            string HashedPasswordUp = SecurityHelper.HashPassword(txtPasswordUp.Text.Trim());
            string DateOfBirthUp = txtDateOfBirthUp.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                        command.Parameters.AddWithValue("@Password", HashedPasswordUp);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirthUp);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Created Successfully!");
                            panelSignUp.SendToBack();
                            panelSignIn.Visible = true;
                            panelSignUp.Visible = false;
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

        private void btncreateacountLI_Click(object sender, EventArgs e)
        {
            panelSignIn.Visible = false;
            panelSignUp.Visible = true;
            panelSignUp.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSignIn.SendToBack();
            panelSignUp.Visible = true;
            panelSignIn.Visible = false;
        }
    }
}
