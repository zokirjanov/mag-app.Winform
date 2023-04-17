using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Return_List : Form
    {
        SaleDetailService _service;
        public Return_List()
        {
            _service= new SaleDetailService();
            InitializeComponent();
        }

        private void Return_List_Load(object sender, EventArgs e)
        {
            FillData();
        }

        public decimal Validate { get; set; } = 0;
        int indexRow;

        public async void FillData()
        {
            saleGlobalViewModelBindingSource.Clear();
            var products = await _service.GetAllAsync();

            foreach (var i in products)
            {
                saleGlobalViewModelBindingSource.Add(new SaleGlobalViewModel()
                {
                    Barcode = i.Barcode,
                    ProductName = i.ProductName,
                    Quantity = i.Quantity,
                    Price = i.Price,
                    DiscountPrice = i.DiscountPrice,
                });
            }
            dataGridView1.ClearSelection();

        }


    }
}
