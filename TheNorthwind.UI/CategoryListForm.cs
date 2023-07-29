using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.Business;

namespace TheNorthwind.UI
{
    public partial class CategoryListForm : Form
    {
        private CategoryService _categoryService=new CategoryService();
        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            //var categoryService = new CategoryService();
            var categories = _categoryService.GetAll();
            grdCategories.DataSource = categories;
            // data bind
        }

        private void grdCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdCategories_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                grdCategories.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuUpdateCategory_Click(object sender, EventArgs e)
        {
            if(grdCategories.SelectedRows.Count > 0)
            {
                var category=(Category) grdCategories.SelectedRows[0].DataBoundItem;


                // Test Amaçlı ıd Değerine bakıyoruz
                // MessageBox.Show(category.Id.ToString());

                var categoryUpdateForm= new CategoryUpdateForm(category.Id);
                categoryUpdateForm.MdiParent = this.MdiParent;
                categoryUpdateForm.Show(); // Load eventini tetikler
            }
        }

        private void menuDeleteCategory_Click(object sender, EventArgs e)
        {
            var category = (Category)grdCategories.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show($"{category.Name} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Dikkat!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                grdCategories.DataSource = _categoryService.Delete(category);
                foreach(var mdiChild in MdiParent.MdiChildren)
                {
                    if(mdiChild is CategoryListForm)
                    {
                        var form = new CategoryListForm();
                        form.LoadData();
                    }
                }
            }
            
        }

        public void LoadData()
        {
            var categories=_categoryService.GetAll();
            grdCategories.DataSource = categories;
        }
    }
}
