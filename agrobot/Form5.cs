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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lvResults.View = View.Details;
            lvResults.Columns.Clear();
            lvResults.Columns.Add("Title", 300);
            lvResults.Columns.Add("Video ID", 200);
            btnSearch.Click += btnSearch_Click;
            lvResults.DoubleClick += lvResults_DoubleClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void lvResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lvResults_DoubleClick(object sender, EventArgs e)
        {
            if (lvResults.SelectedItems.Count > 0)
            {
                string videoId = lvResults.SelectedItems[0].SubItems[1].Text;
                string videoUrl = $"https://www.youtube.com/watch?v={videoId}";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = videoUrl,
                    UseShellExecute = true
                });
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string apiKey = "AIzaSyAH4hG-9Y2HVRuDCbA8ei9VFDDDMK4J1B4"; // Replace this with your actual API key
            string query = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a topic to search.");
                return;
            }

            string url = $"https://www.googleapis.com/youtube/v3/search?part=snippet&q={query}&maxResults=5&type=video&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(json);

                    lvResults.Items.Clear(); // Clear old results

                    foreach (var item in result.items)
                    {
                        string title = item.snippet.title.ToString();
                        string videoId = item.id.videoId.ToString();

                        ListViewItem listItem = new ListViewItem(title);
                        listItem.SubItems.Add(videoId);
                        lvResults.Items.Add(listItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching videos: " + ex.Message);
                }
            }
        }
    }
}
