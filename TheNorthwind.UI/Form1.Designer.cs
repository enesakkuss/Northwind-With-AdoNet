namespace TheNorthwind.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategoriesForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreatCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductCreatForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplierListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreatNewSupplierList = new System.Windows.Forms.ToolStripMenuItem();
            this.nakliyeYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShipperCreatForm = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployeeListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluFiyatGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateProductPricesBySupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateProductPriceSByCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.tedarikçiYönetimiToolStripMenuItem,
            this.nakliyeYönetimiToolStripMenuItem,
            this.çalışanYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategoriesForm,
            this.menuCreatCategory});
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // menuCategoriesForm
            // 
            this.menuCategoriesForm.Name = "menuCategoriesForm";
            this.menuCategoriesForm.Size = new System.Drawing.Size(142, 22);
            this.menuCategoriesForm.Text = "Kategoriler";
            this.menuCategoriesForm.Click += new System.EventHandler(this.menuCategoriesForm_Click);
            // 
            // menuCreatCategory
            // 
            this.menuCreatCategory.Name = "menuCreatCategory";
            this.menuCreatCategory.Size = new System.Drawing.Size(142, 22);
            this.menuCreatCategory.Text = "Kategori Ekle";
            this.menuCreatCategory.Click += new System.EventHandler(this.menuCreatCategory_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductListForm,
            this.menuProductCreatForm,
            this.topluFiyatGüncellemeToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuProductListForm
            // 
            this.menuProductListForm.Name = "menuProductListForm";
            this.menuProductListForm.Size = new System.Drawing.Size(197, 22);
            this.menuProductListForm.Text = "Ürünler";
            this.menuProductListForm.Click += new System.EventHandler(this.menuProductListForm_Click);
            // 
            // menuProductCreatForm
            // 
            this.menuProductCreatForm.Name = "menuProductCreatForm";
            this.menuProductCreatForm.Size = new System.Drawing.Size(197, 22);
            this.menuProductCreatForm.Text = "Yeni Ürün Oluştur";
            this.menuProductCreatForm.Click += new System.EventHandler(this.menuProductCreatForm_Click);
            // 
            // tedarikçiYönetimiToolStripMenuItem
            // 
            this.tedarikçiYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSupplierListForm,
            this.MenuCreatNewSupplierList});
            this.tedarikçiYönetimiToolStripMenuItem.Name = "tedarikçiYönetimiToolStripMenuItem";
            this.tedarikçiYönetimiToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.tedarikçiYönetimiToolStripMenuItem.Text = "Tedarikçi Yönetimi";
            // 
            // menuSupplierListForm
            // 
            this.menuSupplierListForm.Name = "menuSupplierListForm";
            this.menuSupplierListForm.Size = new System.Drawing.Size(187, 22);
            this.menuSupplierListForm.Text = "Tedarikçiler";
            this.menuSupplierListForm.Click += new System.EventHandler(this.menuSupplierListForm_Click);
            // 
            // MenuCreatNewSupplierList
            // 
            this.MenuCreatNewSupplierList.Name = "MenuCreatNewSupplierList";
            this.MenuCreatNewSupplierList.Size = new System.Drawing.Size(187, 22);
            this.MenuCreatNewSupplierList.Text = "Yeni Tedarikçi Oluştur";
            this.MenuCreatNewSupplierList.Click += new System.EventHandler(this.MenuCreatNewSupplierList_Click);
            // 
            // nakliyeYönetimiToolStripMenuItem
            // 
            this.nakliyeYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShipperListForm,
            this.menuShipperCreatForm});
            this.nakliyeYönetimiToolStripMenuItem.Name = "nakliyeYönetimiToolStripMenuItem";
            this.nakliyeYönetimiToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.nakliyeYönetimiToolStripMenuItem.Text = "Nakliye Şirketleri Yönetimi";
            // 
            // menuShipperListForm
            // 
            this.menuShipperListForm.Name = "menuShipperListForm";
            this.menuShipperListForm.Size = new System.Drawing.Size(157, 22);
            this.menuShipperListForm.Text = "Nakliyeci Listesi";
            this.menuShipperListForm.Click += new System.EventHandler(this.menuShipperListForm_Click);
            // 
            // menuShipperCreatForm
            // 
            this.menuShipperCreatForm.Name = "menuShipperCreatForm";
            this.menuShipperCreatForm.Size = new System.Drawing.Size(157, 22);
            this.menuShipperCreatForm.Text = "Nakliyeci Ekle";
            this.menuShipperCreatForm.Click += new System.EventHandler(this.menuShipperCreatForm_Click);
            // 
            // çalışanYönetimiToolStripMenuItem
            // 
            this.çalışanYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployeeListForm,
            this.çalışanEkleToolStripMenuItem});
            this.çalışanYönetimiToolStripMenuItem.Name = "çalışanYönetimiToolStripMenuItem";
            this.çalışanYönetimiToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.çalışanYönetimiToolStripMenuItem.Text = "Çalışan Yönetimi";
            // 
            // menuEmployeeListForm
            // 
            this.menuEmployeeListForm.Name = "menuEmployeeListForm";
            this.menuEmployeeListForm.Size = new System.Drawing.Size(180, 22);
            this.menuEmployeeListForm.Text = "Çalışan Listesi";
            this.menuEmployeeListForm.Click += new System.EventHandler(this.menuEmployeeListForm_Click);
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            this.çalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.çalışanEkleToolStripMenuItem_Click);
            // 
            // topluFiyatGüncellemeToolStripMenuItem
            // 
            this.topluFiyatGüncellemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUpdateProductPricesBySupplier,
            this.menuUpdateProductPriceSByCategory});
            this.topluFiyatGüncellemeToolStripMenuItem.Name = "topluFiyatGüncellemeToolStripMenuItem";
            this.topluFiyatGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.topluFiyatGüncellemeToolStripMenuItem.Text = "Toplu Fiyat Güncelleme";
            // 
            // menuUpdateProductPricesBySupplier
            // 
            this.menuUpdateProductPricesBySupplier.Name = "menuUpdateProductPricesBySupplier";
            this.menuUpdateProductPricesBySupplier.Size = new System.Drawing.Size(180, 22);
            this.menuUpdateProductPricesBySupplier.Text = "Tedarikçiye Göre";
            this.menuUpdateProductPricesBySupplier.Click += new System.EventHandler(this.menuUpdateProductPricesBySupplier_Click);
            // 
            // menuUpdateProductPriceSByCategory
            // 
            this.menuUpdateProductPriceSByCategory.Name = "menuUpdateProductPriceSByCategory";
            this.menuUpdateProductPriceSByCategory.Size = new System.Drawing.Size(180, 22);
            this.menuUpdateProductPriceSByCategory.Text = "Kategoriye Göre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuCategoriesForm;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuProductListForm;
        private ToolStripMenuItem menuProductCreatForm;
        private ToolStripMenuItem menuCreatCategory;
        private ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuSupplierListForm;
        private ToolStripMenuItem MenuCreatNewSupplierList;
        private ToolStripMenuItem nakliyeYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuShipperListForm;
        private ToolStripMenuItem menuShipperCreatForm;
        private ToolStripMenuItem çalışanYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuEmployeeListForm;
        private ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private ToolStripMenuItem topluFiyatGüncellemeToolStripMenuItem;
        private ToolStripMenuItem menuUpdateProductPricesBySupplier;
        private ToolStripMenuItem menuUpdateProductPriceSByCategory;
    }
}