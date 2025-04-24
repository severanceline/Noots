using Noots;
using Noots.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Noots
{
    public partial class Form2: Form
    {
        private Button btnAddText;
        private Button btnAddImage;
        private Button btnAddFile;
        private TextBox txtUserInput;
        private Button BtnSelectImage;
        byte[] imageBytes;

        public Form2()
        {
            this.InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxText.Visible = false;
            groupBoxAddImage.Visible = false;
        }

        private void btnLS_Click(object sender, EventArgs e)
        {
            Form1 myform = new Form1();
            myform.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
        }

        private void BtnAddText_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            BtnSelectImage = new Button();
            BtnSelectImage.Location = new Point(btnAddImage.Location.X + btnAddImage.Width + 10 , btnAddImage.Location.Y);
            BtnSelectImage.Size = new Size(100, 30);
            BtnSelectImage.Text = "Select from files";
            BtnSelectImage.Click += BtnSelectImage_Click;
            this.Controls.Add(BtnSelectImage);
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddText1_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            if (groupBoxText.TabIndex <  groupBoxAddImage.TabIndex )
                groupBoxAddImage.BringToFront();
            groupBoxText.Visible = true;
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text.");
                return;
            }
            string query = "INSERT INTO [Datas] ([UserId],[DataCategory],[TextContent]) "
            + "VALUES ( @userId , 1 , @TextContent )";
            using (SqlConnection connection = new SqlConnection(Session.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", Session.CurrentUser.userId);
                        command.Parameters.AddWithValue("@TextContent", txtInput.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Note added successfully.");
                            txtInput.Clear();
                            groupBoxText.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add note.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnCancelText_Click(object sender, EventArgs e)
        {
            groupBoxText.Visible = false;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxText_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddImage1_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            if (groupBoxAddImage.TabIndex < groupBoxText.TabIndex)
                groupBoxText.BringToFront();
            groupBoxAddImage.Visible = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImageInput.Image = Image.FromFile(ofd.FileName);
                imageBytes = File.ReadAllBytes(ofd.FileName);
            }
        }

        private void btnCancelImage_Click(object sender, EventArgs e)
        {
            groupBoxAddImage.Visible = false;
            groupBoxText.Visible = false;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            string query = " INSERT INTO Datas ([UserId] , [DataCategory],[ImageContent]) VALUES ( @UserId , 2 , @ImageContent )";
            using (SqlConnection connection = new SqlConnection(Session.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", Session.CurrentUser.userId);
                        command.Parameters.AddWithValue("@ImageContent", imageBytes);
                        command.Parameters.AddWithValue("@TextContent", txtInput.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Note added successfully.");
                            pictureBoxImageInput.Image = null;
                            groupBoxAddImage.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to add note.");
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
}
