using POFDemo.Screens.Customers;
using POFDemo.Screens.Products;
using POFDemo.Screens.SalesBill;
using POFDemo.Screens.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POFDemo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(EntryForm.CreateForm());
        }
    }
}
