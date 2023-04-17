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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                decimal p = Convert.ToDecimal(row.Cells[1].Value.ToString());

                nameTb.Text = row.Cells[0].Value.ToString();
                costTb.Text = p.ToString(@"###\ ###\ ###\ ###\");
                Validate = decimal.Parse(row.Cells[3].Value.ToString());
            }
        }

        private void quantityTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(quantityTb.Text))
            {
                decimal validate = decimal.Parse(quantityTb.Text);

                if (validate > Validate)
                {
                    MessageBox.Show("Сумма увеличилась");
                    quantityTb.ForeColor = Color.Red;
                }
                else
                {
                    quantityTb.ForeColor = Color.Black;
                }
            }
        }
    }
}
