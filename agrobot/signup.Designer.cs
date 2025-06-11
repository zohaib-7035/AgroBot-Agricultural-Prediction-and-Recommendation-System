namespace agrobot
{
    partial class signup
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
            label1 = new Label();
            label2 = new Label();
            Username = new TextBox();
            UserEmail = new TextBox();
            label3 = new Label();
            UserPwd = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(424, 48);
            label1.Name = "label1";
            label1.Size = new Size(202, 27);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(375, 97);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // Username
            // 
            Username.Location = new Point(424, 125);
            Username.Name = "Username";
            Username.Size = new Size(249, 31);
            Username.TabIndex = 2;
            Username.TextChanged += txtName_TextChanged;
            // 
            // UserEmail
            // 
            UserEmail.Location = new Point(424, 198);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(249, 31);
            UserEmail.TabIndex = 4;
            UserEmail.TextChanged += email_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(375, 170);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // UserPwd
            // 
            UserPwd.Location = new Point(424, 273);
            UserPwd.Name = "UserPwd";
            UserPwd.Size = new Size(249, 31);
            UserPwd.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(375, 245);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.abc;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 463);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(490, 343);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 499);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(UserPwd);
            Controls.Add(label4);
            Controls.Add(UserEmail);
            Controls.Add(label3);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "signup";
            Text = "signup";
            Load += signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        //private TextBox textBox1;
        //private TextBox textBox2;
        private Label label3;
       // private TextBox textBox3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox Username;
        private TextBox UserEmail;
        private TextBox UserPwd;
    }
}