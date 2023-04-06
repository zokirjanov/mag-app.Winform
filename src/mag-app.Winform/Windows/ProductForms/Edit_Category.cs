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

public partial class Edit_Category : Form
{
    public CategoryService categoryService;


    public Edit_Category()
    {
        categoryService = new CategoryService();
        InitializeComponent();
    }


    string oldName = "";
    public string categoryName { get; set; } = string.Empty;




    private void CategoryUpdateForm_Load(object sender, EventArgs e)
    {
        oldName = categoryName;
        categoryNameTb.Text = categoryName;
    }



    private async void updateBtn_Click(object sender, EventArgs e)
    {
        CategoryViewModel category = new CategoryViewModel();
        category.CategoryName = categoryNameTb.Text;

        DialogResult dlg = MessageBox.Show("Вы хотите изменить категорию?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        if (dlg == DialogResult.OK)
        {
            var res = await categoryService.UpdateAsync(category, oldName);
            if (res == "true")
            {
                Store_Product_Form.storeProductParent.openChildForm(new Category_Form());
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
