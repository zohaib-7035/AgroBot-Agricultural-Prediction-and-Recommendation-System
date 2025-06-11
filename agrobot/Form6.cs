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

namespace agrobot
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string email = txtEmail.Text.Trim();
            string question = txtQuestion.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(question))
            {
                MessageBox.Show("Name and Question are required.");
                return;
            }

            // Replace with your actual DB name
            string connectionString = "Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=agrobot;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HelpSupport (Name, ContactNumber, Email, Question) " +
                               "VALUES (@Name, @Contact, @Email, @Question)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Question", question); // ✅ removed duplicate

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your message has been submitted successfully!");

                    // Clear fields
                    txtName.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    txtQuestion.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
