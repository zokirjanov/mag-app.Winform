using mag_app.Service.Dtos.SubCategories;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class SubCategoryUpdateForm : Form
    {
        SubCategoryService service;
        public SubCategoryUpdateForm()
        {
            service = new SubCategoryService();
            InitializeComponent();
        }


        private void SubCategoryUpdateForm_Load(object sender, EventArgs e)
        {
            oldName = categoryName;
            subCategoryNameTb.Text = categoryName;
        }


        string oldName = "";
        public string categoryName { get; set; } = string.Empty;



        private async void updateBtn_Click(object sender, EventArgs e)
        {
            SubCategoryViewModel category = new SubCategoryViewModel();
            category.SubCategoryName = subCategoryNameTb.Text;

            DialogResult dlg = MessageBox.Show("Вы хотите изменить подкатегорию?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await service.UpdateAsync(category, oldName);
                if (res == "true")
                {
                    StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm());
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
