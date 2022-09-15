using POFDemo.DB;
using POFDemo.Screens.Products;
using POFDemo.Screens.SalesBill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POFDemo.Screens.SalesBill
{
    public partial class SalesBillForm : Form
    {
        POSDEMOEntities db = new POSDEMOEntities();
        List<Product> products;
        string imagepath = null;
        int id;
        int counter = 0;

        static SalesBillForm form;
        private static readonly object obj = new object();
        private SalesBillForm()
        {
            InitializeComponent();
            comboBoxCustomers.DataSource = db.Customers.Where(x => x.IsActive == true).ToList();
            comboBoxCustomers.ValueMember = "Id";
            comboBoxCustomers.DisplayMember = "Name";
            products = db.Products.ToList();
            imageList1.ImageSize = new Size(70, 70);
        }
        public static SalesBillForm CreateForm()
        {

            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new SalesBillForm();
                    }
                }

            }
            return form;
        }
        
        private void SalesBillForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].Image != null)
                {
                    imageList1.Images.Add(Image.FromFile(products[i].Image));   
                }
                else
                {
                    Bitmap bitmap = new Bitmap(70, 70);
                    imageList1.Images.Add(bitmap);
                }

                ListViewItem item = new ListViewItem(); 
                item.Text = products[i].Name;   
                item.ImageIndex = i;
                item.Tag = products[i]; 
                listView1.Items.Add(item);
            }


        }
        void CalculateTotal()
        {
            try
            {
                decimal total = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    total += (decimal)(dataGridView1.Rows[i].Cells["Column5"].Value);
                }
                lblTotal.Text = total.ToString();
                decimal disc = decimal.Parse(textDiscount.Text);
                lblDiscount.Text = (total - disc).ToString();
            }
            catch { }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var product = (Product)listView1.SelectedItems[0].Tag;
                for(int i =0; i<dataGridView1.RowCount;i++)
                {
                    if (dataGridView1.Rows[i].Cells["Column1"].Value.ToString()==product.Id.ToString())
                    {
                        dataGridView1.Rows[i].Cells["Column4"].Value = (int)dataGridView1.Rows[i].Cells["Column4"].Value+1;
                        dataGridView1.Rows[i].Cells["Column5"].Value = (int)dataGridView1.Rows[i].Cells["Column4"].Value * (decimal)dataGridView1.Rows[i].Cells["Column3"].Value;
                        CalculateTotal();
                        return;
                    }
                }
                dataGridView1.Rows.Add(product.Id,product.Name,product.Price,1,product.Price, product.Image==null? new Bitmap(40,40): Image.FromFile(product.Image));
                CalculateTotal();
            }
        }

        private void textDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar !='.'))
            {
                e.Handled = true;
            }
            if((e.KeyChar =='.') && ((sender as TextBox).Text.IndexOf('.')>-1))
             {
                e.Handled=true; 
            }
        }

        private void butAddNewSupplier_Click(object sender, EventArgs e)
        {
            POFDemo.DB.SalesBill salesBill = new DB.SalesBill()
            {
                Date = dateTimePicker1.Value.Date,
                Discount = decimal.Parse(textDiscount.Text),
                Total = decimal.Parse(lblTotal.Text),
                TotalAfterDiscount = decimal.Parse(lblDiscount.Text),
                Notes = textBox1.Text,
                CustomerId =int.Parse(comboBoxCustomers.SelectedValue.ToString()),
            };

            List<SalesBillDetail> list = new List<SalesBillDetail>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                list.Add(new SalesBillDetail { 
                    ProductId = int.Parse((dataGridView1.Rows[i].Cells["Column1"].Value.ToString())),
                    Quantity = (int)dataGridView1.Rows[i].Cells["Column4"].Value,
                    Price = (decimal)dataGridView1.Rows[i].Cells["Column3"].Value,
                    TotalPrice = (int)dataGridView1.Rows[i].Cells["Column4"].Value * (decimal)dataGridView1.Rows[i].Cells["Column3"].Value,

                });
            }
            salesBill.SalesBillDetails= list;
            db.SalesBills.Add(salesBill);   
            db.SaveChanges();
            MessageBox.Show(salesBill.Id.ToString() + " " + " .تم الحفظ" + " رقم الفاتورة يساوي" );
        }
    }
}
