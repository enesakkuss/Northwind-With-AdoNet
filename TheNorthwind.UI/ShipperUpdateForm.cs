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
    public partial class ShipperUpdateForm : Form
    {
        private ShipperService _shipper = new ShipperService();
        private int shipperId;
        private Shipper shipper;
        public ShipperUpdateForm()
        {
            InitializeComponent();
        }
        public ShipperUpdateForm(int id)
        {
            InitializeComponent();
            shipperId= id;
        }

        private void ShipperUpdateForm_Load(object sender, EventArgs e)
        {
            shipper=_shipper.GetById(shipperId);
            txtCompanyName.Text=shipper.CompanyName;
            txtPhone.Text = shipper.Phone;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            shipper = new Shipper()
            {
                Id= shipperId,
                CompanyName = txtCompanyName.Text,
                Phone = txtPhone.Text
            };

            var result = _shipper.Update(shipper);

            if(result.IsSuccess)
            {
                Close();
                var form = new ShipperListForm();
                form.Show();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
