using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agrobot
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form7_Load);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Ensure TextBox properties are set
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ReadOnly = true;
            textBox1.WordWrap = true;
            textBox1.Font = new Font("Segoe UI", 10);

            // Use proper string concatenation to avoid newline in constant error
            textBox1.Text = "🌾 HOW TO USE AGROBOT" + Environment.NewLine +
                            "1. 🔐 Login or Sign Up to access the system." + Environment.NewLine +
                            "2. 🏠 View the Intro Page to understand features." + Environment.NewLine +
                            "3. 🌱 Enter your crop requirements in the form." + Environment.NewLine +
                            "4. 📈 Get smart recommendations for crops based on your inputs." + Environment.NewLine +
                            "5. 📊 View and download your recommendation report to guide your decisions." + Environment.NewLine +
                            "6. 🎥 Access YouTube videos for additional agricultural tips and tutorials." + Environment.NewLine +
                            "7. 📞 Use the Support page to ask experts any questions you may have." + Environment.NewLine + Environment.NewLine +
                            "💡 Tips:" + Environment.NewLine +
                            "- Use clear input for better recommendations." + Environment.NewLine +
                            "- Download reports for offline reference and future use." + Environment.NewLine +
                            "- Always log out after use for security." + Environment.NewLine +
                            "- Be sure to enter accurate data for optimal crop recommendations." + Environment.NewLine +
                            "- Check your recommendation periodically for updated advice." + Environment.NewLine +
                            "- If unsure, you can contact support for further clarification." + Environment.NewLine +
                            "- Review YouTube videos for in-depth understanding of each crop type." + Environment.NewLine +
                            "- Explore other sections of AgroBot to fully understand its capabilities." + Environment.NewLine + Environment.NewLine +
                            "🚀 Getting Started:" + Environment.NewLine +
                            "1. First, ensure you have a stable internet connection for seamless use." + Environment.NewLine +
                            "2. Fill in your crop requirements and preferences clearly." + Environment.NewLine +
                            "3. After receiving recommendations, explore the reports to make well-informed decisions." + Environment.NewLine +
                            "4. If you need additional help, don't hesitate to reach out to our support team." + Environment.NewLine +
                            "5. Share your feedback to help us improve AgroBot!" + Environment.NewLine +
                            "6. Keep your software up to date for the latest features and improvements." + Environment.NewLine + Environment.NewLine +
                            "🌟 Future Features (Coming Soon):" + Environment.NewLine +
                            "- Interactive weather forecasting integration for better crop prediction." + Environment.NewLine +
                            "- Expanded crop database with more types and varieties." + Environment.NewLine +
                            "- Community forum for discussions with fellow users." + Environment.NewLine +
                            "- Advanced AI-driven analysis for crop performance tracking.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }
    }
}