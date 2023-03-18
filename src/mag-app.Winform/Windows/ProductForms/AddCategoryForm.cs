using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Services.CategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
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
                    StoreId = MyStoreForm.myStoreFormParent.Id,
                    EmployeeId = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateCategoryAsync(category);
                if (res == "true")
                {
                    categoryNameTb.Text = "";
                    StoreProductsForm.storeProductParent.openChildForm(new CategoriesForm(new AppDbContext()));
                    DialogResult dlg = MessageBox.Show("Категория успешно добавлена \n\nВы хотите добавить еще один", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        categoryNameTb.Focus();
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Close();
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
