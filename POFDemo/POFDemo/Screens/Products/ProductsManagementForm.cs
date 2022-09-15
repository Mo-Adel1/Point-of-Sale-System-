using POFDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POFDemo.Screens.Products
{
    public partial class ProductsManagementForm : Form
    {
        POSDEMOEntities db;
        string imagepath = null;
        int id;
        int counter = 0;

        static ProductsManagementForm form;
        private static readonly object obj = new object();
        private ProductsManagementForm()
        {
            InitializeComponent();
        }
        public static ProductsManagementForm CreateForm()
        {

            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new ProductsManagementForm();
                    }
                }

            }
            return form;
        }

        private void ProductsManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDEMODataSet2.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pOSDEMODataSet2.Category);
            FormLoad(false);
        }
        float pagesfloat;
        int pagesint;
        public void FormLoad(bool itemadded)
        {
            db = new POSDEMOEntities();
            dataGridView1.DataSource = db.Products.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
            if (itemadded && dataGridView1.Rows.Count==20)
            {
                pagesint += 1;
                counter += 1;
                dataGridView1.DataSource = db.Products.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
            }
            dataGridView1.Columns.RemoveAt(6);
            pagesfloat = db.Products.Count() / 20f;
            pagesint = db.Products.Count() / 20;
            if (pagesfloat - pagesint != 0)
            {
                pagesint += 1;
            }
            ProductPictureBox.Hide();
            try 
            {
                id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                ShowProdutInfo(id);
            } catch { }
            
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBarcode.Text) && string.IsNullOrEmpty(textProductName.Text))
            {
                dataGridView1.DataSource = db.Products.Where(x => x.Code == textBarcode.Text).ToList();
                dataGridView1.Columns.RemoveAt(6);
                return;
            }
            if (string.IsNullOrEmpty(textBarcode.Text) && !string.IsNullOrEmpty(textProductName.Text))
            {
                dataGridView1.DataSource = db.Products.Where(x => x.Name.Contains(textProductName.Text)).ToList();
                dataGridView1.Columns.RemoveAt(6);
                return;
            }
            dataGridView1.DataSource = db.Products.Where(x => x.Name.Contains(textProductName.Text) || x.Code == textBarcode.Text).ToList();
            dataGridView1.Columns.RemoveAt(6);
        }
      
        private void butRefresh_Click(object sender, EventArgs e)
        {
            ProductsManagementForm_Load(sender, e);
            butClean_Click(sender, e);
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            textBarcode.Clear();
            textProductName.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            ShowProdutInfo(id);
        }
        private void ShowProdutInfo(int _id)
        {
            Product product = db.Products.SingleOrDefault(x => x.Id == _id);
            if(product == null)
            {
                dataGridView1.DataSource = db.Products.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(6);
                pagesfloat = db.Products.Count() / 20f;
                pagesint = db.Products.Count() / 20;
                if (pagesfloat - pagesint != 0)
                {
                    pagesint += 1;
                }
                return;
            }
            textBoxCode.Text = product.Code;
            textBoxName.Text = product.Name;
            textNotes.Text = product.Notes;
            numericUpDownPrice.Value = (decimal)product.Price;
            numericUpDownQuantity.Value = (decimal)product.Quantity;
            ProductPictureBox.ImageLocation = product.Image;
            if (product.Image != null)
            {
                linkLabelAddImage.Hide();
                ProductPictureBox.Show();
            }
            else
            {
                linkLabelAddImage.Show();
                ProductPictureBox.Hide();
            }
            if(product.CategoryId != null)
            {
                comboBoxCategory.SelectedValue = product.CategoryId;
            }
            
        }
        private void Update()
        {
            Product product = db.Products.SingleOrDefault(x => x.Id == id);
            string lastBarCode = product.Code;
            if (string.IsNullOrEmpty(textBoxCode.Text) || string.IsNullOrEmpty(textBoxName.Text)||comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("! برجاء ادخال البيانات اللازمة");
                return;
            }
            if (lastBarCode != textBoxCode.Text)
            {
                var checkproduct = db.Products.Where(x => x.Code == textBoxCode.Text);
                if (checkproduct.Count() != 0)
                {
                    MessageBox.Show(".كود هذا المنتج موجود بالفعل");
                    return;
                }
                goto Label1;
            }

            if
            (
                product.Name == textBoxName.Text &&
                product.Notes == textNotes.Text &&
                product.Price == (decimal)numericUpDownPrice.Value &&
                product.Quantity == (int)numericUpDownQuantity.Value &&
                product.Image == ProductPictureBox.ImageLocation&&
                product.CategoryId == (int)comboBoxCategory.SelectedValue
            )
            { return; }
        Label1:
            product.Code = textBoxCode.Text;
            product.Name = textBoxName.Text;
            product.Notes = textNotes.Text;
            product.Price = numericUpDownPrice.Value;
            product.Quantity = (int)numericUpDownQuantity.Value;
            product.CategoryId = (int)comboBoxCategory.SelectedValue;
            db.SaveChanges();
            if (!string.IsNullOrEmpty(imagepath))
            {
                string newpath = Environment.CurrentDirectory + $"\\Images\\Products\\{product.Id}.png";
                File.Copy(imagepath, newpath, true);
                product.Image = newpath;
                db.SaveChanges();
                imagepath = null;
            }
            int lastid = id;
            
            MessageBox.Show("تم تعديل المنتج");
        }
        private void butٍSaveChanges_Click(object sender, EventArgs e)
        {
            var resulte = MessageBox.Show("سيتم تعديل بيانات العنصر المحدد! تأكيد التعديل ؟", "تأكيد التعديل", MessageBoxButtons.YesNo);
            if (resulte == DialogResult.Yes)
            {
                Update();
            }
        }
        bool isImageLoaded = false;
        private void linkLabelAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductPictureBox_Click(sender, e);
            if (isImageLoaded)
            {
                linkLabelAddImage.Hide();
                ProductPictureBox.Show();
            }
        }
        private void ProductPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = openFileDialog.FileName;
                ProductPictureBox.ImageLocation = openFileDialog.FileName;
                isImageLoaded = true;
            }
        }

        string last;
        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCode.Text))
                return;
            else
            {
                try
                {
                    ulong.Parse(textBoxCode.Text);
                    last = textBoxCode.Text;
                }
                catch
                {
                    MessageBox.Show("! يتكون الكود من أرقام صحيحة فقط");
                    textBoxCode.Text = last;
                };
            }
        }

        private void butDeleteProduct_Click(object sender, EventArgs e)
        {
            var resulte = MessageBox.Show("سيتم حذف العنصر المحدد! تأكيد الحذف ؟","تأكيد الحذف" ,MessageBoxButtons.YesNo);
            if(resulte == DialogResult.Yes)
            {
                Product product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                MessageBox.Show(".تم الحذف");
                try
                {
                    FormLoad(false);
                }
                catch 
                {
                    dataGridView1.DataSource = db.Products.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                    if(dataGridView1.Rows.Count == 0)
                    {
                        pagesint -= 1;
                        counter -= 1;
                        dataGridView1.DataSource = db.Products.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                    }
                    dataGridView1.Columns.RemoveAt(6);
                    pagesfloat = db.Products.Count() / 20f;
                    pagesint = db.Products.Count() / 20;
                    if (pagesfloat - pagesint != 0)
                    {
                        pagesint += 1;
                    }
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm.CreateForm().Show();
        }
        
        private void butNext_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{db.Products.Count()},{pagesint}, {pagesfloat}, {pagesfloat - pagesint}, {counter}");   
            if(pagesint > 1 && counter != pagesint-1)
            {
                counter++;
                dataGridView1.DataSource = db.Products.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(6);
            }
            else
            {
                MessageBox.Show($"!لا يوجد صفحات أخري");
            }
        }

        private void butPrevious_Click(object sender, EventArgs e)
        {
            if(counter >= 1)
            {
                counter--;
                dataGridView1.DataSource = db.Products.OrderBy(x => x.Id).Skip(counter * 20).Take(20).ToList();
                dataGridView1.Columns.RemoveAt(6);
                return;
            }
            if (counter == 0)
            {
                MessageBox.Show($"!لا يوجد صفحات أخري");
                return;
            }    
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = (int)comboBoxSearch.SelectedValue;
            //dataGridView1.DataSource = db.Products.Where(x => x.CategoryId == index).ToList();
        }
    }
}
