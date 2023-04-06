using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.SubCategories;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class AddSbCategoryForm : Form
    {
        private readonly SubCategoryService _service;
        public AddSbCategoryForm()
        {
            _service = new SubCategoryService();
            InitializeComponent();
        }

        private async void categoryAddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(subCategoryNameTb.Text))
            {
                SubCategoryViewModel category = new SubCategoryViewModel()
                {
                    SubCategoryName = subCategoryNameTb.Text,
                    CategoryId = Category_Form.categoryParent!.Id,
                    CategoryName = Category_Form.categoryParent.CategoryTitle,
                };

                var res = await _service.CreateCategoryAsync(category);

                if (res == "true")
                {
                    subCategoryNameTb.Text = "";
                    Store_Product_Form.storeProductParent.openChildForm(new SubCategoriesForm());
                    DialogResult dlg = MessageBox.Show("Подкатегория успешно добавлена \n\nВы хотите добавить еще один?", "\r\nПодтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        subCategoryNameTb.Focus();
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(res);
                    subCategoryNameTb.Text = "";
                }
            }
        }
    }
}
