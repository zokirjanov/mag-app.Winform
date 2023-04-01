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
        _productService = new AllProductService();
        _product= new ProductService();
        InitializeComponent();
    }

    public string oldName { get; set; } = string.Empty;

    private void Quick_Pass_Load(object sender, EventArgs e)
    {
        productQuantity.Minimum = 0;
        productQuantity.Maximum = 1000000;


        List_products list_Products = List_products.listProductsParent;
        labelName.Text = list_Products.name;
        categorylabel.Text = list_Products.category;
        subCategoryLabel.Text = list_Products.subcat;
        labelPrice.Text = list_Products.price.ToString(@"#\ ###\ ###\ ###\");
        labelPPrice.Text = list_Products.pprice.ToString(@"#\ ###\ ###\ ###\");
        labelBarcode.Text = list_Products.barcode;
        quantityLabel.Text = list_Products.qquantity.ToString();
        oldName = list_Products.name.ToString();
    }
    


    private async void updateBtn_Click(object sender, EventArgs e)
    {
        bool checkname = false;
        if (oldName == labelName.Text)
        {
            checkname = true;
        }
        else checkname = false;



        if (string.IsNullOrEmpty(productQuantity.Text))
        {
            MessageBox.Show("заполнить все поле");
        }
        else
        {
            ProductViewModel product = new ProductViewModel()
            {
                ProdutName = labelName.Text,
                PurchasedPrice = decimal.Parse(labelPPrice.Text),
                Price = decimal.Parse(labelPrice.Text),
                Quantity = Convert.ToInt32(productQuantity.Value),
                Barcode = labelBarcode.Text,
            };


            AllProduct allProduct = new AllProduct()
            {
                StoreId = MyStoreForm.myStoreFormParent.Id,
                StoreName = MyStoreForm.myStoreFormParent.StoreName,
                ProdutName = labelName.Text,
                PurchasedPrice = decimal.Parse(labelPPrice.Text),
                Price = decimal.Parse(labelPrice.Text),
                Quantity = Convert.ToInt32(productQuantity.Value),
                Barcode= labelBarcode.Text,
            };


            DialogResult dlg = MessageBox.Show("Хотите добавить колицество?", "добавлять", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await _productService.UpdateAsync(allProduct, checkname);

                if (res == "true")
                {
                    var res1 = await _product.UpdateAsync(product, checkname);
                    AutoClosingMessageBox.Show("успешно Добавлено", "добавлять", 350);
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
                    productQuantity.Focus();
                    productQuantity.Select();
                }
            }

            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
