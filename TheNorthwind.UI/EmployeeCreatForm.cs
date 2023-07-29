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
    public partial class EmployeeCreatForm : Form
    {
        private EmployeeService _employee = new EmployeeService();
        public EmployeeCreatForm()
        {
            InitializeComponent();
        }

        private void EmployeeCreatForm_Load(object sender, EventArgs e)
        {
            var employee=_employee.GetAll();
            cmbReportsTo.DataSource = employee;
            cmbReportsTo.DisplayMember ="FirstName";
            cmbReportsTo.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var employee = new Employee()
            {
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                BirthDate = dtpBirthDate.Value,
                HireDate = dtpHireDate.Value,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone = txtHomePhone.Text,
                Extension = txtExtension.Text,
                Notes = txtNotes.Text,
                ReportsTo = (int?)cmbReportsTo.SelectedValue,
                PhotoPath = txtPhotoPath.Text
            };
            var result=_employee.Creat(employee);

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
