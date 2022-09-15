using POFDemo.DB;
using POFDemo.Screens.Categories;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POFDemo.Screens.Products
{
    public partial class ProductForm : Form
    {
        POSDEMOEntities db;
        string imagepath = null;
        static ProductForm form;
        private static readonly object obj = new object();
        private ProductForm()
        {
            InitializeComponent();
        }
        public static ProductForm CreateForm()
        {

            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new ProductForm();
                    }
                }

            }
            return form;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDEMODataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pOSDEMODataSet.Category);
            FormLoad();
        }
        public void RefreshCategory()
        {
            this.categoryTableAdapter.Fill(this.pOSDEMODataSet.Category);
        }
        private void FormLoad()
        {
            db = new POSDEMOEntities();  
            ProductPictureBox.Hide();
        }
       
        string last;
        private void textBarcode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBarcode.Text))
                labelRequier1.Show();
            else
            {
                labelRequier1.Hide();
                try
                {
                    ulong.Parse(textBarcode.Text);
                    last = textBarcode.Text;
                }
                catch
                {
                    MessageBox.Show("! يتكون الكود من أرقام صحيحة فقط");
                    textBarcode.Text = last;
                };
            }
               
        }

        private void textProductName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textProductName.Text))
                labelRequier2.Show();
            else
                labelRequier2.Hide();
        }

        private void butClean_Click(object sender, EventArgs e)
        {
            textBarcode.Clear();
            textProductName.Clear();
            textNotes.Clear();
            ProductPictureBox.Image = null;
            ProductPictureBox.Hide();
            numericUpDownPrice.Value = 0.00M;
            numericUpDownQuantity.Value = 0;
            linkLabelAddImage.Show();
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {

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
        private void butAddProduct_Click(object sender, EventArgs e)
        {
            string productcode = textBarcode.Text;
            string productname = textProductName.Text;
            decimal price = numericUpDownPrice.Value;
            string notes = textNotes.Text;
            int quantity = (int)numericUpDownQuantity.Value;
            if (string.IsNullOrEmpty(productcode) || string.IsNullOrEmpty(productname) || comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("! برجاء ادخال البيانات اللازمة");
                return;
            }
            int categoryid = int.Parse(comboBoxCategory.SelectedValue.ToString());
            var checkproduct = db.Products.Where(x => x.Code == productcode);
            if (checkproduct.Count() != 0)
            {
                MessageBox.Show(".كود هذا المنتج موجود بالفعل");
                return;
            }
            Product product = new Product
            {
                Code = productcode,
                Name = productname,
                Price = price,
                Quantity = quantity,
                Notes = notes,
                CategoryId = categoryid
            };
            db.Products.Add(product);
            db.SaveChanges();
            if (!string.IsNullOrEmpty(imagepath))
            {
                string newpath = Environment.CurrentDirectory + $"\\Images\\Products\\{product.Id}.png";
                File.Copy(imagepath, newpath, true);
                product.Image = newpath;
                db.SaveChanges();
                imagepath = null;
            }
        
            butClean_Click(sender, e);
        
            last = null;
            MessageBox.Show("تم إضافة المنتج");
            ProductsManagementForm frm = ProductsManagementForm.CreateForm();
            
            frm.FormLoad(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsManagementForm.CreateForm().Show();
        }

        private void butAddCategory_Click(object sender, EventArgs e)
        {
            CategoriesForm.CreateForm().Show();
        }

        private void labelRequier2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedValue == null)
            {
                labelRequier3.Show();
            }
            else
            {
                labelRequier3.Hide();
            }
        }
    }
}
