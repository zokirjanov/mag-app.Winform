using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.MainWindowForms;

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class List_products : Form
    {
        private ProductService _service;

        public List_products(AppDbContext appDbContext)
        {
            _service = new ProductService(appDbContext);
            InitializeComponent();
        }


        private void List_products_Load(object sender, EventArgs e)
        {
            FillData();
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            //dataGridView1.Columns[index: 7].SortMode= DataGridViewColumnSortMode.Automatic;
            //dataGridView1.Columns[index: 8].SortMode= DataGridViewColumnSortMode.Automatic;
        }



        private async void FillData()
        {
            AllProductService allProduct = new AllProductService(new AppDbContext());
            var player = await allProduct.GetAllAsync(MyStoreForm.myStoreFormParent.Id);

            foreach (var i in player)
            {
                allProductViewModeBindingSource.Add(new AllProductViewMode()
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
                    if (await res == "Успешно удалено") AutoClosingMessageBox.Show(await res, "Удалить", 300);
                    else if (await res == "Товар не найден") MessageBox.Show(await res);
                    else MessageBox.Show(await res);
                    allProductViewModeBindingSource.Clear();
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


