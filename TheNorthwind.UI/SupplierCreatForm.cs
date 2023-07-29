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
    public partial class SupplierCreatForm : Form
    {
        private SupplierService _supplier = new SupplierService();
        public SupplierCreatForm()
        {
            InitializeComponent();
        }

        private void SupplierCreatForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier()
            {
                CompanyName= txtCompanyName.Text,
                ContactName= txtContactName.Text,
                ContactTitle= txtContactTitle.Text,
                City= txtCity.Text,
                Region= txtRegion.Text,
                PostalCode= txtPostalCode.Text,
                Country= txtCountry.Text,
                Address=txtAdress.Text,
                Fax=txtFax.Text,
                HomePage=txtHomepage.Text,
                Phone=txtPhone.Text
            };

            var result = _supplier.Create(supplier);

            if (result.IsSuccess)
            {
                Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
