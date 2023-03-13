using mag_app.DataAccess.DbContexts;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.CategoryService;
using mag_app.Winform.Windows.Product_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class CategoryUpdateForm : Form
    {
        public CategoryService categoryService;
        public CategoryUpdateForm(AppDbContext appDbContext)
        {
            categoryService = new CategoryService(appDbContext);
            InitializeComponent();
        }
        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            oldName = categoryName;
            categoryNameTb.Text = categoryName;
        }

        string oldName;
        public string categoryName { get; set; }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            CategoryDto category = new CategoryDto();
            category.CategoryName = categoryNameTb.Text;

            DialogResult dlg = MessageBox.Show("Do you want to update category?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await categoryService.UpdateAsync(category, oldName);
                if (res == "true")
                {
                    StoreProductsForm.storeProductParent.openChildForm(new CategoriesForm(new AppDbContext()));
                    this.Close();
                }
                else if (res == "false")
                {
                    MessageBox.Show("Something went wrong, there is no product to match");
                }
                else
                {
                    MessageBox.Show(res);
                    categoryNameTb.Focus();
                    categoryNameTb.SelectAll();
                }
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
