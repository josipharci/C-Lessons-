namespace AppForLessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_save = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPostNum = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostNum = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRecName = new System.Windows.Forms.Label();
            this.labelRecAddress = new System.Windows.Forms.Label();
            this.labelRecPost = new System.Windows.Forms.Label();
            this.groupBoxRec = new System.Windows.Forms.GroupBox();
            this.textBoxRecPostNum = new System.Windows.Forms.TextBox();
            this.textBoxRecAddress = new System.Windows.Forms.TextBox();
            this.textBoxRecName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp_date = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxRec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(605, 558);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(107, 28);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(13, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 16);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "YourName:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAddress.Location = new System.Drawing.Point(13, 54);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(61, 16);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address:";
            // 
            // labelPostNum
            // 
            this.labelPostNum.AutoSize = true;
            this.labelPostNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPostNum.Location = new System.Drawing.Point(13, 79);
            this.labelPostNum.Name = "labelPostNum";
            this.labelPostNum.Size = new System.Drawing.Size(68, 16);
            this.labelPostNum.TabIndex = 8;
            this.labelPostNum.Text = "Post Num:";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPhoneNum.Location = new System.Drawing.Point(13, 105);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(80, 16);
            this.labelPhoneNum.TabIndex = 9;
            this.labelPhoneNum.Text = "Phone Num:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(13, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(94, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(146, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(94, 50);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(146, 20);
            this.textBoxAddress.TabIndex = 12;
            // 
            // textBoxPostNum
            // 
            this.textBoxPostNum.Location = new System.Drawing.Point(94, 75);
            this.textBoxPostNum.Name = "textBoxPostNum";
            this.textBoxPostNum.Size = new System.Drawing.Size(146, 20);
            this.textBoxPostNum.TabIndex = 13;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(94, 101);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(146, 20);
            this.textBoxPhoneNum.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(94, 127);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(146, 20);
            this.textBoxEmail.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxPhoneNum);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.textBoxPostNum);
            this.groupBox1.Controls.Add(this.labelPostNum);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.labelPhoneNum);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Location = new System.Drawing.Point(85, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 168);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // labelRecName
            // 
            this.labelRecName.AutoSize = true;
            this.labelRecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecName.Location = new System.Drawing.Point(18, 24);
            this.labelRecName.Name = "labelRecName";
            this.labelRecName.Size = new System.Drawing.Size(47, 16);
            this.labelRecName.TabIndex = 17;
            this.labelRecName.Text = "Name:";
            // 
            // labelRecAddress
            // 
            this.labelRecAddress.AutoSize = true;
            this.labelRecAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecAddress.Location = new System.Drawing.Point(18, 51);
            this.labelRecAddress.Name = "labelRecAddress";
            this.labelRecAddress.Size = new System.Drawing.Size(61, 16);
            this.labelRecAddress.TabIndex = 18;
            this.labelRecAddress.Text = "Address:";
            // 
            // labelRecPost
            // 
            this.labelRecPost.AutoSize = true;
            this.labelRecPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecPost.Location = new System.Drawing.Point(18, 75);
            this.labelRecPost.Name = "labelRecPost";
            this.labelRecPost.Size = new System.Drawing.Size(68, 16);
            this.labelRecPost.TabIndex = 19;
            this.labelRecPost.Text = "Post Num:";
            // 
            // groupBoxRec
            // 
            this.groupBoxRec.Controls.Add(this.textBoxRecPostNum);
            this.groupBoxRec.Controls.Add(this.labelRecName);
            this.groupBoxRec.Controls.Add(this.textBoxRecAddress);
            this.groupBoxRec.Controls.Add(this.labelRecAddress);
            this.groupBoxRec.Controls.Add(this.textBoxRecName);
            this.groupBoxRec.Controls.Add(this.labelRecPost);
            this.groupBoxRec.Location = new System.Drawing.Point(438, 154);
            this.groupBoxRec.Name = "groupBoxRec";
            this.groupBoxRec.Size = new System.Drawing.Size(269, 104);
            this.groupBoxRec.TabIndex = 20;
            this.groupBoxRec.TabStop = false;
            this.groupBoxRec.Text = "Recipient";
            // 
            // textBoxRecPostNum
            // 
            this.textBoxRecPostNum.Location = new System.Drawing.Point(95, 71);
            this.textBoxRecPostNum.Name = "textBoxRecPostNum";
            this.textBoxRecPostNum.Size = new System.Drawing.Size(146, 20);
            this.textBoxRecPostNum.TabIndex = 23;
            // 
            // textBoxRecAddress
            // 
            this.textBoxRecAddress.Location = new System.Drawing.Point(94, 47);
            this.textBoxRecAddress.Name = "textBoxRecAddress";
            this.textBoxRecAddress.Size = new System.Drawing.Size(146, 20);
            this.textBoxRecAddress.TabIndex = 22;
            // 
            // textBoxRecName
            // 
            this.textBoxRecName.Location = new System.Drawing.Point(94, 20);
            this.textBoxRecName.Name = "textBoxRecName";
            this.textBoxRecName.Size = new System.Drawing.Size(146, 20);
            this.textBoxRecName.TabIndex = 21;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(254, 263);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(36, 16);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitle.Location = new System.Drawing.Point(257, 282);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(317, 26);
            this.textBoxTitle.TabIndex = 24;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(82, 329);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(630, 185);
            this.textBoxText.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 116);
            this.label1.TabIndex = 26;
            this.label1.Text = "T\r\nE\r\nX\r\nT";
            // 
            // Dtp_date
            // 
            this.Dtp_date.Location = new System.Drawing.Point(158, 540);
            this.Dtp_date.Name = "Dtp_date";
            this.Dtp_date.Size = new System.Drawing.Size(200, 20);
            this.Dtp_date.TabIndex = 27;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.Location = new System.Drawing.Point(79, 540);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 16);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Date:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(155, 566);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(146, 20);
            this.textBoxCity.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(79, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "City:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.Dtp_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxRec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Intellitest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRec.ResumeLayout(false);
            this.groupBoxRec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPostNum;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPostNum;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRecName;
        private System.Windows.Forms.Label labelRecAddress;
        private System.Windows.Forms.Label labelRecPost;
        private System.Windows.Forms.GroupBox groupBoxRec;
        private System.Windows.Forms.TextBox textBoxRecPostNum;
        private System.Windows.Forms.TextBox textBoxRecAddress;
        private System.Windows.Forms.TextBox textBoxRecName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_date;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label2;
    }
}