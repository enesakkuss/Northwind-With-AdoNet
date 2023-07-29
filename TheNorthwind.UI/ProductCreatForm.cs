using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI
{
    public partial class ProductCreatForm : Form
    {
        private ProductService _productService = new ProductService();
        public ProductCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Name = txtName.Text,
                CategoryID = (int)cmbCategory.SelectedValue,
                SupplierId = (int)cmbSupplier.SelectedValue,
                QuantityPerUnit=txtQuantityPerUnit.Text,
                UnitPrice=numUnitPrice.Value,
                UnitsInStock=(short)numUnitInStock.Value,
                UnitsOnOrder=(short)numUnitsOnOrder.Value,
                ReorderLevel=(short)numReorderLevel.Value,
                Discontinued=chkDiscontinued.Checked
            };

            var result = _productService.Creat(product);

            if(result.IsSuccess)
            {
                Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }


//            var product = new Product()
//            {
//                Name = txtName.Text,
//                SupplierId = (int)cmbSupplier.SelectedValue,
//                CategoryID = (int)cmbCategory.SelectedValue,
//                QuantityPerUnit = txtQuantityPerUnit.Text,
//                UnitPrice = numUnitPrice.Value,
//                UnitsInStock = (short)numUnitInStock.Value,
//                UnitsOnOrder = (short)numUnitsOnOrder.Value,
//                ReorderLevel = (short)numUnitsOnOrder.Value,
//                Discontinued = chkDiscontinued.Checked
//            };

//            using (var sqlConnection= new SqlConnection(DbSetting.Conntection))
            
//                // bişey.Creat() metotlarına Factory Metod (factory pattern) denir
//            using (var sqlCommand=sqlConnection.CreateCommand())
//            {
//                try
//                {
//                    sqlCommand.CommandText = @"
//INSERT INTO [dbo].[Products]
//           ([ProductName],[SupplierID],[CategoryID],[QuantityPerUnit],[UnitPrice],
//[UnitsInStock],[UnitsOnOrder],[ReorderLevel],[Discontinued])
//VALUES
//(@productName,@supplierID,@categoryID,@quantityPerUnit,@unitPrice,@unitsInStock,
//@unitsOnOrder,@reorderLevel,@discontinued)";

//                    sqlCommand.Parameters.AddWithValue("@productName", product.Name);
//                    sqlCommand.Parameters.AddWithValue("@supplierID", product.SupplierId);
//                    sqlCommand.Parameters.AddWithValue("@categoryID", product.CategoryID);
//                    sqlCommand.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit);
//                    sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
//                    sqlCommand.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
//                    sqlCommand.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder);
//                    sqlCommand.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
//                    sqlCommand.Parameters.AddWithValue("@discontinued", product.Discontinued);
                    
//                    sqlConnection.Open();
//                    var affectedRows=sqlCommand.ExecuteNonQuery();
//                    sqlConnection.Close();

//                    if(affectedRows>0)
//                    {
//                        MessageBox.Show("Kaydedildi");
//                    }
//                    else
//                    {
//                        MessageBox.Show("Kaydedilemedi Hata");
//                    }
//                }
//                catch (Exception ex)
//                {

//                    MessageBox.Show("Hata Yaptın Koçum");
//                }
//            }
        }

        private void ProductCreatForm_Load(object sender, EventArgs e)
        {
            var categoryService = new CategoryService();
            var categories = categoryService.GetAll();
            cmbCategory.DataSource=categories;
            cmbCategory.DisplayMember= "Name";
            cmbCategory.ValueMember="Id";

            var supplierService=new SupplierService();
            var supplier=supplierService.GetAll();
            cmbSupplier.DataSource=supplier;
            cmbSupplier.DisplayMember="CompanyName";
            cmbSupplier.ValueMember = "Id";
        }
    }
}
