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
    public partial class SupplierUpdateForm : Form
    {
        private SupplierService _supplier = new SupplierService();
        private int _supplierId;
        private Supplier supplier;
        public SupplierUpdateForm(int supplierId)
        {
            InitializeComponent();
            _supplierId = supplierId;
        }
        public SupplierUpdateForm()
        {
            InitializeComponent();
        }


        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            supplier = _supplier.GetById(_supplierId);
            txtCompanyName.Text = supplier.CompanyName;
            txtContactName.Text = supplier.ContactName;
            txtContactTitle.Text = supplier.ContactTitle;
            txtCountry.Text = supplier.Country;
            txtFax.Text = supplier.Fax;
            txtPhone.Text = supplier.Phone;
            txtPostalCode.Text = supplier.PostalCode;
            txtRegion.Text = supplier.Region;
            txtHomepage.Text = supplier.HomePage;
            txtCity.Text = supplier.City;
            txtAdress.Text = supplier.Address;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            supplier = new Supplier()
            {
                Id = _supplierId,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Country = txtCountry.Text,
                Fax = txtFax.Text,
                Phone = txtPhone.Text,
                PostalCode = txtPostalCode.Text,
                Region = txtRegion.Text,
                HomePage = txtHomepage.Text,
                City = txtCity.Text,
                Address = txtAdress.Text
            };

            var result=_supplier.Update(supplier);

            if(result.IsSuccess)
            {
                Close();
                var form =new SupplierListForm();
                form.Show();
            }
            else
            {
                MessageBox.Show(result.Message);
            }

        }
    }
}
