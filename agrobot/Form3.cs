using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace agrobot
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Get user inputs
            string crop = UserCrop.Text;
            string humidity = UserHumidity.Text;
            string soilType = UserSoilType.Text;
            string totalArea = UserTotalArea.Text;
            string temperature = UserTemprature.Text;
            string waterSource = UserWaterSource.Text;
            string weatherCondition = UserWeatherCondition.Text;
            string additionalComments = UserAdditionalComments.Text;

            // Generate a prompt for the AI
            string prompt = $"As an agricultural expert, provide detailed recommendations to improve crop yield for a farmer growing {crop}. " +
                           $"Consider the following conditions:\n" +
                           $"- Humidity: {humidity}\n" +
                           $"- Soil Type: {soilType}\n" +
                           $"- Total Area: {totalArea}\n" +
                           $"- Temperature: {temperature}\n" +
                           $"- Water Source: {waterSource}\n" +
                           $"- Weather Condition: {weatherCondition}\n" +
                           $"- Additional Comments: {additionalComments}\n\n" +
                           $"Provide step-by-step suggestions on soil management, irrigation, pest control, and best practices.";

            // Call DeepSeek API
            string apiResponse = await GetAIRecommendation(prompt);
            //MessageBox.Show(apiResponse);

            // Pass the response to Form4 (assuming Form4 displays the result)
            Form4 form4 = new Form4(apiResponse);
            form4.Show();
            this.Hide();
        }

        private async Task<string> GetAIRecommendation(string prompt)
        {
            string apiKey = "AIzaSyAVhV8Ef0xakS-LCPRiW5xxtYKSoBl6vAc"; // Don't expose publicly
            string apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=AIzaSyAVhV8Ef0xakS-LCPRiW5xxtYKSoBl6vAc";

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromSeconds(30);



                    var requestData = new
                    {
                        contents = new[] {
        new {
            parts = new[] {
                new {
                    text = "You are an expert in crop and agriculture advisory.\n" + prompt
                }
            }
        }
    }
                    };

                    var content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync(apiUrl, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        dynamic responseObject = JsonConvert.DeserializeObject(responseString);
                        if (responseObject?.candidates != null && responseObject.candidates.Count > 0)
                        {
                            return responseObject.candidates[0]?.content?.parts?[0]?.text?.ToString();
                        }
                        return "No candidates found in the response.";
                    }

                    else
                    {
                        return $"API Error: {response.StatusCode}\n{responseString}";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthelp_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }
    }
}
