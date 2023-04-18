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



        public SaleGlobalViewModel model = new SaleGlobalViewModel();
        public decimal Validate { get; set; } = 0;
        public decimal price { get; set; }

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
                    Id = i.Id
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

                costTb.Text = "";
                nameTb.Text = row.Cells[0].Value.ToString();
                Validate = decimal.Parse(row.Cells[3].Value.ToString()!);
                price = decimal.Parse(row.Cells[1].Value.ToString()!);
                quantityTb.Text = row.Cells[3].Value.ToString();

                model.ProductName = row.Cells[0].Value.ToString();
                model.Price = decimal.Parse(row.Cells[1].Value.ToString());
                model.DiscountPrice = decimal.Parse(row.Cells[2].Value.ToString());
                model.Barcode = row.Cells[4].Value.ToString();
                model.Quantity = decimal.Parse(row.Cells[3].Value.ToString());
                model.Id = long.Parse(row.Cells[5].Value.ToString());
            }
        }









        private void quantityTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(quantityTb.Text))
            {
                decimal validate = decimal.Parse(quantityTb.Text);

                if (validate <= Validate)
                {

                    decimal p = price / Validate * validate;
                    quantityTb.ForeColor = Color.Black;
                    costTb.Text = p.ToString(@"###\ ###\ ###\ ###\");

                }
                else
                {

                    MessageBox.Show("Сумма увеличилась");
                    quantityTb.ForeColor = Color.Red;

                }
            }
            else
            {
                quantityTb.ForeColor = Color.Black;
                costTb.Text = "";
            }
        }








        private void quantityTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox)!.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }









        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTb.Text) || string.IsNullOrEmpty(quantityTb.Text) || string.IsNullOrEmpty(costTb.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }

            if (!decimal.TryParse(quantityTb.Text, out decimal returnQuantity))
            {
                MessageBox.Show("Неверный формат количества");
                return;
            }

            if (!decimal.TryParse(costTb.Text, out decimal returnedPrice))
            {
                MessageBox.Show("Неверный формат стоимости");
                return;
            }


            ReturnProductViewModel product = new ReturnProductViewModel()
            {
                SgName = model.ProductName,
                SaleGlobalId = model.ProductId,
                Barcode = model.Barcode,
                ReturnedPrice = returnedPrice,
                Return = returnQuantity,
            };

            DialogResult dialogResult = MessageBox.Show("Хотите возврат товара?", "Возврат", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    var result = await _productService.CreateProductAsync(product);

                    if (result != null)
                    {
                        MessageBox.Show("Товар успешно возвращен");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при возврате товара: {ex.Message}");
                }
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
