namespace TheNorthwind.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuCategoriesForm_Click(object sender, EventArgs e)
        {
            var categoriesListForm=new CategoryListForm();
            categoriesListForm.MdiParent= this;
            categoriesListForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
        }

        private void menuProductListForm_Click(object sender, EventArgs e)
        {
            var productListForm=new ProductListForm();
            productListForm.MdiParent= this;
            productListForm.Show();
        }

        private void menuProductCreatForm_Click(object sender, EventArgs e)
        {
            var productCrearForm=new ProductCreatForm();
            productCrearForm.MdiParent= this;
            productCrearForm.Show();
        }

        private void menuCreatCategory_Click(object sender, EventArgs e)
        {
            var categoryCreatForm=new CategoryCreatForm();
            categoryCreatForm.MdiParent= this;
            categoryCreatForm.Show();
        }

        private void menuSupplierListForm_Click(object sender, EventArgs e)
        {
            var supplierListForm=new SupplierListForm();
            supplierListForm.MdiParent= this;
            supplierListForm.Show();
        }

        private void MenuCreatNewSupplierList_Click(object sender, EventArgs e)
        {
            var supplierCreatForm= new SupplierCreatForm();
            supplierCreatForm.MdiParent= this;
            supplierCreatForm.Show();
        }

        private void menuShipperListForm_Click(object sender, EventArgs e)
        {
            var shipperListForm = new ShipperListForm();
            shipperListForm.MdiParent= this;
            shipperListForm.Show();
        }

        private void menuShipperCreatForm_Click(object sender, EventArgs e)
        {
            var shipperCreatForm = new ShipperCreatForm();
            shipperCreatForm.MdiParent= this;
            shipperCreatForm.Show();
        }

        private void menuEmployeeListForm_Click(object sender, EventArgs e)
        {
            var employeeListForm = new EmployeeListForm();
            employeeListForm.MdiParent= this;
            employeeListForm.Show();
        }

        private void çalýþanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeCreatForm = new EmployeeCreatForm();
            employeeCreatForm.MdiParent = this;
            employeeCreatForm.Show();
        }

        private void menuUpdateProductPricesBySupplier_Click(object sender, EventArgs e)
        {
            var updateProductPricesBySupplier=new UpdateUnitPricesBySupplierForm();
            updateProductPricesBySupplier.MdiParent = this;
            updateProductPricesBySupplier.Show();
        }
    }
}