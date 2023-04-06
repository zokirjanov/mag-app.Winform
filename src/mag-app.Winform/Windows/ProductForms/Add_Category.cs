using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Categories;
using mag_app.Service.Services.CategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Add_Category : Form
    {
        private readonly CategoryService _service;
        public Add_Category()
        {
            _service = new CategoryService();
            InitializeComponent();
        }

        private async void categoryAddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(categoryNameTb.Text))
            {
                CategoryViewModel category = new CategoryViewModel()
                {
                    CategoryName = categoryNameTb.Text,
                };

                var res = await _service.CreateCategoryAsync(category);
                if (res == "true")
                {
                    categoryNameTb.Text = "";
                    Store_Product_Form.storeProductParent.openChildForm(new Category_Form());
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
