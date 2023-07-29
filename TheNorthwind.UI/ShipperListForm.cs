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
    public partial class ShipperListForm : Form
    {
        private ShipperService _shipper=new ShipperService();
        public ShipperListForm()
        {
            InitializeComponent();
        }

        private void grdShipperListForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShipperListForm_Load(object sender, EventArgs e)
        {
            var shippers = _shipper.GetAll();
            grdShipperListForm.DataSource = shippers;
        }

        public void LoadData()
        {
            var shippers= _shipper.GetAll();
            grdShipperListForm.DataSource= shippers;
        }

        private void grdShipperListForm_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grdShipperListForm.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuShipperUpdateForm_Click(object sender, EventArgs e)
        {
            if(grdShipperListForm.SelectedRows.Count>0)
            {
                var shipper = (Shipper)grdShipperListForm.SelectedRows[0].DataBoundItem;

                var shipperUpdateForm = new ShipperUpdateForm(shipper.Id);
                shipperUpdateForm.MdiParent = this.MdiParent;
                shipperUpdateForm.Show();
            }
        }

        private void menuShipperDeleteForm_Click(object sender, EventArgs e)
        {
            var shipper = (Shipper)grdShipperListForm.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show($"{shipper.CompanyName} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Dikkat!!", MessageBoxButtons.YesNo);

            if(result==DialogResult.Yes)
            {
                grdShipperListForm.DataSource = _shipper.Delete(shipper);
                foreach (var mdiChild in MdiParent.MdiChildren)
                {
                    if (mdiChild is ShipperListForm)
                    {
                        var form = new ShipperListForm();
                        form.LoadData();
                    }
                }
            }
        }
        
    }
}
