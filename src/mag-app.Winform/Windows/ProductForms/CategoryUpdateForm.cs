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

namespace mag_app.Winform.Windows.ProductForms;

public partial class CategoryUpdateForm : Form
{
    public CategoryService categoryService;
    public CategoryUpdateForm(AppDbContext appDbContext)
    {
        categoryService = new CategoryService(appDbContext);
        InitializeComponent();
    }
    string oldName;
    public string categoryName { get; set; }




    private void CategoryUpdateForm_Load(object sender, EventArgs e)
    {
        oldName = categoryName;
        categoryNameTb.Text = categoryName;
    }



    private async void updateBtn_Click(object sender, EventArgs e)
    {
        CategoryDto category = new CategoryDto();
        category.CategoryName = categoryNameTb.Text;

        DialogResult dlg = MessageBox.Show("Вы хотите изменить категорию?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                MessageBox.Show("Что-то пошло не так, нет соответствующей категории");
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
