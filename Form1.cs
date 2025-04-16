using Noots.Security;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Noots
{
    public partial class Form1 : Form
    {
        private TextBox txtFirstNameUp;
        private TextBox txtLastNameUp;
        private TextBox txtUserNameUp;
        private TextBox txtEmailUp;
        private TextBox txtPasswordUp;
        private TextBox txtDateOfBirthUp;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblCA_Click(object sender, EventArgs e)
        {
            Controls.Remove(lblusernameLI);
            Controls.Remove(txtusernameLI);
            Controls.Remove(lblpasswordLI);
            Controls.Remove(txtpasswordLI);
            Controls.Remove(btnloginLI);
            Controls.Remove(btncreateacountLI);

            Label lblSignUpUp = new Label
            {
                Text = "Sign Up",
                Location = new Point(100, 10),
                AutoSize = true
            };
            this.Controls.Add(lblSignUpUp);

            Label lblFirstNameUp = new Label
            {
                Text = "First Name",
                Location = new Point(10, 50),
                AutoSize = true
            };
            this.Controls.Add(lblFirstNameUp);

            txtFirstNameUp = new TextBox
            {
                Location = new Point(90, 50),
                Width = 130
            };
            this.Controls.Add(txtFirstNameUp);

            Label lblLastNameUp = new Label
            {
                Text = "Last Name",
                Location = new Point(10, 80),
                AutoSize = true
            };
            this.Controls.Add(lblLastNameUp);

            txtLastNameUp = new TextBox
            {
                Location = new Point(90, 80),
                Width = 130
            };
            this.Controls.Add(txtLastNameUp);

            Label lblUserNameUp = new Label
            {
                Text = "User Name",
                Location = new Point(10, 110),
                AutoSize = true
            };
            this.Controls.Add(lblUserNameUp);

            txtUserNameUp = new TextBox
            {
                Location = new Point(90, 110),
                Width = 130
            };
            this.Controls.Add(txtUserNameUp);

            Label lblEmailUp = new Label
            {
                Text = "Email",
                Location = new Point(10, 140),
                AutoSize = true
            };
            this.Controls.Add(lblEmailUp);

            txtEmailUp = new TextBox
            {
                Location = new Point(90, 140),
                Width = 130
            };
            this.Controls.Add(txtEmailUp);

            Label lblPasswordUp = new Label
            {
                Text = "Password",
                Location = new Point(10, 170),
                AutoSize = true
            };
            this.Controls.Add(lblPasswordUp);

            txtPasswordUp = new TextBox
            {
                Location = new Point(90, 170),
                Width = 130
            };
            this.Controls.Add(txtPasswordUp);

            Label lblDateOfBirthUp = new Label
            {
                Text = "Date Of Birth",
                Location = new Point(10, 200),
                AutoSize = true
            };
            this.Controls.Add(lblDateOfBirthUp);

            txtDateOfBirthUp = new TextBox
            {
                Location = new Point(90, 200),
                Width = 130
            };
            this.Controls.Add(txtDateOfBirthUp);

            Button btnCreatAcountUp = new Button
            {
                Text = "Create Account",
                Location = new Point(80, 240),
                Size = new Size(100, 30)
            };
            btnCreatAcountUp.Click += btnCreatAcountUp_Click;
            this.Controls.Add(btnCreatAcountUp);
        }

        private void btnCreatAcountUp_Click(object sender, EventArgs e)
        {
            if (txtUserNameUp == null || txtFirstNameUp == null || txtLastNameUp == null || txtEmailUp == null || txtPasswordUp == null || txtDateOfBirthUp == null)
            {
                MessageBox.Show("Please make sure all fields are properly initialized.");
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = "INSERT INTO Users([User Name],[First Name],[Last Name],[Email],[Password],[Date Of Birth]) VALUES (@UserName,@FirstName,@LastName,@Email,@Password,@DateOfBirth);";
            string UserNameUp = txtUserNameUp.Text;
            string FirstNameUp = txtFirstNameUp.Text;
            string LastNameUp = txtLastNameUp.Text;
            string EmailUp = txtEmailUp.Text;
            string HashedPasswordUp = SecurityHelper.HashPassword(txtPasswordUp.Text);
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
                            this.Close();
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

        private void btnloginLI_Click(object sender, EventArgs e)
        {
            if (txtusernameLI == null || txtpasswordLI == null)
            {
                MessageBox.Show("Please make sure all fields are properly initialized.");
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = "SELECT COUNT(*) FROM Users WHERE [User Name]=@UsernameLI AND [Password]=@PasswordLI;";
            string UsernameLI = txtusernameLI.Text;
            string HashedPasswordLI = SecurityHelper.HashPassword(txtpasswordLI.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserNameLI", UsernameLI);
                        command.Parameters.AddWithValue("@PasswordLI", HashedPasswordLI);

                        int userCount = (int)command.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("Login Successful!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
