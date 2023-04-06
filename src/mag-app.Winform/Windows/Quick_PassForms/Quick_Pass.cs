using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace mag_app.Winform.Windows.Quick_PassForms;

public partial class Quick_Pass : Form
{
    AllProductService _productService;
    ProductService _product;


    public Quick_Pass()
    {
        _productService = new AllProductService();
        _product = new ProductService();
        InitializeComponent();
    }

    public string oldName { get; set; } = string.Empty;
    public string barcode { get; set; } = string.Empty;

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
        barcode = list_Products.barcode;
    }



    private async void updateBtn_Click(object sender, EventArgs e)
    {
        AppDbContext appDbContext = new AppDbContext();
        var result = await  appDbContext.AllProducts.FirstOrDefaultAsync(x=>x.Barcode == barcode && x.StoreId == Stores_Form.myStoreFormParent.Id);
        if (result == null)
        {
            AddProduct();
        }
        else
        {
            UpdateProduct();
        }
    }


    private async void UpdateProduct()
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



            AllProduct allProduct = new AllProduct()
            {
                StoreId = Stores_Form.myStoreFormParent.Id,
                StoreName = Stores_Form.myStoreFormParent.StoreName,
                ProdutName = labelName.Text,
                PurchasedPrice = decimal.Parse(labelPPrice.Text),
                Price = decimal.Parse(labelPrice.Text),
                Quantity = Convert.ToInt32(productQuantity.Value),
                Barcode = labelBarcode.Text,
            };


            ProductViewModel productViewModel = new ProductViewModel()
            {
                ProdutName = labelName.Text,
                Quantity = Convert.ToInt32(productQuantity.Value),
                Barcode = barcode,
            };

            DialogResult dlg = MessageBox.Show("Хотите добавить колицество?", "добавлять", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
         
            if (dlg == DialogResult.OK)
            {
                var res = await _productService.UpdateAsync(allProduct, checkname);

                if (res == "true")
                {
                    await _product.UpdateAsync(productViewModel);
                
                    AutoClosingMessageBox.Show("успешно Добавлено", "добавлять", 350);
                    Store_Product_Form.storeProductParent.openChildForm(new List_products());
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


    private async void AddProduct()
    {
        Product product = await _product.Get(barcode);


        AllProductViewModel allProduct = new AllProductViewModel()
        {
            StoreId = Stores_Form.myStoreFormParent.Id,
            Storename = Stores_Form.myStoreFormParent.StoreName,
            CategoryId = product.CategoryId,
            CategoryName= product.CategoryName,
            SubCategoryId= product.SubCategoryId,
            SubcategoryName= product.SubCategoryName,
            ProductId = product.Id,
            ProdutName = labelName.Text,
            PurchasedPrice = decimal.Parse(labelPPrice.Text),
            Price = decimal.Parse(labelPrice.Text),
            Quantity = Convert.ToInt32(productQuantity.Value),
            Barcode = barcode
        };

        ProductViewModel productViewModel = new ProductViewModel()
        {
            ProdutName = labelName.Text,
            Barcode= barcode,
            Quantity= Convert.ToInt32(productQuantity.Value),
        };



        if (string.IsNullOrEmpty(productQuantity.Text))
        {
            MessageBox.Show("заполнить все поле");
        }


        else
        {
            DialogResult dlg = MessageBox.Show("Хотите добавить колицество?", "добавлять", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {

                AllProductService allProductService = new AllProductService();
                var result = await allProductService.CreateAllProductAsync(allProduct);

                if (result != null)
                {
                    await _product.UpdateAsync(productViewModel);
                    AutoClosingMessageBox.Show("успешно Добавлено", "добавлять", 350);
                    Store_Product_Form.storeProductParent.openChildForm(new List_products());
                    this.Close();
                }
                else if (result == null)
                {
                    MessageBox.Show("Что-то пошло не так, нет подходящего продукта");
                }
                else
                {
                    MessageBox.Show("товар не найден");
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
