using System;
using System.Windows.Forms;

namespace agrobot
{
    public partial class Form4 : Form
    {
        private readonly string recommendation;

        // Constructor receives the API response string
        public Form4(string apiResponse)
        {
            InitializeComponent();
            recommendation = apiResponse ?? string.Empty; // Avoid null issues

            this.Load += Form4_Load;

        }

        // Form Load event handler - sets up the RichTextBox
        private void Form4_Load(object sender, EventArgs e)
        {


            recomendationTextArea.Clear(); // Always clear before setting
            recomendationTextArea.ReadOnly = true;
            recomendationTextArea.WordWrap = true;
            recomendationTextArea.ScrollBars = RichTextBoxScrollBars.Vertical; // Enable vertical scroll bar
            recomendationTextArea.Text = recommendation;

        }

        // Optional: handle text changed event if needed
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // Example: You can add code here if you want to react to text changes
            // Currently, no action is needed here.
        }

        // Button click event to open Form5 and hide this form
        private void button1_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.Title = "Save AI Report";
            saveFileDialog.FileName = "AI_Crop_Recommendation.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, recommendation);
                MessageBox.Show("Report saved successfully.");
            }
        }
    }
}
