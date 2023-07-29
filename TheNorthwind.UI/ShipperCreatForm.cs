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
    public partial class ShipperCreatForm : Form
    {
        private ShipperService _shipper = new ShipperService();
        public ShipperCreatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var shipper = new Shipper()
            {
                CompanyName = txtCompanyName.Text,
                Phone=txtPhone.Text
            };

            var result=_shipper.Creat(shipper);
            
            foreach (var mdiChild in MdiParent.MdiChildren)
            {
                if (mdiChild is ShipperListForm)
                {
                    var form = (ShipperListForm)mdiChild;
                    form.LoadData();
                }
            }

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
