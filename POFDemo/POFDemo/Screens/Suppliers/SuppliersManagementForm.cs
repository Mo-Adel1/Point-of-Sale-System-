using POFDemo.DB;
using POFDemo.Screens.Suppliers;
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

namespace POFDemo.Screens.Suppliers
{
    public partial class SuppliersManagementForm : Form
    {
        POSDEMOEntities db;
        string imagepath = null;
        int id;
        int counter = 0;
        bool isImageLoaded = false;

        static SuppliersManagementForm form;
        private static readonly object obj = new object();
        private SuppliersManagementForm()
        {
            InitializeComponent();
        }
        public static SuppliersManagementForm CreateForm()
        {

            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new SuppliersManagementForm();
                    }
                }

            }
            return form;
        }


        private void SuppliersManagementForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        float pagesfloat;
        int pagesint;
        public void FormLoad()
        {
            db = new POSDEMOEntities();
            dataGridView1.DataSource = db.Suppliers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
            dataGridView1.Columns.RemoveAt(8);
            pagesfloat = db.Suppliers.Count() / 20f;
            pagesint = db.Suppliers.Count() / 20;
            if (pagesfloat - pagesint != 0)
            {
                pagesint += 1;
            }
            SupplierPictureBox.Hide();
            try
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                ShowSupplierInfo(id);
            }
            catch
            {

            }

        }
        private void ShowSupplierInfo(int _id)
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(x => x.Id == _id);
            if (supplier == null)
            {
                dataGridView1.DataSource = db.Suppliers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(8);
                pagesfloat = db.Suppliers.Count() / 20f;
                pagesint = db.Suppliers.Count() / 20;
                if (pagesfloat - pagesint != 0)
                {
                    pagesint += 1;
                }
                return;
            }
            textBoxName.Text = supplier.Name;
            textAddress.Text = supplier.Address;
            textNotes.Text = supplier.Notes;
            textPhone.Text = supplier.Phone;
            textCompny.Text = supplier.Company;
            textEmail.Text = supplier.Email;
            checkBoxActive.Checked = supplier.IsActive.Value;
            SupplierPictureBox.ImageLocation = supplier.Image;
            if (supplier.Image != null)
            {
                linkLabelAddImage.Hide();
                SupplierPictureBox.Show();
            }
            else
            {
                linkLabelAddImage.Show();
                SupplierPictureBox.Hide();
            }
        }
        private void Update()
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(x => x.Id == id);
            supplier.Name = textBoxName.Text;
            supplier.Address = textAddress.Text;
            supplier.Notes = textNotes.Text;
            supplier.Phone = textPhone.Text;
            supplier.Company = textCompny.Text;
            supplier.Email = textEmail.Text;
            supplier.IsActive = checkBoxActive.Checked;
            db.SaveChanges();
            if (!string.IsNullOrEmpty(imagepath))
            {
                string newpath = Environment.CurrentDirectory + $"\\Images\\Suppliers\\{supplier.Id}.png";
                File.Copy(imagepath, newpath, true);
                supplier.Image = newpath;
                db.SaveChanges();
                imagepath = null;
            }
            int lastid = id;
            FormLoad();
            MessageBox.Show("تم تعديل بيانات المورد");
        }

        private void butٍSaveChanges_Click(object sender, EventArgs e)
        {
            Supplier supplier = db.Suppliers.SingleOrDefault(x => x.Id == id);
            if (string.IsNullOrEmpty(textPhone.Text) || string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("! برجاء ادخال البيانات اللازمة");
                return;
            }
            if
            (
                textBoxName.Text == supplier.Name &&
                textAddress.Text == supplier.Address &&
                textNotes.Text == supplier.Notes &&
                textPhone.Text == supplier.Phone &&
                textCompny.Text == supplier.Company &&
                textEmail.Text == supplier.Email &&
                checkBoxActive.Checked == supplier.IsActive.Value &&
                SupplierPictureBox.ImageLocation == supplier.Image
            )
            {
                MessageBox.Show("لم يتم اجراء أي تعديلات");
                return;
            }
            try
            {
                Supplier supplier2 = db.Suppliers.SingleOrDefault(x => x.Name == textBoxName.Text);
            }
            catch
            {
                MessageBox.Show("!اسم المورد هذا موجود");
                return;
            }
            var resulte = MessageBox.Show("سيتم تعديل بيانات العنصر المحدد! تأكيد التعديل ؟", "تأكيد التعديل", MessageBoxButtons.YesNo);
            if (resulte == DialogResult.Yes)
            {
                Update();
            }
        }

        private void SupplierPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                SupplierPictureBox.ImageLocation = openFileDialog.FileName;
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

        private void butDeleteSupplier_Click(object sender, EventArgs e)
        {
            var resulte = MessageBox.Show("سيتم حذف العنصر المحدد! تأكيد الحذف ؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
            if (resulte == DialogResult.Yes)
            {
                Supplier supplier = db.Suppliers.Find(id);
                int rowsnumber = dataGridView1.Rows.Count;
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
                MessageBox.Show(".تم الحذف");
                if (rowsnumber - 1 == 0)
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
                dataGridView1.DataSource = db.Suppliers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
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
                dataGridView1.DataSource = db.Suppliers.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(8);
                return;
            }
            if (counter == 0)
            {
                MessageBox.Show($"!لا يوجد صفحات أخري");
                return;
            }
        }

        private void butAddNewSupplier_Click(object sender, EventArgs e)
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
            var result = db.Suppliers.Where(x => x.Name == textBoxName.Text || x.Phone == textPhone.Text).ToList();
            if(result.Count != 0)
            {
                MessageBox.Show("!هذا العميل موجود مسبقا");
                textBoxName.Clear();
                textPhone.Clear();
                return;
            }
            Supplier supplier = new Supplier
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
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            FormLoad();
            if (!string.IsNullOrEmpty(imagepath))
            {
                string newpath = Environment.CurrentDirectory + $"\\Images\\Suppliers\\{supplier.Id}.png";
                File.Copy(imagepath, newpath, true);
                supplier.Image = newpath;
                db.SaveChanges();
                imagepath = null;
            }
            MessageBox.Show("تم إضافة المورد");
            butClean_Click(sender, e);
            last = null;
        }

        private void linkLabelAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierPictureBox_Click(sender, e);
            if (isImageLoaded)
            {
                linkLabelAddImage.Hide();
                SupplierPictureBox.Show();
            }
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            textMobile_search.Clear();
            textSupplierName.Clear();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {

            SuppliersManagementForm_Load(sender, e);
            butClean_Click(sender, e);
        }

        private void butSearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textMobile_search.Text) && string.IsNullOrEmpty(textSupplierName.Text))
            {
                dataGridView1.DataSource = db.Suppliers.Where(x => x.Phone == textMobile_search.Text).ToList();
                dataGridView1.Columns.RemoveAt(8);
                return;
            }
            if (string.IsNullOrEmpty(textMobile_search.Text) && !string.IsNullOrEmpty(textSupplierName.Text))
            {
                dataGridView1.DataSource = db.Suppliers.Where(x => x.Name.Contains(textSupplierName.Text)).ToList();
                dataGridView1.Columns.RemoveAt(8);
                return;
            }
            dataGridView1.DataSource = db.Suppliers.Where(x => x.Name.Contains(textSupplierName.Text) || x.Phone == textMobile_search.Text).ToList();
            dataGridView1.Columns.RemoveAt(8);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            ShowSupplierInfo(id);
        }
    }
}
