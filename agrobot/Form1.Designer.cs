namespace agrobot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            textEmail = new TextBox();
            textpassword = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.farmland;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 514);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(475, 110);
            label1.Name = "label1";
            label1.Size = new Size(133, 35);
            label1.TabIndex = 1;
            label1.Text = "Agrobot";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Olive;
            label2.Location = new Point(376, 196);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 2;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_17740782;
            pictureBox2.Location = new Point(363, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(363, 339);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(417, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Location = new Point(414, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(417, 287);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 1);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(420, 287);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 1);
            panel4.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Location = new Point(420, 374);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 1);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(420, 371);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 1);
            panel6.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(475, 405);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textEmail
            // 
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Cursor = Cursors.IBeam;
            textEmail.Font = new Font("Sans Serif Collection", 7.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textEmail.ForeColor = Color.Olive;
            textEmail.Location = new Point(420, 253);
            textEmail.MaxLength = 20;
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "username";
            textEmail.Size = new Size(230, 29);
            textEmail.TabIndex = 12;
            textEmail.TextAlign = HorizontalAlignment.Center;
            textEmail.TextChanged += textBox1_TextChanged_1;
            // 
            // textpassword
            // 
            textpassword.BorderStyle = BorderStyle.None;
            textpassword.Cursor = Cursors.IBeam;
            textpassword.Font = new Font("Sans Serif Collection", 7.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textpassword.ForeColor = Color.Olive;
            textpassword.HideSelection = false;
            textpassword.Location = new Point(423, 340);
            textpassword.MaxLength = 16;
            textpassword.Multiline = true;
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '*';
            textpassword.PlaceholderText = "password";
            textpassword.Size = new Size(230, 31);
            textpassword.TabIndex = 0;
            textpassword.TextAlign = HorizontalAlignment.Center;
            textpassword.UseSystemPasswordChar = true;
            textpassword.WordWrap = false;
            textpassword.TextChanged += textpassword_TextChanged_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Olive;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(506, 454);
            button2.Name = "button2";
            button2.Size = new Size(150, 34);
            button2.TabIndex = 13;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(718, 514);
            Controls.Add(button2);
            Controls.Add(textpassword);
            Controls.Add(textEmail);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Olive;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button button1;
        private TextBox textEmail;
        private TextBox textpassword;
        private Button button2;
    }
}
