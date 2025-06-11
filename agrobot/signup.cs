using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace agrobot
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = Username.Text;
            String email = UserEmail.Text;
            String pwd = UserPwd.Text;

            var db = new DB();
            db.GetConnection();

            int result = db.Insert("userinfo", new Dictionary<string, object>
            {
                {"username", username },
                { "email", email },
                { "pwd", pwd }
            });

            if (result <= 0)
            {
                MessageBox.Show("Sorry! Unexpected error occured, please try again");
                return;
            }

            MessageBox.Show("You are signed up successfully!");
            new Form1().Show();
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
