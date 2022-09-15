using POFDemo.Screens.Customers;
using POFDemo.Screens.Products;
using POFDemo.Screens.SalesBill;
using POFDemo.Screens.Suppliers;
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
    public partial class MainForm : Form
    {
        static MainForm form;
        private static readonly object obj = new object();
        private MainForm()
        {
            InitializeComponent();
        }
        public static MainForm CreateForm()
        {
            if (form == null || form.IsDisposed)
            {
                lock (obj)
                {
                    if (form == null || form.IsDisposed)
                    {
                        form = new MainForm();
                    }
                }
            }
            return form;
        }

        private void تعديلمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripItemFile_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Close();
            Thread thread = new Thread(OpenNextForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenNextForm()
        {
            Application.Run(EntryForm.CreateForm());
        }

        private void ToolStripItemUsers_AddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm.CreateForm().Show();
        }

        private void ToolStripItemProduct_Add_Click(object sender, EventArgs e)
        {
            ProductForm.CreateForm().Show();
        }

        private void ToolStripItemProduct_manage_Click(object sender, EventArgs e)
        {
            ProductsManagementForm.CreateForm().Show();
        }

        private void butProducts_Click(object sender, EventArgs e)
        {
            ProductsManagementForm.CreateForm().Show();
        }

        private void ToolStripItemCustomers_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuManageCustomer_Click(object sender, EventArgs e)
        {
            CustomersManagementForm.CreateForm().Show();
        }

        private void butCustomers_Click(object sender, EventArgs e)
        {
            CustomersManagementForm.CreateForm().Show();
        }

        private void butSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersManagementForm.CreateForm().Show();
        }

        private void ToolStripMenuSuppliersManagement_Click(object sender, EventArgs e)
        {
            SuppliersManagementForm.CreateForm().Show();
        }

        private void ToolStripMenuSalesBill_Click(object sender, EventArgs e)
        {
            SalesBillForm.CreateForm().Show();
        }

        private void butSalesBills_Click(object sender, EventArgs e)
        {
            SalesBillForm.CreateForm().Show();
        }
    }
}
