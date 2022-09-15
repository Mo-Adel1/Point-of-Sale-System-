namespace POFDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemFile_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemUsers_AddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemProduct_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemProduct_manage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemProduct_list = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuManageCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuSuppliersManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemBill = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.butProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butCustomers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butSuppliers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.butSalesBills = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.butPaymentBills = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.butReports = new System.Windows.Forms.Button();
            this.ToolStripMenuSalesBill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemFile,
            this.ToolStripItemUsers,
            this.ToolStripItemProducts,
            this.ToolStripItemCustomers,
            this.ToolStripItemSuppliers,
            this.ToolStripItemBill,
            this.ToolStripItemReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(974, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripItemFile
            // 
            this.ToolStripItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemLogout,
            this.ToolStripItemFile_Close});
            this.ToolStripItemFile.Image = global::POFDemo.Properties.Resources.copy_paste_document_file_1557;
            this.ToolStripItemFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripItemFile.Name = "ToolStripItemFile";
            this.ToolStripItemFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemFile.Size = new System.Drawing.Size(68, 25);
            this.ToolStripItemFile.Text = "ملف";
            this.ToolStripItemFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ToolStripItemLogout
            // 
            this.ToolStripItemLogout.Image = global::POFDemo.Properties.Resources.login;
            this.ToolStripItemLogout.Name = "ToolStripItemLogout";
            this.ToolStripItemLogout.Size = new System.Drawing.Size(160, 26);
            this.ToolStripItemLogout.Text = "تسجيل خروج";
            this.ToolStripItemLogout.Click += new System.EventHandler(this.ToolStripItemLogout_Click);
            // 
            // ToolStripItemFile_Close
            // 
            this.ToolStripItemFile_Close.Image = global::POFDemo.Properties.Resources.ic_clear_128_28306;
            this.ToolStripItemFile_Close.Name = "ToolStripItemFile_Close";
            this.ToolStripItemFile_Close.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemFile_Close.Size = new System.Drawing.Size(160, 26);
            this.ToolStripItemFile_Close.Text = "اغلاق";
            this.ToolStripItemFile_Close.Click += new System.EventHandler(this.ToolStripItemFile_Close_Click);
            // 
            // ToolStripItemUsers
            // 
            this.ToolStripItemUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemUsers_AddNewUser});
            this.ToolStripItemUsers.Image = global::POFDemo.Properties.Resources.cashier;
            this.ToolStripItemUsers.Name = "ToolStripItemUsers";
            this.ToolStripItemUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemUsers.Size = new System.Drawing.Size(116, 25);
            this.ToolStripItemUsers.Text = "المستخدمين";
            this.ToolStripItemUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ToolStripItemUsers_AddNewUser
            // 
            this.ToolStripItemUsers_AddNewUser.Image = global::POFDemo.Properties.Resources.add1;
            this.ToolStripItemUsers_AddNewUser.Name = "ToolStripItemUsers_AddNewUser";
            this.ToolStripItemUsers_AddNewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemUsers_AddNewUser.Size = new System.Drawing.Size(211, 26);
            this.ToolStripItemUsers_AddNewUser.Text = "إضافة مستخدم جديد";
            this.ToolStripItemUsers_AddNewUser.Click += new System.EventHandler(this.ToolStripItemUsers_AddNewUser_Click);
            // 
            // ToolStripItemProducts
            // 
            this.ToolStripItemProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItemProduct_Add,
            this.ToolStripItemProduct_manage,
            this.ToolStripItemProduct_list});
            this.ToolStripItemProducts.Image = global::POFDemo.Properties.Resources.dairy_products;
            this.ToolStripItemProducts.Name = "ToolStripItemProducts";
            this.ToolStripItemProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemProducts.Size = new System.Drawing.Size(94, 25);
            this.ToolStripItemProducts.Text = "المنتجات";
            this.ToolStripItemProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ToolStripItemProduct_Add
            // 
            this.ToolStripItemProduct_Add.Image = global::POFDemo.Properties.Resources.add;
            this.ToolStripItemProduct_Add.Name = "ToolStripItemProduct_Add";
            this.ToolStripItemProduct_Add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemProduct_Add.Size = new System.Drawing.Size(174, 26);
            this.ToolStripItemProduct_Add.Text = "إضافة منتج";
            this.ToolStripItemProduct_Add.Click += new System.EventHandler(this.ToolStripItemProduct_Add_Click);
            // 
            // ToolStripItemProduct_manage
            // 
            this.ToolStripItemProduct_manage.Image = global::POFDemo.Properties.Resources.shelf;
            this.ToolStripItemProduct_manage.Name = "ToolStripItemProduct_manage";
            this.ToolStripItemProduct_manage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemProduct_manage.Size = new System.Drawing.Size(174, 26);
            this.ToolStripItemProduct_manage.Text = "إدارة المنتجات";
            this.ToolStripItemProduct_manage.Click += new System.EventHandler(this.ToolStripItemProduct_manage_Click);
            // 
            // ToolStripItemProduct_list
            // 
            this.ToolStripItemProduct_list.Image = global::POFDemo.Properties.Resources._8_icon_icons_com_73776;
            this.ToolStripItemProduct_list.Name = "ToolStripItemProduct_list";
            this.ToolStripItemProduct_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemProduct_list.Size = new System.Drawing.Size(174, 26);
            this.ToolStripItemProduct_list.Text = "قائمة المنتجات";
            // 
            // ToolStripItemCustomers
            // 
            this.ToolStripItemCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuManageCustomer});
            this.ToolStripItemCustomers.Image = global::POFDemo.Properties.Resources.community_users_12977;
            this.ToolStripItemCustomers.Name = "ToolStripItemCustomers";
            this.ToolStripItemCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemCustomers.Size = new System.Drawing.Size(81, 25);
            this.ToolStripItemCustomers.Text = "العملاء";
            this.ToolStripItemCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ToolStripItemCustomers.Click += new System.EventHandler(this.ToolStripItemCustomers_Click);
            // 
            // ToolStripMenuManageCustomer
            // 
            this.ToolStripMenuManageCustomer.Name = "ToolStripMenuManageCustomer";
            this.ToolStripMenuManageCustomer.Size = new System.Drawing.Size(157, 26);
            this.ToolStripMenuManageCustomer.Text = "إدارة العملاء";
            this.ToolStripMenuManageCustomer.Click += new System.EventHandler(this.ToolStripMenuManageCustomer_Click);
            // 
            // ToolStripItemSuppliers
            // 
            this.ToolStripItemSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuSuppliersManagement});
            this.ToolStripItemSuppliers.Image = global::POFDemo.Properties.Resources.supplier;
            this.ToolStripItemSuppliers.Name = "ToolStripItemSuppliers";
            this.ToolStripItemSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemSuppliers.Size = new System.Drawing.Size(94, 25);
            this.ToolStripItemSuppliers.Text = "الموردين";
            this.ToolStripItemSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ToolStripMenuSuppliersManagement
            // 
            this.ToolStripMenuSuppliersManagement.Name = "ToolStripMenuSuppliersManagement";
            this.ToolStripMenuSuppliersManagement.Size = new System.Drawing.Size(180, 26);
            this.ToolStripMenuSuppliersManagement.Text = "إدارة الموردين";
            this.ToolStripMenuSuppliersManagement.Click += new System.EventHandler(this.ToolStripMenuSuppliersManagement_Click);
            // 
            // ToolStripItemBill
            // 
            this.ToolStripItemBill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuSalesBill});
            this.ToolStripItemBill.Image = global::POFDemo.Properties.Resources._1486394965_12_bills_80559;
            this.ToolStripItemBill.Name = "ToolStripItemBill";
            this.ToolStripItemBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemBill.Size = new System.Drawing.Size(86, 25);
            this.ToolStripItemBill.Text = "الفاتورة";
            this.ToolStripItemBill.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ToolStripItemReport
            // 
            this.ToolStripItemReport.Image = global::POFDemo.Properties.Resources.report;
            this.ToolStripItemReport.Name = "ToolStripItemReport";
            this.ToolStripItemReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripItemReport.Size = new System.Drawing.Size(75, 25);
            this.ToolStripItemReport.Text = "تقارير";
            this.ToolStripItemReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // butProducts
            // 
            this.butProducts.BackColor = System.Drawing.Color.Transparent;
            this.butProducts.BackgroundImage = global::POFDemo.Properties.Resources.shelf;
            this.butProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butProducts.FlatAppearance.BorderSize = 0;
            this.butProducts.Location = new System.Drawing.Point(701, 78);
            this.butProducts.Name = "butProducts";
            this.butProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butProducts.Size = new System.Drawing.Size(188, 142);
            this.butProducts.TabIndex = 1;
            this.butProducts.UseVisualStyleBackColor = false;
            this.butProducts.Click += new System.EventHandler(this.butProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(754, 237);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "المنتجات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 237);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "العملاء";
            // 
            // butCustomers
            // 
            this.butCustomers.BackColor = System.Drawing.Color.Transparent;
            this.butCustomers.BackgroundImage = global::POFDemo.Properties.Resources.community_users_12977;
            this.butCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCustomers.FlatAppearance.BorderSize = 0;
            this.butCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCustomers.Location = new System.Drawing.Point(393, 78);
            this.butCustomers.Name = "butCustomers";
            this.butCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butCustomers.Size = new System.Drawing.Size(188, 142);
            this.butCustomers.TabIndex = 3;
            this.butCustomers.UseVisualStyleBackColor = false;
            this.butCustomers.Click += new System.EventHandler(this.butCustomers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 237);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "الموردين";
            // 
            // butSuppliers
            // 
            this.butSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.butSuppliers.BackgroundImage = global::POFDemo.Properties.Resources.supplier;
            this.butSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSuppliers.FlatAppearance.BorderSize = 0;
            this.butSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSuppliers.Location = new System.Drawing.Point(78, 78);
            this.butSuppliers.Name = "butSuppliers";
            this.butSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butSuppliers.Size = new System.Drawing.Size(188, 142);
            this.butSuppliers.TabIndex = 5;
            this.butSuppliers.UseVisualStyleBackColor = false;
            this.butSuppliers.Click += new System.EventHandler(this.butSuppliers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 436);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "فواتير المبيعات";
            // 
            // butSalesBills
            // 
            this.butSalesBills.BackColor = System.Drawing.Color.Transparent;
            this.butSalesBills.BackgroundImage = global::POFDemo.Properties.Resources.sales_management_icon_149874;
            this.butSalesBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSalesBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSalesBills.FlatAppearance.BorderSize = 0;
            this.butSalesBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalesBills.Location = new System.Drawing.Point(701, 285);
            this.butSalesBills.Name = "butSalesBills";
            this.butSalesBills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butSalesBills.Size = new System.Drawing.Size(188, 142);
            this.butSalesBills.TabIndex = 7;
            this.butSalesBills.UseVisualStyleBackColor = false;
            this.butSalesBills.Click += new System.EventHandler(this.butSalesBills_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 435);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(160, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "فواتير المشتريات";
            // 
            // butPaymentBills
            // 
            this.butPaymentBills.BackColor = System.Drawing.Color.Transparent;
            this.butPaymentBills.BackgroundImage = global::POFDemo.Properties.Resources._1486394965_12_bills_80559;
            this.butPaymentBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butPaymentBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPaymentBills.FlatAppearance.BorderSize = 0;
            this.butPaymentBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPaymentBills.Location = new System.Drawing.Point(393, 285);
            this.butPaymentBills.Name = "butPaymentBills";
            this.butPaymentBills.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butPaymentBills.Size = new System.Drawing.Size(188, 142);
            this.butPaymentBills.TabIndex = 9;
            this.butPaymentBills.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 436);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(75, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "التقارير";
            // 
            // butReports
            // 
            this.butReports.BackColor = System.Drawing.Color.Transparent;
            this.butReports.BackgroundImage = global::POFDemo.Properties.Resources.report;
            this.butReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butReports.FlatAppearance.BorderSize = 0;
            this.butReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReports.Location = new System.Drawing.Point(78, 285);
            this.butReports.Name = "butReports";
            this.butReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.butReports.Size = new System.Drawing.Size(188, 142);
            this.butReports.TabIndex = 11;
            this.butReports.UseVisualStyleBackColor = false;
            // 
            // ToolStripMenuSalesBill
            // 
            this.ToolStripMenuSalesBill.Name = "ToolStripMenuSalesBill";
            this.ToolStripMenuSalesBill.Size = new System.Drawing.Size(180, 26);
            this.ToolStripMenuSalesBill.Text = "المبيعات";
            this.ToolStripMenuSalesBill.Click += new System.EventHandler(this.ToolStripMenuSalesBill_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 522);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butReports);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butPaymentBills);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butSalesBills);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butSuppliers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butProducts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(990, 561);
            this.MinimumSize = new System.Drawing.Size(990, 561);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصفحة الرئيسية";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemUsers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemUsers_AddNewUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemProducts;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemProduct_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemProduct_manage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemProduct_list;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemSuppliers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemBill;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemReport;
        private System.Windows.Forms.Button butProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butSuppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butSalesBills;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butPaymentBills;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butReports;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemLogout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItemFile_Close;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuManageCustomer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuSuppliersManagement;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuSalesBill;
    }
}