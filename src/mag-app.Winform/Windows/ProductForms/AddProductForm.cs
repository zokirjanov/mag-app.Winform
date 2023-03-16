using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.ProductService;
using System.Windows.Forms;

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
            if (!string.IsNullOrEmpty(productNameTb.Text) && !string.IsNullOrEmpty(purchasePriceTb.Text))
            {

                ProductDto product = new ProductDto()
                {
                    ProdutName = productNameTb.Text,
                    Price = decimal.Parse(productPriceTb.Text),
                    PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                    Quantity = Convert.ToInt32(productQuantity.Value),
                    Description = productDescription.Text,
                    SubCategoryId = SubCategoriesForm.subCategoryParent.Id,
                    CategoryId = CategoriesForm.categoryParent.Id,
                    EmployeeId = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateProductAsync(product);
                if (res == "true")
                {
                    ProductManageForm.produuctManageParent.LoadData();
                    DialogResult dlg = MessageBox.Show("Продукт успешно добавлен \n\nВы хотите добавить еще один", "\r\nПодтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        productNameTb.Focus();
                        productNameTb.Text = "";
                        purchasePriceTb.Text = "";
                        productQuantity.Value = 0;
                        productDescription.Text = "";
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void productPriceTb_TextChanged(object sender, EventArgs e)
        {
            if(!(purchasePriceTb.Text == ""))
            {
                productPriceChecker.Text = "";
            }
            else productPriceChecker.Text = "*";
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            productQuantity.Maximum = 100000000;
        }

        private void productPriceTb_TextChanged_1(object sender, EventArgs e)
        {
            if (!(purchasePriceTb.Text == ""))
            {
                purchasedPriceChecker.Text = "";
            }
            else purchasedPriceChecker.Text = "*";
        }

        private void productNameTb_TextChanged(object sender, EventArgs e)
        {
            if(!(productNameTb.Text == ""))
            {
                productNameCheckLabel.Text = "";
            }
            else productNameCheckLabel.Text="*";
        }
    }
}
