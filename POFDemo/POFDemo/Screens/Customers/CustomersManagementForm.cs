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

namespace POFDemo.Screens.Customers
{
    public partial class CustomersManagementForm : Form
    {
        POSDEMOEntities db;
        string imagepath = null;
        int id;
        int counter = 0;
        bool isImageLoaded = false;

        static CustomersManagementForm form;
        private static readonly object obj = new object();
        private CustomersManagementForm()
        {
            InitializeComponent();
        }
        public static CustomersManagementForm CreateForm()
        {

            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new CustomersManagementForm();
                    }
                }

            }
            return form;
        }

        private void CustomersManagementForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        float pagesfloat;
        int pagesint;
        public void FormLoad()
        {
            db = new POSDEMOEntities();
            dataGridView1.DataSource = db.Customers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
            dataGridView1.Columns.RemoveAt(8);
            pagesfloat = db.Customers.Count() / 20f;
            pagesint = db.Customers.Count() / 20;
            if (pagesfloat - pagesint != 0)
            {
                pagesint += 1;
            }
            CustomerPictureBox.Hide();
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                ShowCustomerInfo(id);
            }
            catch
            {

            }
            
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textMobile_search.Text) && string.IsNullOrEmpty(textCustomerName.Text))
            {
                dataGridView1.DataSource = db.Customers.Where(x => x.Phone == textMobile_search.Text).ToList();
                dataGridView1.Columns.RemoveAt(8);
                return;
            }
            if (string.IsNullOrEmpty(textMobile_search.Text) && !string.IsNullOrEmpty(textCustomerName.Text))
            {
                dataGridView1.DataSource = db.Customers.Where(x => x.Name.Contains(textCustomerName.Text)).ToList();
                dataGridView1.Columns.RemoveAt(8);
                return;
            }
            dataGridView1.DataSource = db.Customers.Where(x => x.Name.Contains(textCustomerName.Text) || x.Phone == textMobile_search.Text).ToList();
            dataGridView1.Columns.RemoveAt(8);
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {

            CustomersManagementForm_Load(sender, e);
            butClean_Click(sender, e);
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            textMobile_search.Clear();
            textCustomerName.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            ShowCustomerInfo(id);
        }

        private void ShowCustomerInfo(int _id)
        {
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == _id);
            if (customer == null)
            {
                dataGridView1.DataSource = db.Customers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(8);
                pagesfloat = db.Customers.Count() / 20f;
                pagesint = db.Customers.Count() / 20;
                if (pagesfloat - pagesint != 0)
                {
                    pagesint += 1;
                }
                return;
            }
            textBoxName.Text = customer.Name;
            textAddress.Text = customer.Address;
            textNotes.Text = customer.Notes;
            textPhone.Text = customer.Phone;
            textCompny.Text = customer.Company;
            textEmail.Text = customer.Email;
            checkBoxActive.Checked = customer.IsActive.Value;
            CustomerPictureBox.ImageLocation = customer.Image;
            if (customer.Image != null)
            {
                linkLabelAddImage.Hide();
                CustomerPictureBox.Show();
            }
            else
            {
                linkLabelAddImage.Show();
                CustomerPictureBox.Hide();
            }
        }
        private void Update()
        {
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
            customer.Name = textBoxName.Text;
            customer.Address = textAddress.Text;
            customer.Notes = textNotes.Text;
            customer.Phone = textPhone.Text;
            customer.Company = textCompny.Text;
            customer.Email = textEmail.Text;
            customer.IsActive = checkBoxActive.Checked;
            db.SaveChanges();
            if (!string.IsNullOrEmpty(imagepath))
            {
                string newpath = Environment.CurrentDirectory + $"\\Images\\Customers\\{customer.Id}.png";
                File.Copy(imagepath, newpath, true);
                customer.Image = newpath;
                db.SaveChanges();
                imagepath = null;
            }
            int lastid = id;
            FormLoad();
            MessageBox.Show("تم تعديل العميل");
        }
       
        private void butٍSaveChanges_Click(object sender, EventArgs e)
        {
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
            if (string.IsNullOrEmpty(textPhone.Text) || string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("! برجاء ادخال البيانات اللازمة");
                return;
            }
            if
            (
                textBoxName.Text == customer.Name &&
                textAddress.Text == customer.Address &&
                textNotes.Text == customer.Notes &&
                textPhone.Text == customer.Phone &&
                textCompny.Text == customer.Company &&
                textEmail.Text == customer.Email &&
                checkBoxActive.Checked == customer.IsActive.Value &&
                CustomerPictureBox.ImageLocation == customer.Image
            )
            {
                MessageBox.Show("لم يتم اجراء أي تعديلات");
                return;
            }
            try 
            {
                Customer customer2 = db.Customers.SingleOrDefault(x => x.Name == textBoxName.Text);
            }
            catch
            {
                MessageBox.Show("!اسم العميل هذا موجود");
                return;
            }
            var resulte = MessageBox.Show("سيتم تعديل بيانات العنصر المحدد! تأكيد التعديل ؟", "تأكيد التعديل", MessageBoxButtons.YesNo);
            if (resulte == DialogResult.Yes)
            {
                Update();
            }
        }
        
        private void CustomerPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                CustomerPictureBox.ImageLocation = openFileDialog.FileName;
                isImageLoaded = true;
            }
        }

        string last;
        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPhone.Text))
                return;
            else
            {
                try
                {
                    ulong.Parse(textPhone.Text);
                    last = textPhone.Text;
                }
                catch
                {
                    MessageBox.Show("! يتكون رقم الموبايل من أرقام صحيحة فقط");
                    textPhone.Text = last;
                };
            }
        }

        private void butDeleteCustomer_Click(object sender, EventArgs e)
        {
            var resulte = MessageBox.Show("سيتم حذف العنصر المحدد! تأكيد الحذف ؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
            if (resulte == DialogResult.Yes)
            {
                Customer customer = db.Customers.Find(id);
                int rowsnumber = dataGridView1.Rows.Count;
                db.Customers.Remove(customer);
                db.SaveChanges();
                MessageBox.Show(".تم الحذف");
                if (rowsnumber-1 == 0)
                {
                    pagesint -= 1;
                    counter -= 1;
                }
                try { FormLoad(); } catch { FormLoad(); }
                
            }
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            if (pagesint > 1 && counter != pagesint - 1)
            {
                counter++;
                dataGridView1.DataSource = db.Customers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(8);
            }
            else
            {
                MessageBox.Show($"!لا يوجد صفحات أخري");
            }
        }

        private void butPrevious_Click(object sender, EventArgs e)
        {
            if (counter >= 1)
            {
                counter--;
                dataGridView1.DataSource = db.Customers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(8);
                return;
            }
            if (counter == 0)
            {
                MessageBox.Show($"!لا يوجد صفحات أخري");
                return;
            }
        }

        private void butAddNewCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string address = textAddress.Text;
            string notes = textNotes.Text;
            string phone = textPhone.Text;
            string company = textCompny.Text;
            string email = textEmail.Text;
            bool isActive = checkBoxActive.Checked;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("! برجاء ادخال البيانات اللازمة");
                return;
            }
            var result = db.Customers.Where(x => x.Name == textBoxName.Text || x.Phone == textPhone.Text).ToList();
            if (result.Count != 0)
            {
                MessageBox.Show("!هذا المورد موجود مسبقا");
                textBoxName.Clear();
                textPhone.Clear();
                return;
            }
            Customer customer = new Customer
            {
                Name = name,
                Address = address,
                Notes = notes,
                Phone = phone,
                Company = company,
                Email = email,
                IsActive = isActive
            };
            if (dataGridView1.Rows.Count == 20)
            {
                pagesint += 1;
                counter += 1;
            }
            db.Customers.Add(customer);
            db.SaveChanges();
            FormLoad();
            if (!string.IsNullOrEmpty(imagepath))
            {
                string newpath = Environment.CurrentDirectory + $"\\Images\\Customers\\{customer.Id}.png";
                File.Copy(imagepath, newpath, true);
                customer.Image = newpath;
                db.SaveChanges();
                imagepath = null;
            }
            MessageBox.Show("تم إضافة العميل");
            butClean_Click(sender, e);
            last = null;
        }

        private void linkLabelAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerPictureBox_Click(sender, e);
            if (isImageLoaded)
            {
                linkLabelAddImage.Hide();
                CustomerPictureBox.Show();
            }
        }
    }
}
