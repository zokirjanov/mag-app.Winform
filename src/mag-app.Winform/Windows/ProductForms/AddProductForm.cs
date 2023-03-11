using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Services.CategoryService;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
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
    public partial class AddProductForm : Form
    {
  
        private readonly ProductService _service;
        public AddProductForm(AppDbContext appDbContext)
        {
            _service = new ProductService(appDbContext);
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productNameTb.Text))
            {
                ProductDto product = new ProductDto()
                {
                    ProdutName = productNameTb.Text,
                    CategoryId = SubCategoriesForm.subCategoryParent.Id,
                    EmployeeId = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateProductAsync(product);
                if (res == "true")
                {
                    MainForm.mainParent.marketbtn_Click(sender, e);
                    productNameTb.Text = "";
                    DialogResult dlg = MessageBox.Show("Product added successfully \n\nDo you want to add another one?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        productNameTb.Focus();
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Close();
                        StoreProductsForm.storeProductParent.openChildForm(new ProductManageForm());
                    }
                }
                else
                {
                    MessageBox.Show(res);
                    productNameTb.Text = "";
                }
            }
        }
    }
}
