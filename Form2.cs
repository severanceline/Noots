using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private Button btnAddText;
        private Button btnAddImage;
        private Button btnAddFile;

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
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connected");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not connected" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnAddText = new Button();
            btnAddText.Text = "Add Text";
            btnAddText.Location = new Point(btnAdd.Left, btnAdd.Bottom + 10);
            btnAddText.Size = new Size(100, 30);
            btnAddText.Click += BtnAddText_Click;
            this.Controls.Add(btnAddText);

            btnAddImage = new Button();
            btnAddImage.Text = "Add Image";
            btnAddImage.Location = new Point(btnAdd.Left, btnAddText.Bottom + 10);
            btnAddImage.Size = new Size(100, 30);
            btnAddImage.Click += BtnAddImage_Click;
            this.Controls.Add(btnAddImage);

            btnAddFile = new Button();
            btnAddFile.Text = "Add File";
            btnAddFile.Location = new Point(btnAdd.Left, btnAddImage.Bottom + 10);
            btnAddFile.Size = new Size(100, 30);
            btnAddFile.Click += BtnAddFile_Click;
            this.Controls.Add(btnAddFile);
        }

        private void BtnAddText_Click(object sender, EventArgs e)
        {
            Controls.Remove(btnAddText);
            Controls.Remove(btnAddImage);
            Controls.Remove(btnAddFile);

            TextBox txtUserInput = new TextBox();
            txtUserInput.Location = new Point(btnAdd.Left, btnAdd.Bottom + 10); 
            txtUserInput.Size = new Size(500, 300); 
            txtUserInput.Multiline = true; 
            txtUserInput.ScrollBars = ScrollBars.Vertical;
            this.Controls.Add(txtUserInput);

            Button BtnAdd = new Button();
            BtnAdd.Location = new Point(txtUserInput.Left, txtUserInput.Bottom + 10);
            BtnAdd.Size = new Size(100, 30);
            BtnAdd.Text = "Add";
            this.Controls.Add(BtnAdd);
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
