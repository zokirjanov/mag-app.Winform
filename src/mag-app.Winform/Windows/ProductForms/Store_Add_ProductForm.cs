using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.SubCategories;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Interfaces.Categories;
using mag_app.Service.Services.CategoryService;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.SubCategoryService;
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

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Store_Add_ProductForm : Form
    {
        private readonly ProductService _service;
        public long SubCategoryId { get; set; }
        public long CategoryId { get; set; }

        public Store_Add_ProductForm(AppDbContext appDbContext)
        {
            _service  = new ProductService(appDbContext);
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productNameTb.Text) && !string.IsNullOrEmpty(productPriceTb.Text) && !string.IsNullOrEmpty(purchasePriceTb.Text)
                && !string.IsNullOrEmpty(categoryComboBox.Text) && !string.IsNullOrEmpty(subCategoryComboBox.Text))
            {

                ProductDto product = new ProductDto()
                {
                    ProdutName = productNameTb.Text,
                    Price = double.Parse(productPriceTb.Text),
                    PurchasedPrice= double.Parse(purchasePriceTb.Text),
                    Quantity = productQuantity.Value,
                    Description = productDescription.Text,
                    CategoryId = CategoryId,
                    SubCategoryId = SubCategoryId,
                    EmployeeId = IdentitySingelton.GetInstance().EmployeeId
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
                        productDescription.Text = "";
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

        private void Store_Add_ProductForm_Load(object sender, EventArgs e)
        {
            productQuantity.Maximum = 100000000;
            ComboBoxFillcategory();
        }


        // Combo box filling
        private async void ComboBoxFillSubCategory(long categoryId)
        {
            SubCategoryService subCategoryService = new SubCategoryService(new AppDbContext());
            var entity = await subCategoryService.GetAllAsync(categoryId);
            subCategoryComboBox.DataSource = entity;
            subCategoryComboBox.ValueMember = "SubCategoryName";
        }
        private async void ComboBoxFillcategory()
        {
            CategoryService categoryService = new CategoryService(new AppDbContext());
            var entity = await categoryService.GetAllAsync(MyStoreForm.myStoreFormParent.Id);
            categoryComboBox.DataSource = entity;
            categoryComboBox.ValueMember = "CategoryName";

            var select = categoryComboBox.SelectedValue;
            long id = await categoryService.GetByNameAsync(select.ToString());
            ComboBoxFillSubCategory(id);
        }
        private async void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService(new AppDbContext());
            var select = categoryComboBox.SelectedValue;
            long id = await categoryService.GetByNameAsync(select.ToString());
            CategoryId = id;
            ComboBoxFillSubCategory(id);
        }
        private async void subCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoryService subCategoryService = new SubCategoryService(new AppDbContext());
            var select = subCategoryComboBox.SelectedValue;
            long id = await subCategoryService.GetByNameAsync(select.ToString());
            SubCategoryId = id;
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
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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

        private void purchasePriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


    }
}
