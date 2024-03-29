﻿using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.CategoryService;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.SubCategoryService;
using System.Security.Cryptography;
using System.Text;

namespace mag_app.Winform.Windows.Quick_PassForms;

public partial class QuickPass_AddProduct : Form
{
    private readonly ProductService _service;

    public QuickPass_AddProduct()
    {
        _service = new ProductService();
        InitializeComponent();
    }

    private void QuickPass_AddProduct_Load(object sender, EventArgs e)
    {
        barcodeLabel.Visible = false;
        barcodeTb.Visible = false;
        ComboBoxFillcategory();
    }

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
            byte[] generatedBarcode = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(productNameTb.Text));
            var res = BitConverter.ToUInt32(generatedBarcode, 0) % 100000;

            string barcode = CalculateEan13("478", "1234", res.ToString());
            barcodeResult = barcode.ToString();
            barcodeTb.Text = barcode.ToString();
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
        if (!string.IsNullOrEmpty(productNameTb.Text) && !string.IsNullOrEmpty(productPriceTb.Text) && !string.IsNullOrEmpty(purchasePriceTb.Text) && !string.IsNullOrEmpty(categoryComboBox.Text) && !string.IsNullOrEmpty(subCategoryComboBox.Text))
        {
            ProductViewModel product = new ProductViewModel()
            {
                ProdutName = productNameTb.Text,
                Price = decimal.Parse(productPriceTb.Text),
                Barcode = barcodeResult,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                CategoryName = categoryComboBox.Text,
                CategoryId = CategoryId,
                SubcategoryName = subCategoryComboBox.Text,
                SubCategoryId = SubCategoryId,
                Quantity = 0
            };

            var res = await _service.CreateProductAsync(product);

            if (res.product is not null)
            {
                List_products.listProductsParent.FillData();
                
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




    private void productNameTb_TextChanged(object sender, EventArgs e)
    {
        if (!(productNameTb.Text == ""))
        {
            productNameCheckLabel.Text = "";
        }
        else productNameCheckLabel.Text = "*";
    }




    private void barcodeCheckbox_Click(object sender, EventArgs e)
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




    public long CategoryId { get; set; }
    public long SubCategoryId { get; set; }



    /// <summary>
    /// Combo Boxes Configuration
    /// </summary>
    private async void ComboBoxFillcategory()
    {
        CategoryService categoryService = new CategoryService();
        var entity = await categoryService.GetAllAsync();
        categoryComboBox.DataSource = entity;
        categoryComboBox.DisplayMember = "CategoryName";
        categoryComboBox.ValueMember = "Id";

        Category obj = categoryComboBox.SelectedItem as Category;
        if(obj != null)
        {
            ComboBoxFillSubCategory(obj.Id);
            CategoryId = obj.Id;
        }
        else { CategoryId = 0; }
       
    }


    private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;
        Category obj = categoryComboBox.SelectedItem as Category;
        if (obj != null)
        {
            ComboBoxFillSubCategory(obj.Id);
            CategoryId = obj.Id;
        }
        Cursor.Current = Cursors.Default;

    }


    private async void ComboBoxFillSubCategory(long categoryId)
    {
        SubCategoryService subCategoryService = new SubCategoryService();
        var entity = await subCategoryService.GetAllAsync(categoryId);
        subCategoryComboBox.DataSource = entity;
        subCategoryComboBox.DisplayMember = "SubCategoryName";
        subCategoryComboBox.ValueMember = "Id";
        SubCategory obj = subCategoryComboBox.SelectedItem as SubCategory;
        if(obj != null)
        {
            SubCategoryId = obj.Id;
        }
        else
        {
            SubCategoryId = 0;
        }
    }




    /// <summary>
    /// Purchased && Price textboxes configuration
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void purchasePriceTb_KeyPress_1(object sender, KeyPressEventArgs e)
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

    private void productPriceTb_KeyPress_1(object sender, KeyPressEventArgs e)
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

    private void purchasePriceTb_TextChanged_1(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(purchasePriceTb.Text))
        {
            decimal pr = decimal.Parse(purchasePriceTb.Text);
            label9.Text = pr.ToString(@"#\ ###\ ###\ ###\");
        }

        if (!(purchasePriceTb.Text == ""))
        {
            purchasedPriceChecker.Text = "";
        }
        else
        {
            purchasedPriceChecker.Text = "*";
            label9.Text = "";
        }
    }

    private void productPriceTb_TextChanged_1(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(productPriceTb.Text))
        {
            decimal pr = decimal.Parse(productPriceTb.Text);
            label10.Text = pr.ToString(@"###\ ###\ ###\ ###\");
        }
        if (!(productPriceTb.Text == ""))
        {
            price.Text = "";
        }
        else
        {
            price.Text = "*";
            label10.Text = "";
        }
    }

    private void productNameTb_TextChanged_1(object sender, EventArgs e)
    {
        if (!(productNameTb.Text == ""))
        {
            productNameCheckLabel.Text = "";
        }
        else productNameCheckLabel.Text = "*";
    }

    private void barcodeTb_KeyPress_1(object sender, KeyPressEventArgs e)
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
