using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.CategoryService;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Store_Add_ProductForm : Form
    {
        private readonly ProductService _service;

        public Store_Add_ProductForm(AppDbContext appDbContext)
        {
            _service = new ProductService(appDbContext);
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productNameTb.Text) && !string.IsNullOrEmpty(productPriceTb.Text) && !string.IsNullOrEmpty(purchasePriceTb.Text))
            {
                ProductDto product = new ProductDto()
                {
                    ProdutName = productNameTb.Text,
                    Price = decimal.Parse(productPriceTb.Text),
                    PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                    Quantity = Convert.ToInt32(productQuantity.Value),
                    CategoryId = CategoriesForm.categoryParent.Id,
                    SubCategoryId = SubCategoriesForm.subCategoryParent.Id,
                    EmployeeId = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateProductAsync(product);
                if (res == "true")
                {
                    StoreProductsForm.storeProductParent.openChildForm(new Store_Create_ProductForm(new AppDbContext()));
                    DialogResult dlg = MessageBox.Show("Продукт успешно добавлен \n\nВы хотите добавить еще один", "\r\nПодтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        productNameTb.Focus();
                        productNameTb.Text = "";
                        productPriceTb.Text = "";
                        productQuantity.Value = 0;
                        purchasePriceTb.Text = "";
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
            else MessageBox.Show("Заполните поле");
        }

        private void Store_Add_ProductForm_Load(object sender, EventArgs e)
        {
            productQuantity.Minimum = 0;
            productQuantity.Maximum = 9999999999;
            categorylabel.Text = CategoriesForm.categoryParent.CategoryTitle;
            subCategoryLabel.Text = SubCategoriesForm.subCategoryParent.Title;
        }

        // UX Design Codes
        private void productPriceTb_TextChanged(object sender, EventArgs e)
        {
            if (!(productPriceTb.Text == ""))
            {
                price.Text = "";
            }
            else price.Text = "*";
        }

        private void productPriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void productNameTb_TextChanged(object sender, EventArgs e)
        {
            if (!(productNameTb.Text == ""))
            {
                productNameCheckLabel.Text = "";
            }
            else productNameCheckLabel.Text = "*";
        }

        private void purchasePriceTb_TextChanged(object sender, EventArgs e)
        {
            if (!(purchasePriceTb.Text == ""))
            {
                purchasedPriceChecker.Text = "";
            }
            else purchasedPriceChecker.Text = "*";
        }

        private void purchasePriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
