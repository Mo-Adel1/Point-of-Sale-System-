namespace POFDemo.Screens.Suppliers
{
    partial class SuppliersManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersManagementForm));
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelMobile = new System.Windows.Forms.Label();
            this.textCompny = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.toolTipClean = new System.Windows.Forms.ToolTip(this.components);
            this.butClean = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.butNext = new System.Windows.Forms.Button();
            this.butPrevious = new System.Windows.Forms.Button();
            this.butAddNewSupplier = new System.Windows.Forms.Button();
            this.butDeleteSupplier = new System.Windows.Forms.Button();
            this.labelSupplierImage = new System.Windows.Forms.Label();
            this.labelCompny = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.SupplierPictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.toolTipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.butRefresh = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.butٍSaveChanges = new System.Windows.Forms.Button();
            this.linkLabelAddImage = new System.Windows.Forms.LinkLabel();
            this.labelSuppliers = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textSupplierName = new System.Windows.Forms.TextBox();
            this.textMobile_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.butSearch = new System.Windows.Forms.Button();
            this.labelSupplierName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxActive.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.checkBoxActive.Location = new System.Drawing.Point(1277, 721);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(114, 36);
            this.checkBoxActive.TabIndex = 124;
            this.checkBoxActive.Text = "  نشط ؟";
            this.checkBoxActive.UseVisualStyleBackColor = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(1480, 610);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 32);
            this.labelEmail.TabIndex = 123;
            this.labelEmail.Text = "الايميل";
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(1159, 456);
            this.textPhone.MaxLength = 50;
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(338, 35);
            this.textPhone.TabIndex = 121;
            this.textPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.BackColor = System.Drawing.Color.Transparent;
            this.labelMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMobile.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(1431, 419);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(133, 32);
            this.labelMobile.TabIndex = 120;
            this.labelMobile.Text = "رقم الموبايل";
            // 
            // textCompny
            // 
            this.textCompny.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCompny.Location = new System.Drawing.Point(1159, 549);
            this.textCompny.MaxLength = 50;
            this.textCompny.Name = "textCompny";
            this.textCompny.Size = new System.Drawing.Size(338, 35);
            this.textCompny.TabIndex = 119;
            this.textCompny.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(1159, 364);
            this.textAddress.MaxLength = 50;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(338, 35);
            this.textAddress.TabIndex = 118;
            this.textAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butClean
            // 
            this.butClean.BackColor = System.Drawing.Color.Transparent;
            this.butClean.BackgroundImage = global::POFDemo.Properties.Resources.cleaning;
            this.butClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClean.FlatAppearance.BorderSize = 0;
            this.butClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClean.Location = new System.Drawing.Point(7, 16);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(54, 49);
            this.butClean.TabIndex = 101;
            this.toolTipClean.SetToolTip(this.butClean, "تنظيف البيانات المدخلة");
            this.butClean.UseVisualStyleBackColor = false;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(1161, 648);
            this.textEmail.MaxLength = 50;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(338, 35);
            this.textEmail.TabIndex = 122;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.butNext.Location = new System.Drawing.Point(450, 740);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(77, 38);
            this.butNext.TabIndex = 117;
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
            this.butPrevious.Location = new System.Drawing.Point(151, 741);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(77, 38);
            this.butPrevious.TabIndex = 116;
            this.butPrevious.Text = "<< 20";
            this.butPrevious.UseVisualStyleBackColor = false;
            this.butPrevious.Click += new System.EventHandler(this.butPrevious_Click);
            // 
            // butAddNewSupplier
            // 
            this.butAddNewSupplier.BackColor = System.Drawing.Color.White;
            this.butAddNewSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddNewSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butAddNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAddNewSupplier.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddNewSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butAddNewSupplier.Location = new System.Drawing.Point(818, 637);
            this.butAddNewSupplier.Name = "butAddNewSupplier";
            this.butAddNewSupplier.Size = new System.Drawing.Size(175, 38);
            this.butAddNewSupplier.TabIndex = 115;
            this.butAddNewSupplier.Text = "إضافة مورد جديد";
            this.butAddNewSupplier.UseVisualStyleBackColor = false;
            this.butAddNewSupplier.Click += new System.EventHandler(this.butAddNewSupplier_Click);
            // 
            // butDeleteSupplier
            // 
            this.butDeleteSupplier.BackColor = System.Drawing.Color.White;
            this.butDeleteSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDeleteSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.butDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeleteSupplier.ForeColor = System.Drawing.Color.Red;
            this.butDeleteSupplier.Location = new System.Drawing.Point(818, 740);
            this.butDeleteSupplier.Name = "butDeleteSupplier";
            this.butDeleteSupplier.Size = new System.Drawing.Size(175, 38);
            this.butDeleteSupplier.TabIndex = 114;
            this.butDeleteSupplier.Text = "حذف المورد";
            this.butDeleteSupplier.UseVisualStyleBackColor = false;
            this.butDeleteSupplier.Click += new System.EventHandler(this.butDeleteSupplier_Click);
            // 
            // labelSupplierImage
            // 
            this.labelSupplierImage.AutoSize = true;
            this.labelSupplierImage.BackColor = System.Drawing.Color.Transparent;
            this.labelSupplierImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSupplierImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierImage.Location = new System.Drawing.Point(986, 455);
            this.labelSupplierImage.Name = "labelSupplierImage";
            this.labelSupplierImage.Size = new System.Drawing.Size(137, 32);
            this.labelSupplierImage.TabIndex = 113;
            this.labelSupplierImage.Text = "صورة المورد";
            // 
            // labelCompny
            // 
            this.labelCompny.AutoSize = true;
            this.labelCompny.BackColor = System.Drawing.Color.Transparent;
            this.labelCompny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCompny.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompny.Location = new System.Drawing.Point(1478, 513);
            this.labelCompny.Name = "labelCompny";
            this.labelCompny.Size = new System.Drawing.Size(78, 32);
            this.labelCompny.TabIndex = 112;
            this.labelCompny.Text = "الشركة";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.BackColor = System.Drawing.Color.Transparent;
            this.labelNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNotes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(1008, 270);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(110, 32);
            this.labelNotes.TabIndex = 111;
            this.labelNotes.Text = "ملاحاظات";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(1476, 326);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(84, 32);
            this.labelAddress.TabIndex = 110;
            this.labelAddress.Text = "العنوان";
            // 
            // textNotes
            // 
            this.textNotes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNotes.Location = new System.Drawing.Point(737, 273);
            this.textNotes.MaxLength = 50;
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(239, 140);
            this.textNotes.TabIndex = 109;
            this.textNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNotes.UseSystemPasswordChar = true;
            // 
            // SupplierPictureBox
            // 
            this.SupplierPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SupplierPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplierPictureBox.Location = new System.Drawing.Point(737, 473);
            this.SupplierPictureBox.Name = "SupplierPictureBox";
            this.SupplierPictureBox.Size = new System.Drawing.Size(239, 140);
            this.SupplierPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SupplierPictureBox.TabIndex = 107;
            this.SupplierPictureBox.TabStop = false;
            this.SupplierPictureBox.Click += new System.EventHandler(this.SupplierPictureBox_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(1433, 239);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 32);
            this.labelName.TabIndex = 106;
            this.labelName.Text = "اسم المورد";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(1159, 275);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(338, 35);
            this.textBoxName.TabIndex = 105;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butRefresh
            // 
            this.butRefresh.BackColor = System.Drawing.Color.Transparent;
            this.butRefresh.BackgroundImage = global::POFDemo.Properties.Resources.refresh;
            this.butRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRefresh.FlatAppearance.BorderSize = 0;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Location = new System.Drawing.Point(319, 740);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(44, 40);
            this.butRefresh.TabIndex = 102;
            this.toolTipRefresh.SetToolTip(this.butRefresh, "إعادة تهيئة");
            this.toolTipSearch.SetToolTip(this.butRefresh, "بحث");
            this.butRefresh.UseVisualStyleBackColor = false;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelHeader.Location = new System.Drawing.Point(1365, 138);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(226, 40);
            this.labelHeader.TabIndex = 104;
            this.labelHeader.Text = "  بيانات المورد <-";
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
            this.butٍSaveChanges.Location = new System.Drawing.Point(818, 688);
            this.butٍSaveChanges.Name = "butٍSaveChanges";
            this.butٍSaveChanges.Size = new System.Drawing.Size(175, 38);
            this.butٍSaveChanges.TabIndex = 103;
            this.butٍSaveChanges.Text = "حفظ التعديلات";
            this.butٍSaveChanges.UseVisualStyleBackColor = false;
            this.butٍSaveChanges.Click += new System.EventHandler(this.butٍSaveChanges_Click);
            // 
            // linkLabelAddImage
            // 
            this.linkLabelAddImage.AutoSize = true;
            this.linkLabelAddImage.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAddImage.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAddImage.Location = new System.Drawing.Point(792, 462);
            this.linkLabelAddImage.Name = "linkLabelAddImage";
            this.linkLabelAddImage.Size = new System.Drawing.Size(94, 31);
            this.linkLabelAddImage.TabIndex = 108;
            this.linkLabelAddImage.TabStop = true;
            this.linkLabelAddImage.Text = "إضافة صورة";
            this.linkLabelAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddImage_LinkClicked);
            // 
            // labelSuppliers
            // 
            this.labelSuppliers.AutoSize = true;
            this.labelSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.labelSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSuppliers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuppliers.Location = new System.Drawing.Point(759, 37);
            this.labelSuppliers.Name = "labelSuppliers";
            this.labelSuppliers.Size = new System.Drawing.Size(113, 37);
            this.labelSuppliers.TabIndex = 99;
            this.labelSuppliers.Text = "الموردين";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(505, 116);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(133, 32);
            this.labelPhone.TabIndex = 97;
            this.labelPhone.Text = "رقم الموبايل";
            // 
            // textSupplierName
            // 
            this.textSupplierName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSupplierName.Location = new System.Drawing.Point(153, 171);
            this.textSupplierName.MaxLength = 50;
            this.textSupplierName.Name = "textSupplierName";
            this.textSupplierName.Size = new System.Drawing.Size(322, 35);
            this.textSupplierName.TabIndex = 96;
            this.textSupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMobile_search
            // 
            this.textMobile_search.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textMobile_search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMobile_search.Location = new System.Drawing.Point(153, 116);
            this.textMobile_search.MaxLength = 50;
            this.textMobile_search.Name = "textMobile_search";
            this.textMobile_search.Size = new System.Drawing.Size(322, 35);
            this.textMobile_search.TabIndex = 95;
            this.textMobile_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 220);
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
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.BackgroundImage = global::POFDemo.Properties.Resources.search;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearch.FlatAppearance.BorderSize = 0;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Location = new System.Drawing.Point(82, 110);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(54, 51);
            this.butSearch.TabIndex = 100;
            this.toolTipSearch.SetToolTip(this.butSearch, "بحث");
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.labelSupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSupplierName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplierName.Location = new System.Drawing.Point(505, 171);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(121, 32);
            this.labelSupplierName.TabIndex = 98;
            this.labelSupplierName.Text = "اسم المورد";
            // 
            // SuppliersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 797);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.textCompny);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPrevious);
            this.Controls.Add(this.butAddNewSupplier);
            this.Controls.Add(this.butDeleteSupplier);
            this.Controls.Add(this.labelSupplierImage);
            this.Controls.Add(this.labelCompny);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.SupplierPictureBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.butٍSaveChanges);
            this.Controls.Add(this.linkLabelAddImage);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.labelSuppliers);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textSupplierName);
            this.Controls.Add(this.textMobile_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.labelSupplierName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1598, 836);
            this.Name = "SuppliersManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الموردين";
            this.Load += new System.EventHandler(this.SuppliersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox textCompny;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.ToolTip toolTipClean;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butPrevious;
        private System.Windows.Forms.Button butAddNewSupplier;
        private System.Windows.Forms.Button butDeleteSupplier;
        private System.Windows.Forms.Label labelSupplierImage;
        private System.Windows.Forms.Label labelCompny;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.PictureBox SupplierPictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ToolTip toolTipRefresh;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button butٍSaveChanges;
        private System.Windows.Forms.LinkLabel linkLabelAddImage;
        private System.Windows.Forms.Label labelSuppliers;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textSupplierName;
        private System.Windows.Forms.TextBox textMobile_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Label labelSupplierName;
    }
}