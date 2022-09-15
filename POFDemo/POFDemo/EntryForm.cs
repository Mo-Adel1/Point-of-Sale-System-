using POFDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POFDemo
{
    public partial class EntryForm : Form
    {
        POSDEMOEntities db;
        static EntryForm form;
        private static readonly object obj = new object ();
        private EntryForm()
        {
            InitializeComponent();
        }
        public static EntryForm CreateForm()
        {
                if (form == null || form.IsDisposed)
                {
                    lock (obj)
                        {
                            if (form == null || form.IsDisposed)
                            {
                                 form = new EntryForm();
                            }
                        }
                }
                return form;
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {
           toolTipShowPassword.SetToolTip(butShowPassword, "إظهار كلمة المرور");
           db = new POSDEMOEntities();
        }
        
       

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void butClean_Click(object sender, EventArgs e)
        {
            textPassword.Clear();
            textUserName.Clear();
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

        private void butLogin_Click(object sender, EventArgs e)
        {
            string username = textUserName.Text;
            string password = textPassword.Text;    
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("برجاء ادخال البيانات كاملة");
                return;
            }
            var user = db.Users.Where(x => x.Username == username && x.Password == password);
            if(user.Count() != 1)
            {
                MessageBox.Show("البيانات المدخلة غير صحيحة");
                return;
            }
            this.Close();
            Thread thread = new Thread(OpenNextForm);
            thread.SetApartmentState(ApartmentState.STA);   
            thread.Start();
        }
        private void OpenNextForm()
        {
            Application.Run(MainForm.CreateForm());
        }

        private void EntryForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                butLogin_Click(sender, e);
        }

        private void textUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                butLogin_Click(sender, e);
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                butLogin_Click(sender, e);
        }
    }
}
