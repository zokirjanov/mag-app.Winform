using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
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
    public partial class ProductUpdateForm : Form
    {
        ProductService _productService;
        public ProductUpdateForm(AppDbContext appDbContext)
        {
            InitializeComponent();
            _productService = new ProductService(appDbContext);
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            oldName = productName;
            productNameTb.Text = productName;
        }

        string oldName;
        public string productName { get; set; }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            Product product  = new Product();
            product.ProdutName = productNameTb.Text;

            DialogResult dlg = MessageBox.Show("Do you want to update product?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await _productService.UpdateAsync(product, oldName);
                if (res == "true")
                {
                    this.Close();
                    StoreProductsForm.storeParent.pnl.Controls.Clear();
                    StoreProductsForm.storeParent.productBtn_Click(sender, e);
                }
                else if (res == "false")
                {
                    MessageBox.Show("Something went wrong, there is no product to match");
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
}
