using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.Product_Forms;
using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class ProductUpdateForm : Form
    {
        ProductService _productService;
        public ProductUpdateForm(AppDbContext appDbContext)
        {
            InitializeComponent();
            _productService = new ProductService(appDbContext);
        }

        public string oldName { get; set; } = string.Empty;
        public new string ProductName { get; set; } = string.Empty;




        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            productQuantity.Minimum = 0;
            productQuantity.Maximum = 1000000;
            oldName = ProductName;
            FillPoles(ProductName);
        }





        public async void FillPoles(string productname)
        {
            using (var db = new AppDbContext())
            {
                var entity = await db.Products.Where(x => x.ProdutName == productname).ToListAsync();
                if (entity != null)
                {
                    foreach (var item in entity)
                    {
                        productNameTb.Text = item.ProdutName;
                        purchasePriceTb.Text = item.PurchasedPrice.ToString();
                        productPriceTb.Text = item.Price.ToString();
                        productQuantity.Value = Convert.ToInt32(item.Quantity.ToString());
                        barcodeTb.Text = item.Barcode.ToString();   
                    }
                }
            }
        }




        private async void updateBtn_Click(object sender, EventArgs e)
        {
            //string barcodeResult;
            //byte[] generatedBarcode = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(productNameTb.Text));
            //var value = BitConverter.ToInt32(generatedBarcode, 0) % 100000;
            //barcodeResult = value.ToString();

            ProductDto product = new ProductDto()
            {
                ProdutName = productNameTb.Text,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                Price = decimal.Parse(productPriceTb.Text),
                Barcode = barcodeTb.Text,
                Quantity = Convert.ToInt32(productQuantity.Value),
                UpdatedAt = TimeHelper.CurrentTime()
            };

            DialogResult dlg = MessageBox.Show("Хотите отредактировать продукт?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await _productService.UpdateAsync(product, oldName);
                if (res == "true")
                {
                    AutoClosingMessageBox.Show("успешно отредактировано", "редактировать", 350);
                    StoreProductsForm.storeProductParent.openChildForm(new Store_Create_ProductForm(new AppDbContext()));
                    this.Close();
                }
                else if (res == "false")
                {
                    MessageBox.Show("Что-то пошло не так, нет подходящего продукта");
                }
                else
                {
                    MessageBox.Show(res);
                    productNameTb.Focus();
                    productNameTb.SelectAll();
                }
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }




        private void purchasePriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox)!.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }



        private void productPriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox)!.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
