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
    public partial class Return_Product : Form
    {
        SaleGlobalService _service;

        public Return_Product()
        {
            _service = new SaleGlobalService();
            InitializeComponent();
        }




        private void Return_Product_Load(object sender, EventArgs e)
        {
            FillData();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Turquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

        }


        public long Id { get; set; }


        public async void FillData()
        {
            saleGlobalViewModelBindingSource.Clear();
            var products = await _service.GetAllAsync(Id);

            foreach (var i in products)
            {
                saleGlobalViewModelBindingSource.Add(new SaleGlobalViewModel()
                {
                    Barcode= i.Barcode,
                    Category= i.Category,
                    SubCategory= i.SubCategory,
                    ProductName= i.ProductName,
                    Quantity= i.Quantity,
                    Price= i.Price,
                    DiscountPrice= i.DiscountPrice,
                });
            }
            dataGridView1.ClearSelection();
        }

    }
}
