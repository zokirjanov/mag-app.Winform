using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.ProductService;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class AddProductForm : Form
    {

        private readonly ProductService _service;
        public AddProductForm(AppDbContext appDbContext)
        {
            _service = new ProductService(appDbContext);
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productNameTb.Text))
            {
                ProductDto product = new ProductDto()
                {
                    ProdutName = productNameTb.Text,
                    CategoryId = SubCategoriesForm.subCategoryParent.Id,
                    EmployeeId = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateProductAsync(product);
                if (res == "true")
                {
                    productNameTb.Text = "";
                    ProductManageForm.produuctManageParent.LoadData();
                    DialogResult dlg = MessageBox.Show("Product added successfully \n\nDo you want to add another one?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        productNameTb.Focus();
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(res);
                    productNameTb.Text = "";
                }
            }
        }
    }
}
