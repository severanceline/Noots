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
    }
}
