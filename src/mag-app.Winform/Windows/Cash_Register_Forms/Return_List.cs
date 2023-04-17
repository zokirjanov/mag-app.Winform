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
                Validate = decimal.Parse(row.Cells[3].Value.ToString());
                price = decimal.Parse(row.Cells[1].Value.ToString());
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

                    decimal p = price / Validate * validate;
                    costTb.Text = p.ToString(@"###\ ###\ ###\ ###\");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string filterText = textBox1.Text.ToLower();
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string cellText = row.Cells[0].Value.ToString().ToLower();
                row.Visible = cellText.Contains(filterText);
            }

            //string filterText = textBox1.Text.ToLower();
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    string rowText = string.Empty;
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        rowText += cell.Value.ToString().ToLower() + " ";
            //    }
            //    if (rowText.Contains(filterText))
            //    {
            //        row.Visible = true;
            //    }
            //    else
            //    {
            //        row.Visible = false;
            //    }
            //}
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter || textBox1.Text.Trim().Length == 0)
            //{
            //    string filterText = textBox1.Text.ToLower();
            //    dataGridView1.ClearSelection();
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        string cellText = row.Cells[0].Value.ToString().ToLower();
            //        if(row.Visible == true)
            //        {
            //            row.Visible = cellText.Contains(filterText);
            //        }
            //    }
            //}
        }
    }
}
