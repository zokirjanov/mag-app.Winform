﻿using mag_app.Domain.Entities.AllProducts;
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

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class Row_Update : Form
    {

        AllProductService _productService;
        ProductService _product;

        public Row_Update()
        {
            _productService = new AllProductService();
            _product = new ProductService();
            InitializeComponent();
        }


        public string oldName { get; set; } = string.Empty;
        public new string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }



        private void Row_Update_Load(object sender, EventArgs e)
        {
            List_products list_Products = List_products.listProductsParent;
            productNameTb.Text = list_Products.name;
            categorylabel.Text = list_Products.category;
            subCategoryLabel.Text = list_Products.subcat;
            productPriceTb.Text = list_Products.price.ToString();
            purchasePriceTb.Text = list_Products.pprice.ToString();
            barcodeTb.Text = list_Products.barcode;
            oldName = list_Products.name.ToString();
            quantityLabel.Text = list_Products.qquantity.ToString();
        }



        private async void updateBtn_Click(object sender, EventArgs e)
        {
            bool checkname = false;
            if (oldName == productNameTb.Text)
            {
                checkname = true;
            }
            else checkname = false;



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
                    Quantity = int.Parse(quantityLabel.Text),
                    Barcode = barcodeTb.Text,
                };


                AllProduct allProduct = new AllProduct()
                {
                    ProdutName = productNameTb.Text,
                    PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                    Price = decimal.Parse(productPriceTb.Text),
                    Quantity = 0,
                    Barcode = barcodeTb.Text,
                };


                DialogResult dlg = MessageBox.Show("Хотите отредактировать продукт?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    var res = await _productService.UpdateAsync(allProduct, checkname);

                    if (res == "true")
                    {
                        var res1 = await _product.UpdateAsync(product, checkname);
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
