using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using mag_app.Winform.Windows.MainWindowForms;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Add_TabProduct : Form
    {
        private AllProductService _service;
        private TabProductService _tabService;


        public Add_TabProduct()
        {
            _service = new AllProductService();
            _tabService = new TabProductService();
            InitializeComponent();
        }


        private void Add_TabProduct_Load(object sender, EventArgs e)
        {
            FillData();
            TabId = Cash_Register_Main.cashRegisterMainParent.TabId;
            TabName = Cash_Register_Main.cashRegisterMainParent.TabName;
        }



        public long TabId { get; set; }
        public string TabName { get; set; } = string.Empty;




        public async void FillData()
        {
            allProductViewModelBindingSource.Clear();
            var products = await _service.GetAllAsync(Stores_Form.myStoreFormParent.Id);

            foreach (var i in products)
            {
                if (i.StoreId != null)
                {
                    allProductViewModelBindingSource.Add(new AllProductViewModel()
                    {
                        ProductId = i.ProductId,
                        ProdutName = i.Product.ProdutName,
                        Storename = i.StoreName!,
                        CategoryName = i.CategoryName,
                        SubcategoryName = i.SubCategoryName,
                        Barcode = i.Barcode,
                        Price = i.Price,
                        Quantity = i.Quantity,
                        PurchasedPrice = i.PurchasedPrice,
                    });
                }
            }
            dataGridView1.ClearSelection();

            CompareList();
        }



        private async void CompareList()
        {
            var addedProducts = await _tabService.GetAllAsync(Cash_Register_Main.cashRegisterMainParent.TabId);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach(var item in addedProducts)
                {
                    if (item.ProductName == row.Cells[5].Value.ToString())
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }




        int indexRow;
        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                TabProductViewModel tabProductViewModel = new TabProductViewModel()
                {
                    ProductId = Convert.ToInt64(row.Cells[4].Value),
                    Price= Convert.ToInt64(row.Cells[7].Value),
                    ProductName = row.Cells[5].Value.ToString()!,
                    TabControllerId = TabId,
                    TabControllerName = TabName
                };

                var result = await _tabService.CreateAsync(tabProductViewModel);

                if (result == "true")
                {
                    AutoClosingMessageBox.Show("Успешно добавлен", "Удалить", 400);
                    CompareList();
                    dataGridView1.ClearSelection();
                }
                else if (result == "exists") MessageBox.Show("Уже существует");
                else if (result == "false") MessageBox.Show("Товар не найден");


            }
        }



        private void Add_TabProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cash_Register_Main.cashRegisterMainParent.TabProductsFill();
        }


        private void Add_TabProduct_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
