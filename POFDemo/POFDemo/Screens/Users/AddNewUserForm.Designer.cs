namespace POFDemo
{
    partial class AddNewUserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUserForm));
            this.labelPassWord = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelUsernName = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.butAddNewUser = new System.Windows.Forms.Button();
            this.butClean = new System.Windows.Forms.Button();
            this.labelImage = new System.Windows.Forms.Label();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTipAddNewUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClean = new System.Windows.Forms.ToolTip(this.components);
            this.butShowPassword = new System.Windows.Forms.Button();
            this.toolTipShowPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPictureBox = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelAddImage = new System.Windows.Forms.LinkLabel();
            this.labelRequier2 = new System.Windows.Forms.Label();
            this.labelRequier1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassWord
            // 
            this.labelPassWord.AutoSize = true;
            this.labelPassWord.BackColor = System.Drawing.Color.Transparent;
            this.labelPassWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassWord.Font = new System.Drawing.Font("Arabic Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassWord.Location = new System.Drawing.Point(525, 114);
            this.labelPassWord.Name = "labelPassWord";
            this.labelPassWord.Size = new System.Drawing.Size(105, 40);
            this.labelPassWord.TabIndex = 11;
            this.labelPassWord.Text = "كلمة المرور";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(97, 118);
            this.textPassword.MaxLength = 50;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(375, 35);
            this.textPassword.TabIndex = 10;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // labelUsernName
            // 
            this.labelUsernName.AutoSize = true;
            this.labelUsernName.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUsernName.Font = new System.Drawing.Font("Arabic Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernName.Location = new System.Drawing.Point(514, 50);
            this.labelUsernName.Name = "labelUsernName";
            this.labelUsernName.Size = new System.Drawing.Size(130, 40);
            this.labelUsernName.TabIndex = 9;
            this.labelUsernName.Text = "اسم المستخدم";
            // 
            // textUserName
            // 
            this.textUserName.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textUserName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(97, 61);
            this.textUserName.MaxLength = 50;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(375, 35);
            this.textUserName.TabIndex = 8;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            // 
            // butAddNewUser
            // 
            this.butAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.butAddNewUser.BackgroundImage = global::POFDemo.Properties.Resources.add;
            this.butAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddNewUser.FlatAppearance.BorderSize = 0;
            this.butAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddNewUser.Location = new System.Drawing.Point(10, 284);
            this.butAddNewUser.Name = "butAddNewUser";
            this.butAddNewUser.Size = new System.Drawing.Size(77, 71);
            this.butAddNewUser.TabIndex = 7;
            this.toolTipAddNewUser.SetToolTip(this.butAddNewUser, "إضافة المستخدم");
            this.butAddNewUser.UseVisualStyleBackColor = false;
            this.butAddNewUser.Click += new System.EventHandler(this.butAddNewUser_Click);
            // 
            // butClean
            // 
            this.butClean.BackColor = System.Drawing.Color.Transparent;
            this.butClean.BackgroundImage = global::POFDemo.Properties.Resources.cleaning;
            this.butClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClean.FlatAppearance.BorderSize = 0;
            this.butClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClean.Location = new System.Drawing.Point(14, 370);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(66, 57);
            this.butClean.TabIndex = 13;
            this.toolTipClean.SetToolTip(this.butClean, "تنظيف البيانات المدخلة");
            this.butClean.UseVisualStyleBackColor = false;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.BackColor = System.Drawing.Color.Transparent;
            this.labelImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelImage.Font = new System.Drawing.Font("Arabic Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImage.Location = new System.Drawing.Point(506, 179);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(148, 40);
            this.labelImage.TabIndex = 14;
            this.labelImage.Text = "صورة المستخدم";
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserPictureBox.Location = new System.Drawing.Point(209, 188);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(263, 148);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPictureBox.TabIndex = 15;
            this.UserPictureBox.TabStop = false;
            this.toolTipPictureBox.SetToolTip(this.UserPictureBox, "اضغط هنا لتغير الصورة");
            this.UserPictureBox.Click += new System.EventHandler(this.UserPictureBox_Click);
            // 
            // butShowPassword
            // 
            this.butShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.butShowPassword.BackgroundImage = global::POFDemo.Properties.Resources.show;
            this.butShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShowPassword.FlatAppearance.BorderSize = 0;
            this.butShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShowPassword.Location = new System.Drawing.Point(43, 115);
            this.butShowPassword.Name = "butShowPassword";
            this.butShowPassword.Size = new System.Drawing.Size(41, 42);
            this.butShowPassword.TabIndex = 16;
            this.butShowPassword.UseVisualStyleBackColor = false;
            this.butShowPassword.Click += new System.EventHandler(this.butShowPassword_Click);
            // 
            // linkLabelAddImage
            // 
            this.linkLabelAddImage.AutoSize = true;
            this.linkLabelAddImage.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAddImage.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAddImage.Location = new System.Drawing.Point(291, 185);
            this.linkLabelAddImage.Name = "linkLabelAddImage";
            this.linkLabelAddImage.Size = new System.Drawing.Size(94, 31);
            this.linkLabelAddImage.TabIndex = 17;
            this.linkLabelAddImage.TabStop = true;
            this.linkLabelAddImage.Text = "إضافة صورة";
            this.linkLabelAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelRequier2
            // 
            this.labelRequier2.AutoSize = true;
            this.labelRequier2.BackColor = System.Drawing.Color.White;
            this.labelRequier2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRequier2.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequier2.ForeColor = System.Drawing.Color.Red;
            this.labelRequier2.Location = new System.Drawing.Point(101, 120);
            this.labelRequier2.Name = "labelRequier2";
            this.labelRequier2.Size = new System.Drawing.Size(24, 31);
            this.labelRequier2.TabIndex = 40;
            this.labelRequier2.Text = "*";
            // 
            // labelRequier1
            // 
            this.labelRequier1.AutoSize = true;
            this.labelRequier1.BackColor = System.Drawing.Color.White;
            this.labelRequier1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRequier1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequier1.ForeColor = System.Drawing.Color.Red;
            this.labelRequier1.Location = new System.Drawing.Point(101, 63);
            this.labelRequier1.Name = "labelRequier1";
            this.labelRequier1.Size = new System.Drawing.Size(24, 31);
            this.labelRequier1.TabIndex = 39;
            this.labelRequier1.Text = "*";
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 439);
            this.Controls.Add(this.labelRequier2);
            this.Controls.Add(this.labelRequier1);
            this.Controls.Add(this.linkLabelAddImage);
            this.Controls.Add(this.butShowPassword);
            this.Controls.Add(this.UserPictureBox);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.labelPassWord);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.labelUsernName);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.butAddNewUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 478);
            this.Name = "AddNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستخدم جديد";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPassWord;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelUsernName;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Button butAddNewUser;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.ToolTip toolTipAddNewUser;
        private System.Windows.Forms.ToolTip toolTipClean;
        private System.Windows.Forms.Button butShowPassword;
        private System.Windows.Forms.ToolTip toolTipShowPassword;
        private System.Windows.Forms.ToolTip toolTipPictureBox;
        private System.Windows.Forms.LinkLabel linkLabelAddImage;
        private System.Windows.Forms.Label labelRequier2;
        private System.Windows.Forms.Label labelRequier1;
    }
}