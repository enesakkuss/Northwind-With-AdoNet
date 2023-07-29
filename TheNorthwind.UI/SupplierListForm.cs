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
    public partial class SupplierListForm : Form
    {
        private SupplierService _supplier=new SupplierService();
        private Product product;
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void grdSupplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            var supplier=_supplier.GetAll();
            grdSupplierList.DataSource = supplier;
        }

        private void grdSupplierList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>0)
            {
                grdSupplierList.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuSupplierDeleteForm_Click(object sender, EventArgs e)
        {
            var supplier = (Supplier)grdSupplierList.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show($"{supplier.CompanyName} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Dikkat!!", MessageBoxButtons.YesNo);

            if(result== DialogResult.Yes)
            {
                _supplier.Delete(supplier);
                LoadData();
            }
            
        }

        public void LoadData()
        {
            var supplier = _supplier.GetAll();
            grdSupplierList.DataSource = supplier;
        }

        private void menuSupplierUpdateForm_Click(object sender, EventArgs e)
        {
            if(grdSupplierList.SelectedRows.Count>0)
            {
                var supplier = (Supplier)grdSupplierList.SelectedRows[0].DataBoundItem;

                var supplierUpdateForm = new SupplierUpdateForm(supplier.Id);
                supplierUpdateForm.MdiParent = this.MdiParent;
                supplierUpdateForm.Show();
            }
        }
    }
}
