using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class List_products : Form
    {
        private ProductService _service;

        public List_products(AppDbContext appDbContext)
        {
            _service= new ProductService(appDbContext);
            InitializeComponent();
        }



        private void List_products_Load(object sender, EventArgs e)
        {
            FillData();
        }




        private void FillData()
        {           
            DataGridViewCellStyle dataGridViewCellStyle= new DataGridViewCellStyle();
            dataGridViewCellStyle.BackColor = Color.OrangeRed;

            using (var db =  new AppDbContext())
            {
                var entity = db.Products.ToList();
                foreach (var i in entity)
                {
                    productDtoBindingSource.Add(new ProductDto() { ProdutName = i.ProdutName, CategoryName = i.CategoryName, SubcategoryName = i.SubcategoryName, Barcode = i.Barcode, Price = i.Price, PurchasedPrice = i.PurchasedPrice, Quantity = i.Quantity });
                }
            }
        }




        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Row_Update row = new Row_Update(new AppDbContext());
                row.ProductName = value!;
                row.ShowDialog();
            }


            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult dlg = MessageBox.Show($"Вы хотите удалить товар {value}?", "Удалить", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    var res = _service.DeleteAsync(value!);
                    if (await res == "Успешно удалено") AutoClosingMessageBox.Show(await res, "Удалить", 300);
                    else if (await res == "Товар не найден") MessageBox.Show(await res);
                    else MessageBox.Show(await res);
                    productDtoBindingSource.Clear();
                    FillData();
                }
                if (dlg == DialogResult.Cancel)
                {
                    //do nothing
                }
            }

        }
    }
}
