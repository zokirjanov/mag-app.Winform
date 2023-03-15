using mag_app.DataAccess.DbContexts;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Dtos.SubCategories;
using mag_app.Service.Services.CategoryService;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Windows.Product_Forms;
using Microsoft.EntityFrameworkCore.Design;
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
    public partial class SubCategoryUpdateForm : Form
    {
        SubCategoryService service;
        public SubCategoryUpdateForm(AppDbContext appDbContext)
        {
            service = new SubCategoryService(appDbContext);
            InitializeComponent();
        }
        private void SubCategoryUpdateForm_Load(object sender, EventArgs e)
        {
            oldName = categoryName;
            subCategoryNameTb.Text = categoryName;
        }
        string oldName;
        public string categoryName { get; set; }
        private async void updateBtn_Click(object sender, EventArgs e)
        {
            SubCategoryDto category = new SubCategoryDto();
            category.SubCategoryName = subCategoryNameTb.Text;

            DialogResult dlg = MessageBox.Show("Вы хотите изменить подкатегорию?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await service.UpdateAsync(category, oldName);
                if (res == "true")
                {
                    StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm(new AppDbContext()));
                    this.Close();
                }
                else if (res == "false")
                {
                    MessageBox.Show("Что-то пошло не так, нет соответствующей подкатегории");
                }
                else
                {
                    MessageBox.Show(res);
                    subCategoryNameTb.Focus();
                    subCategoryNameTb.SelectAll();
                }
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }

      
    }
}
