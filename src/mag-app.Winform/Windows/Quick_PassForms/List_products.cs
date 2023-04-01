using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.MainWindowForms;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class List_products : Form
    {
        private AllProductService _service;
        private ProductService _productService;
        public static List_products listProductsParent = default!;


        public List_products( )
        {
            _service = new AllProductService();
            _productService= new ProductService();
            InitializeComponent();
            listProductsParent = this;
        }



        public string name { get; set; } = string.Empty;
        public string category { get; set; } = string.Empty;
        public string subcat { get; set; } = string.Empty;
        public decimal pprice { get; set; }
        public decimal price { get; set; } 
        public string barcode { get; set; } = string.Empty;
        public int qquantity { get; set; }




        private void List_products_Load(object sender, EventArgs e)
        {
            FillData();
         
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
        }





        public async void FillData()
        {
            allProductViewModeBindingSource.Clear();
            AllProductService allProduct = new AllProductService();
            var products = await allProduct.GetAllAsync(MyStoreForm.myStoreFormParent.Id);

            foreach (var i in products)
            {
                allProductViewModeBindingSource.Add(new AllProductViewModel()
                {
                    ProdutName = i.ProdutName,
                    CategoryName = i.CategoryName,
                    SubcategoryName = i.SubCategoryName,
                    Barcode = i.Barcode,
                    Price = i.Price,
                    Quantity = i.Quantity,
                    PurchasedPrice = i.PurchasedPrice,
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
                Row_Update row = new Row_Update();
                row.ShowDialog();
            }


            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult dlg = MessageBox.Show($"Вы хотите удалить товар {value}?", "Удалить", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    long id = await _service.GetId(value);
                    long id2 = await _productService.GetId(value);
                    var res = _service.DeleteAsync(id);
                    var res2 = _productService.DeleteAsync(id2);


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






        bool isSelected = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                Quick_Pass quick_Pass = new Quick_Pass();
                quick_Pass.ShowDialog();
            }
            else
            {
                MessageBox.Show("пожалуйста, выберите строку");
            }
        }






        int indexRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                isSelected = true;
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                name = row.Cells[3].Value.ToString()!;
                category = row.Cells[1].Value.ToString()!;
                subcat = row.Cells[2].Value.ToString()!;
                pprice = Convert.ToInt64(row.Cells[4].Value);
                price = Convert.ToInt64(row.Cells[5].Value);
                qquantity = Convert.ToInt32(row.Cells[6].Value);
                barcode = row.Cells[0].Value.ToString()!;

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            QuickPass_AddProduct quickPass_AddProduct = new QuickPass_AddProduct();
            quickPass_AddProduct.ShowDialog();
        }

        private void List_products_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}


