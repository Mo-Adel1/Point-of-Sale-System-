namespace POFDemo.Screens.Products
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.labelproductname = new System.Windows.Forms.Label();
            this.butClean = new System.Windows.Forms.Button();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBarcode = new System.Windows.Forms.TextBox();
            this.butAddProduct = new System.Windows.Forms.Button();
            this.toolTipAddProduct = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClean = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPictureBox = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelAddImage = new System.Windows.Forms.LinkLabel();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPoductImage = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.toolTipRequire1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRequire2 = new System.Windows.Forms.ToolTip(this.components);
            this.labelRequier2 = new System.Windows.Forms.Label();
            this.labelRequier1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDEMODataSet = new POFDemo.POSDEMODataSet();
            this.categoryTableAdapter = new POFDemo.POSDEMODataSetTableAdapters.CategoryTableAdapter();
            this.butAddCategory = new System.Windows.Forms.Button();
            this.toolTipAddCategory = new System.Windows.Forms.ToolTip(this.components);
            this.labelRequier3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDEMODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductPictureBox.Location = new System.Drawing.Point(53, 265);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(247, 137);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 25;
            this.ProductPictureBox.TabStop = false;
            this.toolTipPictureBox.SetToolTip(this.ProductPictureBox, "اضغط هنا لتغير الصورة");
            this.ProductPictureBox.Click += new System.EventHandler(this.ProductPictureBox_Click);
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.BackColor = System.Drawing.Color.Transparent;
            this.labelproductname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelproductname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(821, 188);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(119, 32);
            this.labelproductname.TabIndex = 24;
            this.labelproductname.Text = "اسم المنتج";
            // 
            // butClean
            // 
            this.butClean.BackColor = System.Drawing.Color.Transparent;
            this.butClean.BackgroundImage = global::POFDemo.Properties.Resources.cleaning;
            this.butClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClean.FlatAppearance.BorderSize = 0;
            this.butClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClean.Location = new System.Drawing.Point(2, 463);
            this.butClean.Name = "butClean";
            this.butClean.Size = new System.Drawing.Size(63, 59);
            this.butClean.TabIndex = 23;
            this.toolTipClean.SetToolTip(this.butClean, "تنظيف البيانات المدخلة");
            this.butClean.UseVisualStyleBackColor = false;
            this.butClean.Click += new System.EventHandler(this.butClean_Click);
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.BackColor = System.Drawing.Color.Transparent;
            this.labelBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBarcode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(840, 124);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(86, 32);
            this.labelBarcode.TabIndex = 22;
            this.labelBarcode.Text = "الباركود";
            // 
            // textProductName
            // 
            this.textProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProductName.Location = new System.Drawing.Point(528, 186);
            this.textProductName.MaxLength = 50;
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(260, 35);
            this.textProductName.TabIndex = 21;
            this.textProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textProductName.TextChanged += new System.EventHandler(this.textProductName_TextChanged);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(399, 23);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(152, 40);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "إضافة منتج";
            // 
            // textBarcode
            // 
            this.textBarcode.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textBarcode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBarcode.Location = new System.Drawing.Point(528, 121);
            this.textBarcode.MaxLength = 50;
            this.textBarcode.Name = "textBarcode";
            this.textBarcode.Size = new System.Drawing.Size(260, 35);
            this.textBarcode.TabIndex = 19;
            this.textBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBarcode.TextChanged += new System.EventHandler(this.textBarcode_TextChanged);
            // 
            // butAddProduct
            // 
            this.butAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.butAddProduct.BackgroundImage = global::POFDemo.Properties.Resources.add;
            this.butAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddProduct.FlatAppearance.BorderSize = 0;
            this.butAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddProduct.Location = new System.Drawing.Point(204, 417);
            this.butAddProduct.Name = "butAddProduct";
            this.butAddProduct.Size = new System.Drawing.Size(84, 77);
            this.butAddProduct.TabIndex = 18;
            this.toolTipAddProduct.SetToolTip(this.butAddProduct, "إضافة المنتج");
            this.butAddProduct.UseVisualStyleBackColor = false;
            this.butAddProduct.Click += new System.EventHandler(this.butAddProduct_Click);
            // 
            // linkLabelAddImage
            // 
            this.linkLabelAddImage.AutoSize = true;
            this.linkLabelAddImage.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAddImage.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAddImage.Location = new System.Drawing.Point(158, 264);
            this.linkLabelAddImage.Name = "linkLabelAddImage";
            this.linkLabelAddImage.Size = new System.Drawing.Size(94, 31);
            this.linkLabelAddImage.TabIndex = 27;
            this.linkLabelAddImage.TabStop = true;
            this.linkLabelAddImage.Text = "إضافة صورة";
            this.linkLabelAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddImage_LinkClicked);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.BackColor = System.Drawing.Color.Transparent;
            this.labelNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNotes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(820, 313);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(110, 32);
            this.labelNotes.TabIndex = 31;
            this.labelNotes.Text = "ملاحاظات";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(825, 254);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(107, 32);
            this.labelPrice.TabIndex = 30;
            this.labelPrice.Text = "السعر (ج)";
            // 
            // textNotes
            // 
            this.textNotes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNotes.Location = new System.Drawing.Point(528, 330);
            this.textNotes.MaxLength = 50;
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(260, 140);
            this.textNotes.TabIndex = 29;
            this.textNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNotes.UseSystemPasswordChar = true;
            this.textNotes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(338, 117);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(74, 32);
            this.labelQuantity.TabIndex = 33;
            this.labelQuantity.Text = "الكمية";
            // 
            // labelPoductImage
            // 
            this.labelPoductImage.AutoSize = true;
            this.labelPoductImage.BackColor = System.Drawing.Color.Transparent;
            this.labelPoductImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPoductImage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoductImage.Location = new System.Drawing.Point(309, 257);
            this.labelPoductImage.Name = "labelPoductImage";
            this.labelPoductImage.Size = new System.Drawing.Size(135, 32);
            this.labelPoductImage.TabIndex = 34;
            this.labelPoductImage.Text = "صورة المنتج";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(53, 121);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(247, 31);
            this.numericUpDownQuantity.TabIndex = 35;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQuantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(528, 257);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(260, 31);
            this.numericUpDownPrice.TabIndex = 36;
            this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // labelRequier2
            // 
            this.labelRequier2.AutoSize = true;
            this.labelRequier2.BackColor = System.Drawing.Color.White;
            this.labelRequier2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRequier2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequier2.ForeColor = System.Drawing.Color.Red;
            this.labelRequier2.Location = new System.Drawing.Point(531, 189);
            this.labelRequier2.Name = "labelRequier2";
            this.labelRequier2.Size = new System.Drawing.Size(22, 30);
            this.labelRequier2.TabIndex = 42;
            this.labelRequier2.Text = "*";
            this.labelRequier2.Click += new System.EventHandler(this.labelRequier2_Click);
            // 
            // labelRequier1
            // 
            this.labelRequier1.AutoSize = true;
            this.labelRequier1.BackColor = System.Drawing.Color.White;
            this.labelRequier1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRequier1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequier1.ForeColor = System.Drawing.Color.Red;
            this.labelRequier1.Location = new System.Drawing.Point(531, 124);
            this.labelRequier1.Name = "labelRequier1";
            this.labelRequier1.Size = new System.Drawing.Size(22, 30);
            this.labelRequier1.TabIndex = 41;
            this.labelRequier1.Text = "*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(771, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 54;
            this.button1.Text = "عرض كل المنتجات";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(334, 186);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(84, 32);
            this.labelCategory.TabIndex = 55;
            this.labelCategory.Text = "الصنف";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.categoryBindingSource;
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(53, 184);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(247, 38);
            this.comboBoxCategory.TabIndex = 56;
            this.comboBoxCategory.ValueMember = "id";
            this.comboBoxCategory.SelectedValueChanged += new System.EventHandler(this.comboBoxCategory_SelectedValueChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.pOSDEMODataSet;
            // 
            // pOSDEMODataSet
            // 
            this.pOSDEMODataSet.DataSetName = "POSDEMODataSet";
            this.pOSDEMODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // butAddCategory
            // 
            this.butAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.butAddCategory.BackgroundImage = global::POFDemo.Properties.Resources.add;
            this.butAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddCategory.FlatAppearance.BorderSize = 0;
            this.butAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddCategory.Location = new System.Drawing.Point(8, 185);
            this.butAddCategory.Name = "butAddCategory";
            this.butAddCategory.Size = new System.Drawing.Size(41, 36);
            this.butAddCategory.TabIndex = 57;
            this.toolTipAddProduct.SetToolTip(this.butAddCategory, "إضافة المنتج");
            this.toolTipAddCategory.SetToolTip(this.butAddCategory, "إضافة صنف جديد");
            this.butAddCategory.UseVisualStyleBackColor = false;
            this.butAddCategory.Click += new System.EventHandler(this.butAddCategory_Click);
            // 
            // labelRequier3
            // 
            this.labelRequier3.AutoSize = true;
            this.labelRequier3.BackColor = System.Drawing.Color.White;
            this.labelRequier3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRequier3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequier3.ForeColor = System.Drawing.Color.Red;
            this.labelRequier3.Location = new System.Drawing.Point(55, 188);
            this.labelRequier3.Name = "labelRequier3";
            this.labelRequier3.Size = new System.Drawing.Size(22, 30);
            this.labelRequier3.TabIndex = 58;
            this.labelRequier3.Text = "*";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 522);
            this.Controls.Add(this.labelRequier3);
            this.Controls.Add(this.butAddCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRequier2);
            this.Controls.Add(this.labelRequier1);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelPoductImage);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.labelproductname);
            this.Controls.Add(this.butClean);
            this.Controls.Add(this.labelBarcode);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.textBarcode);
            this.Controls.Add(this.butAddProduct);
            this.Controls.Add(this.linkLabelAddImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(981, 561);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(981, 561);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتج";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDEMODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.ToolTip toolTipPictureBox;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Button butClean;
        private System.Windows.Forms.ToolTip toolTipClean;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBarcode;
        private System.Windows.Forms.Button butAddProduct;
        private System.Windows.Forms.ToolTip toolTipAddProduct;
        private System.Windows.Forms.LinkLabel linkLabelAddImage;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPoductImage;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ToolTip toolTipRequire1;
        private System.Windows.Forms.ToolTip toolTipRequire2;
        private System.Windows.Forms.Label labelRequier2;
        private System.Windows.Forms.Label labelRequier1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private POSDEMODataSet pOSDEMODataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private POSDEMODataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button butAddCategory;
        private System.Windows.Forms.ToolTip toolTipAddCategory;
        private System.Windows.Forms.Label labelRequier3;
    }
}