namespace AppForLessons
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
            pictureBox1 = new PictureBox();
            Login = new GroupBox();
            Password = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            User = new Label();
            Login_btn = new Button();
            Exit = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Login.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(312, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            Login.Controls.Add(Password);
            Login.Controls.Add(textBox2);
            Login.Controls.Add(textBox1);
            Login.Controls.Add(User);
            Login.Controls.Add(Login_btn);
            Login.Location = new Point(260, 168);
            Login.Name = "Login";
            Login.Size = new Size(274, 198);
            Login.TabIndex = 1;
            Login.TabStop = false;
            Login.Text = "Login";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(28, 79);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 4;
            Password.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 2;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(28, 34);
            User.Name = "User";
            User.Size = new Size(30, 15);
            User.TabIndex = 1;
            User.Text = "User";
            User.Click += label1_Click_1;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.Aqua;
            Login_btn.BackgroundImageLayout = ImageLayout.None;
            Login_btn.FlatAppearance.BorderSize = 0;
            Login_btn.ForeColor = SystemColors.ActiveCaptionText;
            Login_btn.Location = new Point(26, 136);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(206, 27);
            Login_btn.TabIndex = 0;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Location = new Point(372, 384);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 15);
            Exit.TabIndex = 5;
            Exit.TabStop = true;
            Exit.Text = "Exit";
            Exit.LinkClicked += Exit_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Login);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox Login;
        private TextBox textBox1;
        private Label User;
        private Button Login_btn;
        private Label Password;
        private TextBox textBox2;
        private LinkLabel Exit;
    }
}