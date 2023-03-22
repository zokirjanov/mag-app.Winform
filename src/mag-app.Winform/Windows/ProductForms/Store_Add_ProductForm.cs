using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.CategoryService;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace mag_app.Winform.Windows.ProductForms;

public partial class Store_Add_ProductForm : Form
{
    private readonly ProductService _service;
    public Store_Add_ProductForm(AppDbContext appDbContext)
    {
        _service = new ProductService(appDbContext);
        InitializeComponent();
    }




    private void Store_Add_ProductForm_Load(object sender, EventArgs e)
    {
        productQuantity.Minimum = 0;
        productQuantity.Maximum = 9999999999;
        barcodeLabel.Visible = false;
        barcodeTb.Visible = false;
        categorylabel.Text = CategoriesForm.categoryParent!.CategoryTitle;
        subCategoryLabel.Text = SubCategoriesForm.subCategoryParent.Title;
    }





    private void button1_Click(object sender, EventArgs e)
    {
        string barcodeResult;

        if (barcodeTb.Visible ==  true && !string.IsNullOrEmpty(barcodeTb.Text))
        {
            barcodeResult = barcodeTb.Text;
            ProductPraparing(barcodeResult);
        }
        else if(barcodeTb.Visible == false)
        {
            byte[] generatedBarcode = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(productNameTb.Text));
            var value = BitConverter.ToInt64(generatedBarcode, 0) % 100000;
            barcodeResult = value.ToString();
            barcodeTb.Text = value.ToString();
            ProductPraparing(barcodeResult);
        }
        else MessageBox.Show("Заполните поле");
    }





    private async void ProductPraparing(string barcodeResult)
    {
        if (!string.IsNullOrEmpty(productNameTb.Text) && !string.IsNullOrEmpty(productPriceTb.Text) && !string.IsNullOrEmpty(purchasePriceTb.Text))
        {
            ProductDto product = new ProductDto()
            {
                ProdutName = productNameTb.Text,
                Price = decimal.Parse(productPriceTb.Text),
                Barcode = barcodeResult,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                Quantity = Convert.ToInt32(productQuantity.Value),
                StoreId = MyStoreForm.myStoreFormParent.Id,
                SubCategoryId = SubCategoriesForm.subCategoryParent.Id,
                EmployeeId = IdentitySingelton.GetInstance().EmployeeId,
                UpdatedAt = TimeHelper.CurrentTime()
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
                    barcodeTb.Text = "";
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
        if ((e.KeyChar == '.') && ((sender as TextBox)!.Text.IndexOf('.') > -1))
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


  


    private void button2_Click(object sender, EventArgs e)
    {
    
        if (barcodeQuestion.Visible == true)
        {
            barcodeCheckbox.Image = Image.FromFile("D:\\shohrux\\mag-app\\src\\mag-app.Winform\\Resources\\Icons\\check-box.png");
            barcodeQuestion.Visible = false;
            barcodeLabel.Visible = true;
            barcodeTb.Visible= true;
        }
        else
        {
            barcodeCheckbox.Image = null;
            barcodeQuestion.Visible = true;
            barcodeLabel.Visible = false;
            barcodeTb.Visible = false;
        }
    }




    private void barcodeTb_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }
        // only allow one decimal point
        if ((e.KeyChar == '.') && ((sender as TextBox)!.Text.IndexOf('.') > -1))
        {
            e.Handled = true;
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
}
