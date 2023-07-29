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
using System.Data.SqlClient;

namespace TheNorthwind.UI
{
    public partial class CategoryUpdateForm : Form
    {
        private CategoryService _categoryService=new CategoryService();
        private int _categoryId;
        private Category category;
        public CategoryUpdateForm(int categoryId)
        {
            InitializeComponent();

            _categoryId = categoryId;
        }

        // public void SetCategoryId(int categoryId)
        //{
        //      _categoryId=category.Id
        //}

        public CategoryUpdateForm()
        {
            InitializeComponent();
        }

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            category = _categoryService.GetById(_categoryId);
            txtName.Text = category.Name;
            txtDescription.Text = category.Description;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            category = new Category()
            {
                Id= _categoryId,
                Name = txtName.Text,
                Description = txtDescription.Text
            };
            
            var result = _categoryService.Update(category);


            if(result.IsSuccess)
            {
                Close();
                var form = new CategoryListForm();
                form.Show();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        
        }
    }
}
