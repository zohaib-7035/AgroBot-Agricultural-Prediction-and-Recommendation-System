using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace agrobot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textEmail.Text;
            string pwd = textpassword.Text;

            var db = new DB();
            db.GetConnection();
            bool usernameExists = db.Exists("userInfo", new Dictionary<string, object> { { "username", username } });
            bool pwdExists = false;
            if (usernameExists)
            {
                pwdExists = db.Exists("userInfo", new Dictionary<string, object> { { "pwd", pwd } });
            }


            if (!usernameExists || !pwdExists)
            {
                MessageBox.Show("Invalid username or password!");
                return;
            }

            new Form2().Show();
            this.Hide();
            /*var db = new DB();

            bool usernameExists = db.Exists("userInfo", new Dictionary<string, object> { { "username", "zohaib" } });
            bool pwdExists = db.Exists("userInfo", new Dictionary<string, object> { { "pwd", "123" } });

            if (usernameExists)
            {
                MessageBox.Show("username ok");
            }
            if (pwdExists)
            {
                MessageBox.Show("pwd ok");
            }*/
        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new signup().Show();
            this.Hide();
        }

        private void textpassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
