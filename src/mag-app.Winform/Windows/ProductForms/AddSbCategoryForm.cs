using mag_app.DataAccess.DbContexts;
using mag_app.Service.Dtos.SubCategories;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class AddSbCategoryForm : Form
    {
        private readonly SubCategoryService _service;
        public AddSbCategoryForm(AppDbContext appDbContext)
        {
            _service = new SubCategoryService(appDbContext);
            InitializeComponent();
        }

        private async void categoryAddBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(categoryAddBtn.Text))
            {
                SubCategoryDto category = new SubCategoryDto()
                {
                    SubCategoryName = subCategoryNameTb.Text,
                    CategoryId = CategoriesForm.categoryParent.Id
                };

                var res = await _service.CreateCategoryAsync(category);
                if (res == "true")
                {
                  //MainForm.mainParent.marketbtn_Click(sender, e);
                    subCategoryNameTb.Text = "";
                    StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm(new AppDbContext()));
                    DialogResult dlg = MessageBox.Show("Sub-category added successfully \n\nDo you want to add another one?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
