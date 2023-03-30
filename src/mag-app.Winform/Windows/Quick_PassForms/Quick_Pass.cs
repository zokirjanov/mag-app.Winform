using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Quick_PassForms;

public partial class Quick_Pass : Form
{
    AllProductService _productService;
    ProductService _product;


    public Quick_Pass()
    {
        InitializeComponent();
    }

    public string oldName { get; set; } = string.Empty;
    public new string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }



    private void Quick_Pass_Load(object sender, EventArgs e)
    {
        productQuantity.Minimum = 0;
        productQuantity.Maximum = 1000000;
        oldName = ProductName;

        List_products list_Products = List_products.listProductsParent;
        productNameTb.Text = list_Products.name;
        productPriceTb.Text = list_Products.price;
        purchasePriceTb.Text = list_Products.pprice;
        barcodeTb.Text = list_Products.barcode;
        productQuantity.Value = list_Products.qquantity;
    }



    private async void updateBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(productNameTb.Text) || string.IsNullOrEmpty(productPriceTb.Text) || string.IsNullOrEmpty(purchasePriceTb.Text))
        {
            MessageBox.Show("заполнить все поле");
        }
        else
        {
            ProductViewModel product = new ProductViewModel()
            {
                ProdutName = productNameTb.Text,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                Price = decimal.Parse(productPriceTb.Text),
                Barcode = barcodeTb.Text,
                Quantity = Convert.ToInt32(productQuantity.Value)
            };



            AllProduct allProduct = new AllProduct()
            {
                StoreId = MyStoreForm.myStoreFormParent.Id,
                ProdutName = productNameTb.Text,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                Price = decimal.Parse(productPriceTb.Text),
                Barcode = barcodeTb.Text,
                Quantity = Convert.ToInt32(productQuantity.Value)
            };


            DialogResult dlg = MessageBox.Show("Хотите отредактировать продукт?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {

                var res = await _productService.UpdateAsync(allProduct);

                if (res == "true")
                {
                    var res1 = await _product.UpdateAsync(product);
                    AutoClosingMessageBox.Show("успешно отредактировано", "редактировать", 350);
                    StoreProductsForm.storeProductParent.openChildForm(new List_products());
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
    }
}
