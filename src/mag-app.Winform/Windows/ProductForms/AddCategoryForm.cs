using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Services.CategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class AddCategoryForm : Form
    {
        private readonly CategoryService _service;
        public AddCategoryForm(AppDbContext appDbContext)
        {
            _service = new CategoryService(appDbContext);
            InitializeComponent();
        }

        private async void categoryAddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(categoryAddBtn.Text))
            {
                CategoryDto category = new CategoryDto()
                {
                    CategoryName = categoryNameTb.Text,
                    StoreId = storeControl.storeControlParent.Id,
                    EmployeeId = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateCategoryAsync(category);
                if (res == "true")
                {
                    MainForm.mainParent.marketbtn_Click(sender, e);
                    categoryNameTb.Text = "";
                    DialogResult dlg = MessageBox.Show("Category added successfully \n\nDo you want to add another one?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        categoryNameTb.Focus();
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Close();
                        StoreProductsForm.storeProductParent.pnl.Controls.Clear();
                        StoreProductsForm.storeProductParent.productBtn_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show(res);
                    categoryNameTb.Text = "";
                }
            }
        }
    }
}
