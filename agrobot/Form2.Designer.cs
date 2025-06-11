namespace agrobot
{
    partial class Form2
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
            Agrobot = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(934, 411);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Agrobot
            // 
            Agrobot.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Agrobot.Location = new Point(392, 26);
            Agrobot.Name = "Agrobot";
            Agrobot.Size = new Size(150, 35);
            Agrobot.TabIndex = 1;
            Agrobot.Text = "Agrobot";
            Agrobot.TextAlign = HorizontalAlignment.Center;
            Agrobot.TextChanged += Agrobot_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(138, 94);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(634, 179);
            textBox2.TabIndex = 3;
            textBox2.Text = " Grow Smarter With Agrobot\r\nAn intelligent agro-advisory system that helps farmers make data-driven decisions by recommending the best crops based on time, climate, and soil conditions\r\n";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(392, 300);
            button1.Name = "button1";
            button1.Size = new Size(136, 41);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 477);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(Agrobot);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Agrobot;
        private TextBox textBox2;
        private Button button1;
    }
}