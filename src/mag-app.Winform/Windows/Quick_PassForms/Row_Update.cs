using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.AllProducts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class Row_Update : Form
    {
        AllProductService _productService;
        ProductService _product;

        public Row_Update(AppDbContext appDbContext)
        {
            InitializeComponent();
            _productService = new AllProductService(appDbContext);
            _product = new ProductService(appDbContext);
        }

        public string oldName { get; set; } = string.Empty;
        public new string ProductName { get; set; } = string.Empty;


        private void Row_Update_Load(object sender, EventArgs e)
        {
            productQuantity.Minimum = 0;
            productQuantity.Maximum = 1000000;
            oldName = ProductName;
            FillPoles(ProductName);
        }


        public async void FillPoles(string productname)
        {

            AllProductService allProduct = new AllProductService(new AppDbContext());
            var entity = await allProduct.GetAllAsync(MyStoreForm.myStoreFormParent.Id);

            foreach (var item in entity)
            {
                productNameTb.Text = item.Products.ProdutName;
                purchasePriceTb.Text = item.Products.PurchasedPrice.ToString();
                productPriceTb.Text = item.Products.Price.ToString();
                productQuantity.Value = Convert.ToInt32(item.Quantity);
                barcodeTb.Text = item.Products.Barcode.ToString();
            }
        }


        private async void updateBtn_Click_1(object sender, EventArgs e)
        {
           
            
            ProductDto product = new ProductDto()
            {
                ProdutName = productNameTb.Text,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                Price = decimal.Parse(productPriceTb.Text),
                Barcode = barcodeTb.Text,
                UpdatedAt = TimeHelper.CurrentTime()
            };
           
            
            long pid = await _product.GetByNameAsync(oldName);
            long allproductId = await _productService.GetById(pid, MyStoreForm.myStoreFormParent.Id);

            AllProduct allProduct = new AllProduct()
            {
                Id = allproductId,
                Quantity = Convert.ToInt32(productQuantity.Value)
            };


            DialogResult dlg = MessageBox.Show("Хотите отредактировать продукт?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res1 = await _product.UpdateAsync(product, productNameTb.Text);
                var res = await _productService.UpdateAsync(allProduct);

                if (res.message == "true" && res1 == "true")
                {
                    AutoClosingMessageBox.Show("успешно отредактировано", "редактировать", 350);
                    StoreProductsForm.storeProductParent.openChildForm(new List_products(new AppDbContext()));
                    this.Close();
                }
                else if (res.message == "false")
                {
                    MessageBox.Show("Что-то пошло не так, нет подходящего продукта");
                }
                else
                {
                    MessageBox.Show(res.message);
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
