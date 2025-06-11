namespace agrobot
{
    partial class Form6
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
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtQuestion = new TextBox();
            btnSubmit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(194, 34);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 0;
            label1.Text = "Leave Your Message...";
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 31);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 2;
            label2.Text = "AgroBot";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(40, 79);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(408, 79);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 4;
            label4.Text = "Question";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(40, 255);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(40, 168);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 6;
            label6.Text = "Phone No.";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(30, 207);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(221, 31);
            txtContact.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 292);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 31);
            txtEmail.TabIndex = 8;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(408, 123);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(367, 200);
            txtQuestion.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Ivory;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.DarkGreen;
            btnSubmit.Location = new Point(283, 358);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(595, 381);
            button1.Name = "button1";
            button1.Size = new Size(135, 34);
            button1.TabIndex = 11;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(txtQuestion);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtQuestion;
        private Button btnSubmit;
        private Button button1;
    }
}