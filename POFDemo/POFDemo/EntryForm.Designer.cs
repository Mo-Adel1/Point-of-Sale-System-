namespace POFDemo
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.butLogin = new System.Windows.Forms.Button();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.butClean = new System.Windows.Forms.Button();
            this.butShowPassword = new System.Windows.Forms.Button();
            this.toolTipCleanBut = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipShowPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.Transparent;
            this.butLogin.BackgroundImage = global::POFDemo.Properties.Resources.login_circle_icon_206018;
            this.butLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.FlatAppearance.BorderSize = 0;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Location = new System.Drawing.Point(334, 188);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(56, 53);
            this.butLogin.TabIndex = 0;
            this.toolTipLogin.SetToolTip(this.butLogin, "دخول");
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // textUserName
            // 
            this.textUserName.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textUserName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(111, 68);
            this.textUserName.MaxLength = 50;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(375, 35);
            this.textUserName.TabIndex = 1;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUserName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "كلمة المرور";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(111, 125);
            this.textPassword.MaxLength = 50;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(375, 35);
            this.textPassword.TabIndex = 3;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPassword_KeyPress);
            // 
            // butClean
            // 
            this.butClean.BackColor = System.Drawing.Color.Transparent;
            this.butClean.BackgroundImage = global::POFDemo.Properties.Resources.cleaning;
            this.butClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClean.FlatAppearance.BorderSize = 0;
            this.butClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClean.Location = new System.Drawing.Point(8, 201);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(57, 54);
            this.butClean.TabIndex = 5;
            this.toolTipCleanBut.SetToolTip(this.butClean, "تنظيف البيانات المدخلة");
            this.butClean.UseVisualStyleBackColor = false;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // butShowPassword
            // 
            this.butShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.butShowPassword.BackgroundImage = global::POFDemo.Properties.Resources.show;
            this.butShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShowPassword.FlatAppearance.BorderSize = 0;
            this.butShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShowPassword.Location = new System.Drawing.Point(58, 121);
            this.butShowPassword.Name = "butShowPassword";
            this.butShowPassword.Size = new System.Drawing.Size(41, 42);
            this.butShowPassword.TabIndex = 6;
            this.butShowPassword.UseVisualStyleBackColor = false;
            this.butShowPassword.Click += new System.EventHandler(this.butShowPassword_Click);
            // 
            // toolTipCleanBut
            // 
            this.toolTipCleanBut.Tag = "";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 269);
            this.Controls.Add(this.butShowPassword);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.butLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(747, 308);
            this.MinimumSize = new System.Drawing.Size(747, 308);
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryForm_FormClosing);
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntryForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.Button butShowPassword;
        private System.Windows.Forms.ToolTip toolTipCleanBut;
        private System.Windows.Forms.ToolTip toolTipShowPassword;
        private System.Windows.Forms.ToolTip toolTipLogin;
    }
}

