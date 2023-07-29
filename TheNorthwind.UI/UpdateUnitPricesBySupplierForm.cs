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
    public partial class UpdateUnitPricesBySupplierForm : Form
    {
        private readonly SupplierService _supplierService=new SupplierService();
        private readonly ProductService _productService=new ProductService();
        public UpdateUnitPricesBySupplierForm()
        {
            InitializeComponent();
        }

        private void UpdateUnitPricesBySupplierForm_Load(object sender, EventArgs e)
        {
            cmbSupplier.DataSource = _supplierService.GetAll();
            cmbSupplier.DisplayMember= "CompanyName";
            cmbSupplier.ValueMember = "Id";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var supplierId=(int)cmbSupplier.SelectedValue;
            var changeRate= numPriceChangeRate.Value;
            var isDiscount= rbtDiscount.Checked;

            var productsToBeUpdated = _productService.GetBySupplierId(supplierId);
            var confirmationBox = new UpdateUnitPricesConfimartionBox(productsToBeUpdated);
            var dialogResult=confirmationBox.ShowDialog();

            if(dialogResult == DialogResult.Yes)
            {
                var ret =
                  _productService.UpdatePricesBySupplier(supplierId, changeRate, isDiscount);

                if (ret.IsSuccess)
                {
                    Close();
                    var form = new ProductListForm();
                    form.Show();
                }
                else
                {
                    MessageBox.Show(ret.Message);
                }
            }
            
        }
    }
}
