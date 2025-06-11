namespace agrobot
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            label1 = new Label();
            lvResults = new ListView();
            btnSearch = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.famer;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 440);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(381, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter the Topic";
            txtSearch.Size = new Size(291, 31);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(292, 25);
            label1.Name = "label1";
            label1.Size = new Size(518, 32);
            label1.TabIndex = 2;
            label1.Text = "\tEnter a topic and click Search to find videos.";
            label1.Click += label1_Click;
            // 
            // lvResults
            // 
            lvResults.Location = new Point(252, 130);
            lvResults.Name = "lvResults";
            lvResults.Size = new Size(596, 254);
            lvResults.TabIndex = 3;
            lvResults.UseCompatibleStateImageBehavior = false;
            lvResults.View = View.Details;
            lvResults.SelectedIndexChanged += lvResults_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.DarkGreen;
            btnSearch.Location = new Point(483, 406);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkGreen;
            button2.Location = new Point(775, 418);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Next\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(919, 464);
            Controls.Add(button2);
            Controls.Add(btnSearch);
            Controls.Add(lvResults);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Label label1;
        private ListView lvResults;
        private Button btnSearch;
        private Button button2;
    }
}