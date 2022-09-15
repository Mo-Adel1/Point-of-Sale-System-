namespace POFDemo.Screens.Products
{
    partial class ProductsManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsManagementForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelproductname = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butClean = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.toolTipClean = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.butRefresh = new System.Windows.Forms.Button();
            this.toolTipRefresh = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelPoductImage = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.butٍSaveChanges = new System.Windows.Forms.Button();
            this.linkLabelAddImage = new System.Windows.Forms.LinkLabel();
            this.butDeleteProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butPrevious = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.butAddCategory = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.pOSDEMODataSet2 = new POFDemo.POSDEMODataSet2();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new POFDemo.POSDEMODataSet2TableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDEMODataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
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
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.BackColor = System.Drawing.Color.Transparent;
            this.labelproductname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelproductname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(466, 177);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(119, 32);
            this.labelproductname.TabIndex = 28;
            this.labelproductname.Text = "اسم المنتج";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.BackColor = System.Drawing.Color.Transparent;
            this.labelBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBarcode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(481, 122);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(86, 32);
            this.labelBarcode.TabIndex = 27;
            this.labelBarcode.Text = "الباركود";
            // 
            // textProductName
            // 
            this.textProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProductName.Location = new System.Drawing.Point(129, 177);
            this.textProductName.MaxLength = 50;
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(322, 35);
            this.textProductName.TabIndex = 26;
            this.textProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBarcode
            // 
            this.textBarcode.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textBarcode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBarcode.Location = new System.Drawing.Point(129, 122);
            this.textBarcode.MaxLength = 50;
            this.textBarcode.Name = "textBarcode";
            this.textBarcode.Size = new System.Drawing.Size(322, 35);
            this.textBarcode.TabIndex = 25;
            this.textBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "إدارة المنتجات";
            // 
            // butClean
            // 
            this.butClean.BackColor = System.Drawing.Color.Transparent;
            this.butClean.BackgroundImage = global::POFDemo.Properties.Resources.cleaning;
            this.butClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClean.FlatAppearance.BorderSize = 0;
            this.butClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClean.Location = new System.Drawing.Point(2, 3);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(54, 49);
            this.butClean.TabIndex = 31;
            this.toolTipClean.SetToolTip(this.butClean, "تنظيف البيانات المدخلة");
            this.butClean.UseVisualStyleBackColor = false;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // butSearch
            // 
            this.butSearch.BackColor = System.Drawing.Color.Transparent;
            this.butSearch.BackgroundImage = global::POFDemo.Properties.Resources.search;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearch.FlatAppearance.BorderSize = 0;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Location = new System.Drawing.Point(58, 116);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(54, 51);
            this.butSearch.TabIndex = 30;
            this.toolTipSearch.SetToolTip(this.butSearch, "بحث");
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.BackColor = System.Drawing.Color.Transparent;
            this.butRefresh.BackgroundImage = global::POFDemo.Properties.Resources.refresh;
            this.butRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRefresh.FlatAppearance.BorderSize = 0;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Location = new System.Drawing.Point(295, 746);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(44, 40);
            this.butRefresh.TabIndex = 32;
            this.toolTipSearch.SetToolTip(this.butRefresh, "بحث");
            this.toolTipRefresh.SetToolTip(this.butRefresh, "إعادة تهيئة");
            this.butRefresh.UseVisualStyleBackColor = false;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(1153, 403);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(260, 31);
            this.numericUpDownPrice.TabIndex = 51;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(750, 271);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(209, 31);
            this.numericUpDownQuantity.TabIndex = 50;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQuantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // labelPoductImage
            // 
            this.labelPoductImage.AutoSize = true;
            this.labelPoductImage.BackColor = System.Drawing.Color.Transparent;
            this.labelPoductImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPoductImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoductImage.Location = new System.Drawing.Point(968, 375);
            this.labelPoductImage.Name = "labelPoductImage";
            this.labelPoductImage.Size = new System.Drawing.Size(135, 32);
            this.labelPoductImage.TabIndex = 49;
            this.labelPoductImage.Text = "صورة المنتج";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(997, 267);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(74, 32);
            this.labelQuantity.TabIndex = 48;
            this.labelQuantity.Text = "الكمية";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.BackColor = System.Drawing.Color.Transparent;
            this.labelNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNotes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(1445, 459);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(110, 32);
            this.labelNotes.TabIndex = 47;
            this.labelNotes.Text = "ملاحاظات";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(1450, 400);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(107, 32);
            this.labelPrice.TabIndex = 46;
            this.labelPrice.Text = "السعر (ج)";
            // 
            // textNotes
            // 
            this.textNotes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNotes.Location = new System.Drawing.Point(1153, 476);
            this.textNotes.MaxLength = 50;
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(260, 140);
            this.textNotes.TabIndex = 45;
            this.textNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNotes.UseSystemPasswordChar = true;
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductPictureBox.Location = new System.Drawing.Point(750, 384);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(209, 137);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 43;
            this.ProductPictureBox.TabStop = false;
            this.ProductPictureBox.Click += new System.EventHandler(this.ProductPictureBox_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(1446, 334);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 32);
            this.labelName.TabIndex = 42;
            this.labelName.Text = "اسم المنتج";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.Color.Transparent;
            this.labelCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(1465, 270);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(86, 32);
            this.labelCode.TabIndex = 41;
            this.labelCode.Text = "الباركود";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(1153, 332);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 35);
            this.textBoxName.TabIndex = 40;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelHeader.Location = new System.Drawing.Point(1340, 172);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(215, 40);
            this.labelHeader.TabIndex = 39;
            this.labelHeader.Text = " تعديل المنتج <-";
            // 
            // textBoxCode
            // 
            this.textBoxCode.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textBoxCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(1153, 267);
            this.textBoxCode.MaxLength = 50;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(260, 35);
            this.textBoxCode.TabIndex = 38;
            this.textBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
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
            this.butٍSaveChanges.Location = new System.Drawing.Point(778, 578);
            this.butٍSaveChanges.Name = "butٍSaveChanges";
            this.butٍSaveChanges.Size = new System.Drawing.Size(170, 38);
            this.butٍSaveChanges.TabIndex = 37;
            this.butٍSaveChanges.Text = "حفظ التعديلات";
            this.butٍSaveChanges.UseVisualStyleBackColor = false;
            this.butٍSaveChanges.Click += new System.EventHandler(this.butٍSaveChanges_Click);
            // 
            // linkLabelAddImage
            // 
            this.linkLabelAddImage.AutoSize = true;
            this.linkLabelAddImage.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAddImage.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAddImage.Location = new System.Drawing.Point(806, 382);
            this.linkLabelAddImage.Name = "linkLabelAddImage";
            this.linkLabelAddImage.Size = new System.Drawing.Size(94, 31);
            this.linkLabelAddImage.TabIndex = 44;
            this.linkLabelAddImage.TabStop = true;
            this.linkLabelAddImage.Text = "إضافة صورة";
            this.linkLabelAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddImage_LinkClicked);
            // 
            // butDeleteProduct
            // 
            this.butDeleteProduct.BackColor = System.Drawing.Color.White;
            this.butDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.butDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeleteProduct.ForeColor = System.Drawing.Color.Red;
            this.butDeleteProduct.Location = new System.Drawing.Point(778, 633);
            this.butDeleteProduct.Name = "butDeleteProduct";
            this.butDeleteProduct.Size = new System.Drawing.Size(170, 38);
            this.butDeleteProduct.TabIndex = 52;
            this.butDeleteProduct.Text = "حذف المنتج";
            this.butDeleteProduct.UseVisualStyleBackColor = false;
            this.butDeleteProduct.Click += new System.EventHandler(this.butDeleteProduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(778, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 53;
            this.button1.Text = "إضافة منتج جديد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.butPrevious.Location = new System.Drawing.Point(127, 747);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(77, 38);
            this.butPrevious.TabIndex = 56;
            this.butPrevious.Text = "<< 20";
            this.butPrevious.UseVisualStyleBackColor = false;
            this.butPrevious.Click += new System.EventHandler(this.butPrevious_Click);
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
            this.butNext.Location = new System.Drawing.Point(426, 746);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(77, 38);
            this.butNext.TabIndex = 57;
            this.butNext.Text = "20 >>";
            this.butNext.UseVisualStyleBackColor = false;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butAddCategory
            // 
            this.butAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.butAddCategory.BackgroundImage = global::POFDemo.Properties.Resources.add;
            this.butAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddCategory.FlatAppearance.BorderSize = 0;
            this.butAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddCategory.Location = new System.Drawing.Point(696, 322);
            this.butAddCategory.Name = "butAddCategory";
            this.butAddCategory.Size = new System.Drawing.Size(41, 36);
            this.butAddCategory.TabIndex = 60;
            this.butAddCategory.UseVisualStyleBackColor = false;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.categoryBindingSource;
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(750, 323);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(209, 33);
            this.comboBoxCategory.TabIndex = 59;
            this.comboBoxCategory.ValueMember = "id";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(995, 321);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(84, 32);
            this.labelCategory.TabIndex = 58;
            this.labelCategory.Text = "الصنف";
            // 
            // pOSDEMODataSet2
            // 
            this.pOSDEMODataSet2.DataSetName = "POSDEMODataSet2";
            this.pOSDEMODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.pOSDEMODataSet2;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // ProductsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1593, 847);
            this.Controls.Add(this.butAddCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPrevious);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butDeleteProduct);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelPoductImage);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.butٍSaveChanges);
            this.Controls.Add(this.linkLabelAddImage);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelproductname);
            this.Controls.Add(this.labelBarcode);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.textBarcode);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المنتجات";
            this.Load += new System.EventHandler(this.ProductsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDEMODataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.ToolTip toolTipClean;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.ToolTip toolTipRefresh;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelPoductImage;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button butٍSaveChanges;
        private System.Windows.Forms.LinkLabel linkLabelAddImage;
        private System.Windows.Forms.Button butDeleteProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butPrevious;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butAddCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private POSDEMODataSet2 pOSDEMODataSet2;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private POSDEMODataSet2TableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}