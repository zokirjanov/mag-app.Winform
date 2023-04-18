using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Products;
using mag_app.Service.ViewModels.Stores;
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



namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Return_List : Form
    {

        SaleDetailsService _service;
        ReturnProductService _productService;
        public Return_List()
        {
            _productService = new ReturnProductService();
            _service = new SaleDetailsService();
            InitializeComponent();
        }




        private void Return_List_Load(object sender, EventArgs e)
        {
            FillData();
        }




        public async void FillData()
        {
            saleGlobalViewModelBindingSource.Clear();
            var products = await _service.GetAllAsync();

            foreach (var i in products)
            {
                saleDetailsViewModelBindingSource.Add(new SaleDetailsViewModel()
                {
                    Id = i.Id,
                    CashName = i.CashName,
                    PaymentType = (Domain.Constant.PaymentType)i.PaymentType,
                    CashAmount = i.CashAmount,
                    CardAmount = i.CardAmount,
                    TotalSale = i.TotalSalePrice,
                    Change = i.change,
                    Discount = i.DiscountPrice,
                    TransactionDate = i.TransactionDate
                });
            }
            dataGridView1.ClearSelection();
        }
    }
}
