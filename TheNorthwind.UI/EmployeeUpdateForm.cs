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
using TheNorthwind.DataAccess;

namespace TheNorthwind.UI
{
    public partial class EmployeeUpdateForm : Form
    {
        private EmployeeService _employeeService = new EmployeeService();
        private Employee employee;
        private int _employeeId;
        public EmployeeUpdateForm()
        {
            InitializeComponent();
        }
        public EmployeeUpdateForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }


        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            var employeeService = new EmployeeService();
            var reportsTo = employeeService.GetAll();
            cmbReportsTo.DataSource = reportsTo;
            cmbReportsTo.DisplayMember = "FirstName";
            cmbReportsTo.ValueMember = "Id";

            employee = _employeeService.GetById(_employeeId);
            txtLastName.Text=employee.LastName;
            txtName.Text = employee.FirstName;
            txtAdress.Text = employee.Address;
            txtTitle.Text = employee.Title;
            txtTitleOfCourtesy.Text = employee.TitleOfCourtesy;
            dtpBirthDate.Value = (DateTime)employee.BirthDate;
            dtpHireDate.Value = (DateTime)employee.HireDate;
            txtCity.Text = employee.City;
            txtCountry.Text = employee.Country;
            txtRegion.Text = employee.Region;
            txtPostalCode.Text = employee.PostalCode;
            txtHomePhone.Text = employee.HomePhone;
            txtExtension.Text = employee.Extension;
            txtNotes.Text = employee.Notes;
            cmbReportsTo.SelectedValue = (int?)employee.ReportsTo;
            txtPhotoPath.Text = employee.PhotoPath;
        }
    }
}
