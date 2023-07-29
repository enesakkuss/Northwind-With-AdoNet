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
    public partial class EmployeeListForm : Form
    {
        private EmployeeService _employee = new EmployeeService();
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            var employee = _employee.GetAll();
            grdEmployeeListForm.DataSource = employee;
        }

        private void grdEmployeeListForm_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex>=1)
            {
                grdEmployeeListForm.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuUpdateEmployeeForm_Click(object sender, EventArgs e)
        {
            if (grdEmployeeListForm.SelectedRows.Count>0)
            {
                var employee = (Employee)grdEmployeeListForm.SelectedRows[0].DataBoundItem;

                var employeeUpdateForm=new EmployeeUpdateForm(employee.ID);
                employeeUpdateForm.MdiParent = this.MdiParent;
                employeeUpdateForm.Show();
            }
        }

        private void menuDeleteUpdateForm_Click(object sender, EventArgs e)
        {
            var employee= (Employee)grdEmployeeListForm.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show($"{employee.FirstName} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Dikkat!!", MessageBoxButtons.YesNo);

            if(result==DialogResult.Yes)
            {
                grdEmployeeListForm.DataSource = _employee.Delete(employee);
            }
            grdEmployeeListForm.DataSource = _employee.GetAll();
        }
    }
}
