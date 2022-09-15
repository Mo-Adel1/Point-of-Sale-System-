using POFDemo.DB;
using POFDemo.Screens.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POFDemo.Screens.Categories
{
    public partial class CategoriesForm : Form
    {
        POSDEMOEntities db;
        static CategoriesForm form;
        private static readonly object obj = new object();
        private CategoriesForm()
        {
            InitializeComponent();
        }
        public static CategoriesForm CreateForm()
        {

            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new CategoriesForm();
                    }
                }

            }
            return form;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            db = new POSDEMOEntities();
            // TODO: This line of code loads data into the 'pOSDEMODataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pOSDEMODataSet1.Category);

        }

        private void linkLabelAddCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string categoryname = textCategory.Text;
            if(string.IsNullOrEmpty(categoryname))
            {
                MessageBox.Show("برجاء ادخال اسم الصنف اولا");
                return;
            }
            var categoriesList = db.Categories.Where(x => x.Name == categoryname).ToList(); 
            if(categoriesList.Count != 0)
            {
                MessageBox.Show("هذا الصنف موجود بالفعل");
                return;
            }
      
            Category category = new Category();
            category.Name = categoryname;
            db.Categories.Add(category);
            
            db.SaveChanges();
            MessageBox.Show("تم إضافة التصنيف بنجاح");
            // TODO: This line of code loads data into the 'pOSDEMODataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.pOSDEMODataSet1.Category);
            ProductForm.CreateForm().RefreshCategory();
        }

        private void linkLabelDeletCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(comboBoxCategory.SelectedItem!=null)
            {
                var category = db.Categories.SingleOrDefault(x => x.id == (int)comboBoxCategory.SelectedValue);
                db.Categories.Remove(category);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("لا يمكن حذف هذا التصنيف لاحتوائه علي المنتجات");
                    return;
                }
                MessageBox.Show("تم حذف العنصر بنجاح");
                // TODO: This line of code loads data into the 'pOSDEMODataSet1.Category' table. You can move, or remove it, as needed.
                this.categoryTableAdapter.Fill(this.pOSDEMODataSet1.Category);
                ProductForm.CreateForm().RefreshCategory();
            }
            else
            {
                MessageBox.Show("اختار التصنيف المراد حذف أولا");
            }
        }
    }
}
