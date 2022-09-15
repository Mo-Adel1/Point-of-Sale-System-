namespace POFDemo.Screens.Categories
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            this.labelSuppliers = new System.Windows.Forms.Label();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.linkLabelAddCategory = new System.Windows.Forms.LinkLabel();
            this.linkLabelDeletCategory = new System.Windows.Forms.LinkLabel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.pOSDEMODataSet1 = new POFDemo.POSDEMODataSet1();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new POFDemo.POSDEMODataSet1TableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDEMODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSuppliers
            // 
            this.labelSuppliers.AutoSize = true;
            this.labelSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.labelSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSuppliers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuppliers.Location = new System.Drawing.Point(351, 18);
            this.labelSuppliers.Name = "labelSuppliers";
            this.labelSuppliers.Size = new System.Drawing.Size(96, 37);
            this.labelSuppliers.TabIndex = 100;
            this.labelSuppliers.Text = "الصنف";
            // 
            // textCategory
            // 
            this.textCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "mohammed",
            "adel",
            "salah",
            "ibraheem"});
            this.textCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategory.Location = new System.Drawing.Point(231, 103);
            this.textCategory.MaxLength = 50;
            this.textCategory.Multiline = true;
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(385, 39);
            this.textCategory.TabIndex = 101;
            this.textCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabelAddCategory
            // 
            this.linkLabelAddCategory.AutoSize = true;
            this.linkLabelAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAddCategory.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAddCategory.LinkColor = System.Drawing.Color.Green;
            this.linkLabelAddCategory.Location = new System.Drawing.Point(160, 107);
            this.linkLabelAddCategory.Name = "linkLabelAddCategory";
            this.linkLabelAddCategory.Size = new System.Drawing.Size(55, 34);
            this.linkLabelAddCategory.TabIndex = 119;
            this.linkLabelAddCategory.TabStop = true;
            this.linkLabelAddCategory.Text = "إضافة";
            this.linkLabelAddCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddCategory_LinkClicked);
            // 
            // linkLabelDeletCategory
            // 
            this.linkLabelDeletCategory.AutoSize = true;
            this.linkLabelDeletCategory.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelDeletCategory.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDeletCategory.LinkColor = System.Drawing.Color.Red;
            this.linkLabelDeletCategory.Location = new System.Drawing.Point(159, 173);
            this.linkLabelDeletCategory.Name = "linkLabelDeletCategory";
            this.linkLabelDeletCategory.Size = new System.Drawing.Size(56, 34);
            this.linkLabelDeletCategory.TabIndex = 120;
            this.linkLabelDeletCategory.TabStop = true;
            this.linkLabelDeletCategory.Text = "حذف";
            this.linkLabelDeletCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeletCategory_LinkClicked);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.categoryBindingSource;
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(231, 171);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(385, 38);
            this.comboBoxCategory.TabIndex = 121;
            this.comboBoxCategory.ValueMember = "id";
            // 
            // pOSDEMODataSet1
            // 
            this.pOSDEMODataSet1.DataSetName = "POSDEMODataSet1";
            this.pOSDEMODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.pOSDEMODataSet1;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POFDemo.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 262);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.linkLabelDeletCategory);
            this.Controls.Add(this.linkLabelAddCategory);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.labelSuppliers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 301);
            this.MinimumSize = new System.Drawing.Size(795, 301);
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الصنف";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDEMODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuppliers;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.LinkLabel linkLabelAddCategory;
        private System.Windows.Forms.LinkLabel linkLabelDeletCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private POSDEMODataSet1 pOSDEMODataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private POSDEMODataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}