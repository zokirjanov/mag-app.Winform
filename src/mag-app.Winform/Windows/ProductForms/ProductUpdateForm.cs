using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Dtos.Products;
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
            ProductDto product  = new ProductDto();
            product.ProdutName = productNameTb.Text;

            DialogResult dlg = MessageBox.Show("Хотите отредактировать продукт?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await _productService.UpdateAsync(product, oldName);
                if (res == "true")
                {
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
}
