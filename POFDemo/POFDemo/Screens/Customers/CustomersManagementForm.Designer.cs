namespace POFDemo.Screens.Customers
{
    partial class CustomersManagementForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersManagementForm));
            this.butNext = new System.Windows.Forms.Button();
            this.butPrevious = new System.Windows.Forms.Button();
            this.butAddNewCustomer = new System.Windows.Forms.Button();
            this.butDeleteCustomer = new System.Windows.Forms.Button();
            this.labelCustomerImage = new System.Windows.Forms.Label();
            this.toolTipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.butRefresh = new System.Windows.Forms.Button();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.butSearch = new System.Windows.Forms.Button();
            this.labelCompny = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.CustomerPictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.butٍSaveChanges = new System.Windows.Forms.Button();
            this.linkLabelAddImage = new System.Windows.Forms.LinkLabel();
            this.butClean = new System.Windows.Forms.Button();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.textMobile_search = new System.Windows.Forms.TextBox();
            this.toolTipClean = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCompny = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butNext
            // 
            this.butNext.BackColor = System.Drawing.Color.White;
            this.butNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNext.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.butNext.FlatAppearance.BorderSize = 0;
            this.butNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNext.ForeColor = System.Drawing.Color.Blue;
            this.butNext.Location = new System.Drawing.Point(445, 726);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(77, 38);
            this.butNext.TabIndex = 85;
            this.butNext.Text = "20 >>";
            this.butNext.UseVisualStyleBackColor = false;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butPrevious
            // 
            this.butPrevious.BackColor = System.Drawing.Color.White;
            this.butPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.butPrevious.FlatAppearance.BorderSize = 0;
            this.butPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPrevious.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPrevious.ForeColor = System.Drawing.Color.Blue;
            this.butPrevious.Location = new System.Drawing.Point(146, 727);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(77, 38);
            this.butPrevious.TabIndex = 84;
            this.butPrevious.Text = "<< 20";
            this.butPrevious.UseVisualStyleBackColor = false;
            this.butPrevious.Click += new System.EventHandler(this.butPrevious_Click);
            // 
            // butAddNewCustomer
            // 
            this.butAddNewCustomer.BackColor = System.Drawing.Color.White;
            this.butAddNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butAddNewCustomer.Location = new System.Drawing.Point(813, 623);
            this.butAddNewCustomer.Name = "butAddNewCustomer";
            this.butAddNewCustomer.Size = new System.Drawing.Size(175, 38);
            this.butAddNewCustomer.TabIndex = 83;
            this.butAddNewCustomer.Text = "إضافة عميل جديد";
            this.butAddNewCustomer.UseVisualStyleBackColor = false;
            this.butAddNewCustomer.Click += new System.EventHandler(this.butAddNewCustomer_Click);
            // 
            // butDeleteCustomer
            // 
            this.butDeleteCustomer.BackColor = System.Drawing.Color.White;
            this.butDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.butDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDeleteCustomer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeleteCustomer.ForeColor = System.Drawing.Color.Red;
            this.butDeleteCustomer.Location = new System.Drawing.Point(813, 726);
            this.butDeleteCustomer.Name = "butDeleteCustomer";
            this.butDeleteCustomer.Size = new System.Drawing.Size(175, 38);
            this.butDeleteCustomer.TabIndex = 82;
            this.butDeleteCustomer.Text = "حذف العميل";
            this.butDeleteCustomer.UseVisualStyleBackColor = false;
            this.butDeleteCustomer.Click += new System.EventHandler(this.butDeleteCustomer_Click);
            // 
            // labelCustomerImage
            // 
            this.labelCustomerImage.AutoSize = true;
            this.labelCustomerImage.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCustomerImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerImage.Location = new System.Drawing.Point(981, 441);
            this.labelCustomerImage.Name = "labelCustomerImage";
            this.labelCustomerImage.Size = new System.Drawing.Size(143, 32);
            this.labelCustomerImage.TabIndex = 79;
            this.labelCustomerImage.Text = "صورة العميل";
            // 
            // butRefresh
            // 
            this.butRefresh.BackColor = System.Drawing.Color.Transparent;
            this.butRefresh.BackgroundImage = global::POFDemo.Properties.Resources.refresh;
            this.butRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRefresh.FlatAppearance.BorderSize = 0;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Location = new System.Drawing.Point(314, 726);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(44, 40);
            this.butRefresh.TabIndex = 66;
            this.toolTipSearch.SetToolTip(this.butRefresh, "بحث");
            this.toolTipRefresh.SetToolTip(this.butRefresh, "إعادة تهيئة");
            this.butRefresh.UseVisualStyleBackColor = false;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.BackgroundImage = global::POFDemo.Properties.Resources.search;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearch.FlatAppearance.BorderSize = 0;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Location = new System.Drawing.Point(77, 96);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(54, 51);
            this.butSearch.TabIndex = 64;
            this.toolTipSearch.SetToolTip(this.butSearch, "بحث");
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // labelCompny
            // 
            this.labelCompny.AutoSize = true;
            this.labelCompny.BackColor = System.Drawing.Color.Transparent;
            this.labelCompny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCompny.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompny.Location = new System.Drawing.Point(1473, 499);
            this.labelCompny.Name = "labelCompny";
            this.labelCompny.Size = new System.Drawing.Size(78, 32);
            this.labelCompny.TabIndex = 78;
            this.labelCompny.Text = "الشركة";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.BackColor = System.Drawing.Color.Transparent;
            this.labelNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNotes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(1003, 256);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(110, 32);
            this.labelNotes.TabIndex = 77;
            this.labelNotes.Text = "ملاحاظات";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(1471, 312);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(84, 32);
            this.labelAddress.TabIndex = 76;
            this.labelAddress.Text = "العنوان";
            // 
            // textNotes
            // 
            this.textNotes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNotes.Location = new System.Drawing.Point(732, 259);
            this.textNotes.MaxLength = 50;
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(239, 140);
            this.textNotes.TabIndex = 75;
            this.textNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNotes.UseSystemPasswordChar = true;
            // 
            // CustomerPictureBox
            // 
            this.CustomerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerPictureBox.Location = new System.Drawing.Point(732, 459);
            this.CustomerPictureBox.Name = "CustomerPictureBox";
            this.CustomerPictureBox.Size = new System.Drawing.Size(239, 140);
            this.CustomerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerPictureBox.TabIndex = 73;
            this.CustomerPictureBox.TabStop = false;
            this.CustomerPictureBox.Click += new System.EventHandler(this.CustomerPictureBox_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(1428, 225);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(127, 32);
            this.labelName.TabIndex = 72;
            this.labelName.Text = "اسم العميل";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(1154, 261);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(338, 35);
            this.textBoxName.TabIndex = 70;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelHeader.Location = new System.Drawing.Point(1360, 124);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(232, 40);
            this.labelHeader.TabIndex = 69;
            this.labelHeader.Text = "  بيانات العميل <-";
            // 
            // butٍSaveChanges
            // 
            this.butٍSaveChanges.BackColor = System.Drawing.Color.White;
            this.butٍSaveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butٍSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butٍSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.butٍSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butٍSaveChanges.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butٍSaveChanges.ForeColor = System.Drawing.Color.Blue;
            this.butٍSaveChanges.Location = new System.Drawing.Point(813, 674);
            this.butٍSaveChanges.Name = "butٍSaveChanges";
            this.butٍSaveChanges.Size = new System.Drawing.Size(175, 38);
            this.butٍSaveChanges.TabIndex = 67;
            this.butٍSaveChanges.Text = "حفظ التعديلات";
            this.butٍSaveChanges.UseVisualStyleBackColor = false;
            this.butٍSaveChanges.Click += new System.EventHandler(this.butٍSaveChanges_Click);
            // 
            // linkLabelAddImage
            // 
            this.linkLabelAddImage.AutoSize = true;
            this.linkLabelAddImage.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAddImage.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAddImage.Location = new System.Drawing.Point(787, 448);
            this.linkLabelAddImage.Name = "linkLabelAddImage";
            this.linkLabelAddImage.Size = new System.Drawing.Size(94, 31);
            this.linkLabelAddImage.TabIndex = 74;
            this.linkLabelAddImage.TabStop = true;
            this.linkLabelAddImage.Text = "إضافة صورة";
            this.linkLabelAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddImage_LinkClicked);
            // 
            // butClean
            // 
            this.butClean.BackColor = System.Drawing.Color.Transparent;
            this.butClean.BackgroundImage = global::POFDemo.Properties.Resources.cleaning;
            this.butClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClean.FlatAppearance.BorderSize = 0;
            this.butClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClean.Location = new System.Drawing.Point(2, 2);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(54, 49);
            this.butClean.TabIndex = 65;
            this.toolTipClean.SetToolTip(this.butClean, "تنظيف البيانات المدخلة");
            this.butClean.UseVisualStyleBackColor = false;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCustomers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomers.Location = new System.Drawing.Point(754, 23);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(92, 37);
            this.labelCustomers.TabIndex = 63;
            this.labelCustomers.Text = "العملاء";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(500, 157);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(127, 32);
            this.labelCustomerName.TabIndex = 62;
            this.labelCustomerName.Text = "اسم العميل";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(500, 102);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(133, 32);
            this.labelPhone.TabIndex = 61;
            this.labelPhone.Text = "رقم الموبايل";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustomerName.Location = new System.Drawing.Point(148, 157);
            this.textCustomerName.MaxLength = 50;
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(322, 35);
            this.textCustomerName.TabIndex = 60;
            this.textCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMobile_search
            // 
            this.textMobile_search.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textMobile_search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobile_search.Location = new System.Drawing.Point(148, 102);
            this.textMobile_search.MaxLength = 50;
            this.textMobile_search.Name = "textMobile_search";
            this.textMobile_search.Size = new System.Drawing.Size(322, 35);
            this.textMobile_search.TabIndex = 59;
            this.textMobile_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 206);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(643, 509);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(1154, 350);
            this.textAddress.MaxLength = 50;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(338, 35);
            this.textAddress.TabIndex = 86;
            this.textAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCompny
            // 
            this.textCompny.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCompny.Location = new System.Drawing.Point(1154, 535);
            this.textCompny.MaxLength = 50;
            this.textCompny.Name = "textCompny";
            this.textCompny.Size = new System.Drawing.Size(338, 35);
            this.textCompny.TabIndex = 87;
            this.textCompny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(1154, 442);
            this.textPhone.MaxLength = 50;
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(338, 35);
            this.textPhone.TabIndex = 89;
            this.textPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.BackColor = System.Drawing.Color.Transparent;
            this.labelMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMobile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(1426, 405);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(133, 32);
            this.labelMobile.TabIndex = 88;
            this.labelMobile.Text = "رقم الموبايل";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(1475, 596);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 32);
            this.labelEmail.TabIndex = 91;
            this.labelEmail.Text = "الايميل";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(1156, 634);
            this.textEmail.MaxLength = 50;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(338, 35);
            this.textEmail.TabIndex = 90;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxActive.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.checkBoxActive.Location = new System.Drawing.Point(1272, 707);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(114, 36);
            this.checkBoxActive.TabIndex = 93;
            this.checkBoxActive.Text = "  نشط ؟";
            this.checkBoxActive.UseVisualStyleBackColor = false;
            // 
            // CustomersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 797);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.textCompny);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPrevious);
            this.Controls.Add(this.butAddNewCustomer);
            this.Controls.Add(this.butDeleteCustomer);
            this.Controls.Add(this.labelCustomerImage);
            this.Controls.Add(this.labelCompny);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.CustomerPictureBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.butٍSaveChanges);
            this.Controls.Add(this.linkLabelAddImage);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.labelCustomers);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.textMobile_search);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomersManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.CustomersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butPrevious;
        private System.Windows.Forms.Button butAddNewCustomer;
        private System.Windows.Forms.Button butDeleteCustomer;
        private System.Windows.Forms.Label labelCustomerImage;
        private System.Windows.Forms.ToolTip toolTipRefresh;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Label labelCompny;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.PictureBox CustomerPictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button butٍSaveChanges;
        private System.Windows.Forms.LinkLabel linkLabelAddImage;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.ToolTip toolTipClean;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox textMobile_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCompny;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.CheckBox checkBoxActive;
    }
}