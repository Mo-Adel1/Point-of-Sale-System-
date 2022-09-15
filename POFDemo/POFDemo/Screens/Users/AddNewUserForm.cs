using POFDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POFDemo
{
    public partial class AddNewUserForm : Form
    {
        POSDEMOEntities db;
        string imagepath = "";
        static AddNewUserForm form;
        private static readonly object obj = new object();
        private AddNewUserForm()
        {
            InitializeComponent();
        }
        public static AddNewUserForm CreateForm()
        {

            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new AddNewUserForm();
                    }
                }

            }
            return form;
        }
        
        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            FormResize();
            db = new POSDEMOEntities();
            toolTipShowPassword.SetToolTip(butShowPassword, "إظهار كلمة المرور");
            UserPictureBox.Hide();
        }

        private void FormResize()
        {
            this.Size = new Size(726, 308);
            this.MaximumSize = new Size(726, 308);
            this.MinimumSize = new Size(726, 308);
            butAddNewUser.Location = new Point(88, 188);
            butClean.Location = new Point(9, 193);
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            FormResize();
            textUserName.Clear();
            textPassword.Clear();
            UserPictureBox.Image = null;
            UserPictureBox.Hide();
            linkLabelAddImage.Show();
        }
        private void butAddNewUser_Click(object sender, EventArgs e)
        {
            string username = textUserName.Text;
            string password = textPassword.Text;
            
            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("! برجاء ادخال البيانات كاملة");
                return;
            }
            if(username.Contains(" ") || password.Contains(" "))
            {
                MessageBox.Show("! لا يمكن أن يحتوي اسم المستخدم أو كلمة المرور علي أي مسافات");
                return;
            }
            if(username.Length < 8)
            {
                MessageBox.Show("! يجب ألا يقل اسم المستخدم عن ثمان أحرف أو رموز أو أرقام");
                return;
            }
            if (password.Length < 10)
            {
                MessageBox.Show("! يجب ألا تقل كلمة المرور عن عشرة أحرف أو رموز أو أرقام");
                return;
            }
            var checkuser = db.Users.Where(x => x.Username == username);
            if (checkuser.Count() != 0)
            {
                MessageBox.Show(".اسم المستخدم هذا محجوز من قبل! برجاء اختيار اسم مستخدم أخر");
                return;
            }
            User user = new User
            {
                Username = textUserName.Text,
                Password = textPassword.Text,
            };
            db.Users.Add(user);
            db.SaveChanges();
            if (!string.IsNullOrEmpty(imagepath))
            {
                string newpath = Environment.CurrentDirectory + $"\\Images\\Users\\{user.Id}.png";
                File.Copy(imagepath, newpath, true);
                user.Image = newpath;
                db.SaveChanges();
            }
            MessageBox.Show("تم إضافة مستخدم جديد");
            butClean_Click(sender, e);  
        }

        bool isPasswordHiden = true;
        private void butShowPassword_Click(object sender, EventArgs e)
        {
            if (isPasswordHiden)
            {
                toolTipShowPassword.SetToolTip(butShowPassword, "اخفاء كلمة المرور");
                butShowPassword.BackgroundImage = global::POFDemo.Properties.Resources.hide;
            }
            else
            {
                toolTipShowPassword.SetToolTip(butShowPassword, "إظهار كلمة المرور");
                butShowPassword.BackgroundImage = global::POFDemo.Properties.Resources.show;
            }


            isPasswordHiden = !isPasswordHiden;
            textPassword.UseSystemPasswordChar = !textPassword.UseSystemPasswordChar;
        }

        private void linkLabelAddUserImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        bool isImageLoaded = false;
        private void UserPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                UserPictureBox.ImageLocation = openFileDialog.FileName;
                isImageLoaded = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPictureBox_Click(sender, e);
            if (isImageLoaded)
            {
                this.Size = new Size(726, 478);
                this.MaximumSize = new Size(726, 478);
                this.MinimumSize = new Size(726, 478);
                butAddNewUser.Location = new Point(10, 284);
                butClean.Location = new Point(14, 370);
                linkLabelAddImage.Hide();
                UserPictureBox.Show();
            }
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUserName.Text))
                labelRequier1.Show();
            else
                labelRequier1.Hide();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPassword.Text))
                labelRequier2.Show();
            else
                labelRequier2.Hide();
        }
    }
}
