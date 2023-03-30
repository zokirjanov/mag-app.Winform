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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class Row_Update : Form
    {
        AllProductService _productService;
        ProductService _product;

        public Row_Update( )
        {
            InitializeComponent();
            _productService = new AllProductService();
            _product = new ProductService();
        }

        public string oldName { get; set; } = string.Empty;
        public new string ProductName { get; set; } = string.Empty;
        public int  Quantity { get; set; }



        private void Row_Update_Load(object sender, EventArgs e)
        {
            productQuantity.Minimum = 0;
            productQuantity.Maximum = 1000000;
            oldName = ProductName;
            FillPoles(ProductName, Quantity);
        }



        public async void FillPoles(string productname, int quantity)
        {
            AllProductService allProduct = new AllProductService();
            var entity = await allProduct.GetAllAsync(MyStoreForm.myStoreFormParent.Id);

            foreach (var item in entity)
            {
                productNameTb.Text = item.ProdutName;
                purchasePriceTb.Text = item.PurchasedPrice.ToString();
                productPriceTb.Text = item.Price.ToString();
                productQuantity.Value = Convert.ToInt32(item.Quantity);
                barcodeTb.Text = item.Barcode.ToString();
            }
        }





        private async void updateBtn_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(productNameTb.Text) || string.IsNullOrEmpty(productPriceTb.Text) || string.IsNullOrEmpty(purchasePriceTb.Text))
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



        private void purchasePriceTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(purchasePriceTb.Text))
            {
                decimal pr = decimal.Parse(purchasePriceTb.Text);
                label2.Text = pr.ToString(@"#\ ###\ ###\ ###\");
            }

            if (!(purchasePriceTb.Text == ""))
            {
                purchasedPriceChecker.Text = "";
            }
            else
            {
                purchasedPriceChecker.Text = "*";
                label2.Text = "";
            }
        }



        private void productPriceTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productPriceTb.Text))
            {
                decimal pr = decimal.Parse(productPriceTb.Text);
                label7.Text = pr.ToString(@"###\ ###\ ###\ ###\");
            }
            if (!(productPriceTb.Text == ""))
            {
                price.Text = "";
            }
            else
            {
                price.Text = "*";
                label7.Text = "";
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

        private void productQuantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
