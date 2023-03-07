using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
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
        //private readonly AppDbContext _dbContex;
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
                Product product = new Product()
                {
                    ProdutName = productNameTb.Text,
                    CategoryId = 1,
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
                        MainForm.mainParent.pnl.Controls.Clear();
                        MainForm.mainParent.marketbtn_Click(sender, e);
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
