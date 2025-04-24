using Noots.Security;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Noots
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelSignUp.SendToBack();
            panelSignIn.Visible = true;
            panelSignUp.Visible = false;
            listBoxErrors.Visible = false;  
        }

        private void btnloginLI_Click(object sender, EventArgs e)
        {
            if (txtusernameLI == null || txtpasswordLI == null)
            {
                MessageBox.Show("Please make sure all fields are properly initialized.");
                return;
            };
            string query = "SELECT [Id], [User Name],[First Name],[Last Name],[Email],[Password],[Date Of Birth],[Date Of Sign Up] "
                + "FROM [NOOTS].[dbo].[Users]  WHERE [User Name] = @UsernameLI AND [Password] = @PasswordLI";
            string UsernameLI = txtusernameLI.Text;
            string HashedPasswordLI = SecurityHelper.HashPassword(txtpasswordLI.Text.Trim());
            using (SqlConnection connection = new SqlConnection(Session.connectionString))
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
                                Session.CurrentUser.Firstname = reader.GetString(2);
                                Session.CurrentUser.Lastname = reader.GetString(3);
                                Session.CurrentUser.Email = reader.GetString(4);
                                Session.CurrentUser.Password = reader.GetString(5);
                                Session.CurrentUser.Dateofbirth = reader.GetDateTime(6);
                                Session.CurrentUser.Dateofsignup = reader.GetDateTime(7);
                                this.Hide();
                                MessageBox.Show($"Welcome, {Session.CurrentUser.Firstname} {Session.CurrentUser.Lastname}!");
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
            listBoxErrors.Items.Clear();
            listBoxErrors.Visible = false;
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtFirstNameUp.Text) && string.IsNullOrWhiteSpace(txtLastNameUp.Text) &&
                string.IsNullOrWhiteSpace(txtUserNameUp.Text) && string.IsNullOrWhiteSpace(txtPasswordUp.Text) &&
                string.IsNullOrWhiteSpace(txtEmailUp1.Text)
                && dateTimePickerBirthDate.Value.Date == DateTime.Today.Date)
            {
                listBoxErrors.Items.Add("All fields are required. Please fill them out.");
                listBoxErrors.Visible = true;
                return;
            }
            //First Name
            if (txtFirstNameUp == null)
            {
                listBoxErrors.Items.Add("First name field cannot be empty.");
                hasError = true;
            }
            if (!Regex.IsMatch(txtFirstNameUp.Text, @"^[a-zA-Z]+$"))
            {
                listBoxErrors.Items.Add("Only English letters are allowed for first name.");
                hasError = true;
            }
            //Last name
            if (txtLastNameUp == null)
            {
                listBoxErrors.Items.Add("Last name field cannot be empty.");
                hasError = true;
            }
            if (!Regex.IsMatch(txtLastNameUp.Text, @"^[a-zA-Z]+$"))
            {
                listBoxErrors.Items.Add("Only English letters are allowed for last name.");
                hasError = true;
            }
            //Username
            string query = "SELECT COUNT(*) FROM Users WHERE [User Name] = @Username";
            string Username = txtUserNameUp.Text;
            using (SqlConnection connection2 = new SqlConnection(Session.connectionString))
            {
                try
                {
                    connection2.Open();
                    using (SqlCommand command = new SqlCommand(query, connection2))
                    {
                        command.Parameters.AddWithValue("@Username", Username);

                        int userCount = (int)command.ExecuteScalar();
                        if (userCount > 0)
                        {
                            listBoxErrors.Items.Add("This username is already taken. Please choose another one.");
                            hasError = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking username: " + ex.Message);
                }
            }

            if (txtUserNameUp == null)
            {
                listBoxErrors.Items.Add("Username field cannot be empty.");
                hasError = true;
            }
            if (!Regex.IsMatch(txtUserNameUp.Text, @"^[a-zA-Z0-9._-]+$"))
            {
                listBoxErrors.Items.Add("Username can only contain English letters, numbers, dots, hyphens, and underscores.");
                hasError = true;
            }
            if (txtUserNameUp.Text.Length < 5)
            {
                listBoxErrors.Items.Add("Username must be at least 5 characters.");
                hasError = true;
            }
            if (txtUserNameUp.Text.Length > 20)
            {
                listBoxErrors.Items.Add("Username must be a maximum of 20 characters.");
                hasError = true;
            }
            //Password
            if (txtPasswordUp.Text == null)
            {
                listBoxErrors.Items.Add("Password field cannot be empty.");
                hasError = true;
            }
            if (!Regex.IsMatch(txtPasswordUp.Text, @"^[\x20-\x7E]+$"))
            {
                listBoxErrors.Items.Add("Password can only contain English letters, numbers,  and standard  keyboard characters.");
                hasError = true;
            }
            if (!(txtPasswordUp.Text.Any(char.IsLower) && txtPasswordUp.Text.Any(char.IsUpper)))
            {
                listBoxErrors.Items.Add("Password must contain both uppercase and lowercase letters.");
                hasError = true;
            }
            if (!Regex.IsMatch(txtPasswordUp.Text, @"\d"))
            {
                listBoxErrors.Items.Add("Password must contain at least one number.");
                hasError = true;
            }
            if (txtPasswordUp.Text.Length < 8)
            {
                listBoxErrors.Items.Add("Password must be at least 8 characters.");
                hasError = true;
            }
            if (txtPasswordUp.Text.Length > 20)
            {
                listBoxErrors.Items.Add("Password must be a maximum of 20 characters.");
                hasError = true;
            }
            //Email
            if (txtEmailUp1.Text == null)
            {
                listBoxErrors.Items.Add("Email field cannot be empty.");
                hasError = true;
            }
            if (!Regex.IsMatch(txtEmailUp1.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                listBoxErrors.Items.Add("Please enter a valid email address.");
                hasError = true;
            }
            //Date of Birth
            if (dateTimePickerBirthDate.Value.Date == DateTime.Today.Date)
            {
                listBoxErrors.Items.Add("Please select a valid date.");
                hasError = true;
            }
            if (hasError)
            {
                listBoxErrors.Visible = true;
            }
            if (!hasError)
            {
                string query2 = "INSERT INTO Users([User Name],[First Name],[Last Name],[Email],[Password],[Date Of Birth]) VALUES (@UserName,@FirstName,@LastName,@Email,@Password,@DateOfBirth);";
                string UserNameUp = txtUserNameUp.Text;
                string FirstNameUp = txtFirstNameUp.Text;
                string LastNameUp = txtLastNameUp.Text;
                string EmailUp = txtEmailUp1.Text;
                string HashedPasswordUp = SecurityHelper.HashPassword(txtPasswordUp.Text.Trim());
                DateTime selectedDate = dateTimePickerBirthDate.Value;
                string DateOfBirthUp = selectedDate.ToString("yyyy-MM-dd");

                using (SqlConnection connection = new SqlConnection(Session.connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query2, connection))
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

        private void panelSignIn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
