namespace agrobot
{
    partial class Form4
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            recomendationTextArea = new RichTextBox();
            button1 = new Button();
            downloadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumSeaGreen;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 477);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGreen;
            textBox1.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 42);
            textBox1.TabIndex = 25;
            textBox1.Text = "Agrobot";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGreen;
            textBox2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(230, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 37);
            textBox2.TabIndex = 26;
            textBox2.Text = "Recommendations";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // recomendationTextArea
            // 
            recomendationTextArea.Location = new Point(87, 111);
            recomendationTextArea.Name = "recomendationTextArea";
            recomendationTextArea.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            recomendationTextArea.Size = new Size(597, 273);
            recomendationTextArea.TabIndex = 28;
            recomendationTextArea.Text = "\n\n";
            recomendationTextArea.TextChanged += richTextBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(628, 401);
            button1.Name = "button1";
            button1.Size = new Size(132, 41);
            button1.TabIndex = 42;
            button1.Text = "Next";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // downloadButton
            // 
            downloadButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            downloadButton.ForeColor = Color.DarkGreen;
            downloadButton.ImageAlign = ContentAlignment.BottomCenter;
            downloadButton.Location = new Point(390, 402);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(198, 40);
            downloadButton.TabIndex = 44;
            downloadButton.Text = "Download Report";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 477);
            Controls.Add(downloadButton);
            Controls.Add(button1);
            Controls.Add(recomendationTextArea);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox recomendationTextArea;
        private Button button1;
        private Button downloadButton;
    }
}