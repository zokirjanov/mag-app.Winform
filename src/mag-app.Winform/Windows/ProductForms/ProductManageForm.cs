using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Interfaces.Products;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class ProductManageForm : Form
    {
        private ProductService _ProductService;
        public static ProductManageForm produuctManageParent;
        public ProductManageForm()
        {
            _ProductService = new ProductService(new AppDbContext());
            InitializeComponent();
            produuctManageParent = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(new AppDbContext());
            addProductForm.ShowDialog();
        }

        private void ProductManageForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void AddItem(string productName)
        {
            var w = new productControl(new AppDbContext())
            {
                ProductName = productName
            };
            producFlowPanel.Controls.Add(w);
        }

        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            producFlowPanel.Controls.Clear();
            producFlowPanel.Controls.Add(primaryButton);
            primaryButton.Text = "Добавить продукт";
            primaryButton.Click += (s, e) =>
            {
                AddProductForm addProductForm = new AddProductForm(new AppDbContext());
                addProductForm.ShowDialog();
            };
            var items = await _ProductService.GetAllAsync(SubCategoriesForm.subCategoryParent.Id, IdentitySingelton.GetInstance().EmployeeId);
            if (items is null)
            {
                MessageBox.Show("stores not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item.ProdutName);
                }
            }
        }
        private void producFlowPanel_Paint(object sender, PaintEventArgs e)
        {
             ControlPaint.DrawBorder(e.Graphics, producFlowPanel.ClientRectangle,
             Color.DimGray, 1, ButtonBorderStyle.Solid, // left
             Color.DimGray, 1, ButtonBorderStyle.Solid, // top
             Color.White, 1, ButtonBorderStyle.Solid, // right
             Color.White, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm(new AppDbContext()));
            StoreProductsForm.storeProductParent.titleLabel.Text = CategoriesForm.categoryParent.CategoryTitle;
            StoreProductsForm.storeProductParent.backBtn.Show();
        }
    }
}
