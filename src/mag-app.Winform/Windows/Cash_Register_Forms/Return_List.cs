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

        SaleGlobalService _service;
        ReturnProductService _productService;
        public Return_List()
        {
            _productService = new ReturnProductService();
            _service = new SaleGlobalService();
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
                    
                });
            }
            dataGridView1.ClearSelection();
        }


    }
}
