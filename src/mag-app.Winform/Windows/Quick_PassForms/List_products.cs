﻿using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.MainWindowForms;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class List_products : Form
    {
        private ProductService _service;
        public static List_products listProductsParent = default!;




        public List_products(AppDbContext appDbContext)
        {
            _service = new ProductService(appDbContext);
            InitializeComponent();
            listProductsParent = this;
        }



        public string name { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;
        public string subcat { get; set; } = string.Empty;
        public string pprice { get; set; } = string.Empty;
        public string price { get; set; } = string.Empty;
        public string barcode { get; set; } = string.Empty;
        public int qquantity { get; set; }




        private void List_products_Load(object sender, EventArgs e)
        {
            FillData();
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
        }





        private async void FillData()
        {
            AllProductService allProduct = new AllProductService(new AppDbContext());
            var player = await allProduct.GetAllAsync(MyStoreForm.myStoreFormParent.Id);

            foreach (var i in player)
            {
                allProductViewModeBindingSource.Add(new AllProductViewModel()
                {
                    ProdutName = i.Products.ProdutName,
                    CategoryName = i.Products.CategoryName,
                    SubcategoryName = i.Products.SubcategoryName,
                    Barcode = i.Products.Barcode,
                    Price = i.Products.Price,
                    Quantity = i.Quantity,
                    PurchasedPrice = i.Products.PurchasedPrice,
                });
            }
        }





        private async void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var value = "test";
            var quantity_value = "-1";

            if (e.RowIndex != -1)
            {
                value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()!;
                quantity_value = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()!;
            }


            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Row_Update row = new Row_Update(new AppDbContext());
                row.ProductName = value;
                row.Quantity = int.Parse(quantity_value);
                row.ShowDialog();
            }


            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult dlg = MessageBox.Show($"Вы хотите удалить товар {value}?", "Удалить", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    var res = _service.DeleteAsync(value!);

                    if (await res) AutoClosingMessageBox.Show("Успешно удалено", "Удалить", 300);
                    else if (await res == false) MessageBox.Show("Товар не найден");
                    allProductViewModeBindingSource.Clear();
                    FillData();
                }
                if (dlg == DialogResult.Cancel)
                {
                    //do nothing
                }
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Quick_Pass quick_Pass = new Quick_Pass();
            quick_Pass.ShowDialog();
        }



        int indexRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                name = row.Cells[0].Value.ToString()!;
                category = row.Cells[1].Value.ToString()!;
                subcat = row.Cells[2].Value.ToString()!;
                pprice = row.Cells[3].Value.ToString()!;
                price = row.Cells[4].Value.ToString()!;
                qquantity = Convert.ToInt32(row.Cells[5].Value);
                barcode = row.Cells[6].Value.ToString()!;
            }
        }
    }
}


