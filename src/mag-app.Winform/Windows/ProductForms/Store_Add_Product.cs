﻿using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace mag_app.Winform.Windows.ProductForms;

public partial class Store_Add_Product : Form
{
    private readonly ProductService _service;

    public Store_Add_Product()
    {
        _service = new ProductService();
        InitializeComponent();
    }




    private void Store_Add_ProductForm_Load(object sender, EventArgs e)
    {
        barcodeLabel.Visible = false;
        barcodeTb.Visible = false;
        categorylabel.Text = Category_Form.categoryParent!.CategoryTitle;
        subCategoryLabel.Text = SubCategoriesForm.subCategoryParent.Title;
    }


    //
    // Add Button click
    //
    private void button1_Click(object sender, EventArgs e)
    {
        string barcodeResult;

        if (barcodeTb.Visible == true && !string.IsNullOrEmpty(barcodeTb.Text))
        {
            barcodeResult = barcodeTb.Text;
            ProductPraparing(barcodeResult);
        }
        else if (barcodeTb.Visible == false)
        {
            string countryManufacturerCode = "869";
            string manufacturerCode = "12345";
            string productName = productNameTb.Text;
            string concatenatedString = countryManufacturerCode + manufacturerCode + productName;
            byte[] generatedBarcode = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(concatenatedString));
            var res = BitConverter.ToUInt32(generatedBarcode, 0) % 100000;
            string barcode = CalculateEan13(countryManufacturerCode, manufacturerCode, res.ToString());
            barcodeResult = barcode;
            barcodeTb.Text = barcode;
            ProductPraparing(barcode);
        }
        else MessageBox.Show("Заполните поле");
    }




    //
    // Ean 13 barcode Generator
    //
    public static string CalculateEan13(string country, string manufacturer, string product)
    {
        string temp = $"{country}{manufacturer}{product}";
        int sum = 0;
        int digit = 0;

        for (int i = temp.Length; i >= 1; i--)
        {
            digit = Convert.ToInt32(temp.Substring(i - 1, 1));

            if (i % 2 == 0)
            {
                sum += digit * 3;
            }
            else
            {
                sum += digit * 1;
            }
        }
        int checkSum = (10 - (sum % 10)) % 10;
        return $"{temp}{checkSum}";
    }





    private async void ProductPraparing(string barcodeResult)
    {
        if (!string.IsNullOrEmpty(productNameTb.Text) && !string.IsNullOrEmpty(productPriceTb.Text) && !string.IsNullOrEmpty(purchasePriceTb.Text))
        {
            ProductViewModel product = new ProductViewModel()
            {
                ProdutName = productNameTb.Text,
                Price = decimal.Parse(productPriceTb.Text),
                Barcode = barcodeResult,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                CategoryName = Category_Form.categoryParent.CategoryTitle,
                CategoryId = Category_Form.categoryParent.Id,
                SubcategoryName = SubCategoriesForm.subCategoryParent.Title,
                SubCategoryId = SubCategoriesForm.subCategoryParent.Id,
                Quantity = 0
            };

            var res = await _service.CreateProductAsync(product);


            if (res.product is not null)
            {
                Store_Product_Form.storeProductParent.openChildForm(new Store_List_Product());
                DialogResult dlg = MessageBox.Show("Продукт успешно добавлен \n\nВы хотите добавить еще один", "\r\nПодтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    productNameTb.Focus();
                    productNameTb.Text = "";
                    productPriceTb.Text = "";
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
                MessageBox.Show(res.message);
                productNameTb.Text = "";
            }
        }
        else MessageBox.Show("Заполните поле");
    }





    // UX Design Codes
    private void productPriceTb_TextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(productPriceTb.Text))
        {
            decimal pr = decimal.Parse(productPriceTb.Text);
            label1.Text = pr.ToString(@"###\ ###\ ###\ ###\");
        }
        if (!(productPriceTb.Text == ""))
        {
            price.Text = "";
        }
        else
        {
            price.Text = "*";
            label1.Text = "";
        } 
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





    private void button2_Click(object sender, EventArgs e)
    {

        if (barcodeQuestion.Visible == true)
        {
            barcodeCheckbox.Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/check-box.png");
            barcodeQuestion.Visible = false;
            barcodeLabel.Visible = true;
            barcodeTb.Visible = true;
        }
        else
        {
            barcodeCheckbox.Image = null;
            barcodeQuestion.Visible = true;
            barcodeLabel.Visible = false;
            barcodeTb.Visible = false;
            barcodeTb.Text = " ";
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

    private void label2_Click(object sender, EventArgs e)
    {

    }
}
