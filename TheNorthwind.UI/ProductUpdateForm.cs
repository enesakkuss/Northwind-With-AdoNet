using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI
{
    public partial class ProductUpdateForm : Form
    {
        private ProductService _productService = new ProductService();
        private Product product;
        private int _productId;
        public ProductUpdateForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            var categoryService = new CategoryService();
            var categories = categoryService.GetAll();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            var supplierService = new SupplierService();
            var supplier = supplierService.GetAll();
            cmbSupplier.DataSource = supplier;
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "Id";

            product = _productService.Find(_productId);
            txtName.Text = product.Name;
            cmbCategory.SelectedValue = product.CategoryID;
            cmbSupplier.SelectedValue = product.SupplierId;
            txtQuantityPerUnit.Text= product.QuantityPerUnit;
            numUnitPrice.Value = (int)product.UnitPrice;
            numUnitInStock.Value = (int)product.UnitsInStock;
            numUnitsOnOrder.Value= (int)product.UnitsOnOrder;
            numReorderLevel.Value = (int)product.ReorderLevel;
            chkDiscontinued.Checked = product.Discontinued;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            product = new Product()
            {
                Id = _productId,
                Name = txtName.Text,
                CategoryID = (int)cmbCategory.SelectedValue,
                SupplierId = (int)cmbSupplier.SelectedValue,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = numUnitPrice.Value,
                UnitsInStock = (short?)numUnitInStock.Value,
                UnitsOnOrder = (short?)numUnitsOnOrder.Value,
                ReorderLevel = (short?)numUnitsOnOrder.Value,
                Discontinued = chkDiscontinued.Checked
            };

            var result = _productService.Update(product);
        }
    }
}
