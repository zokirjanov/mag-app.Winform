using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;



namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Return_Check : Form
    {

        SaleDetailsService _service;
        ReturnProductService _productService;
        public Return_Check()
        {
            _productService = new ReturnProductService();
            _service = new SaleDetailsService();
            InitializeComponent();
        }




        private void Return_List_Load(object sender, EventArgs e)
        {
            FillData();
        }




        public async void FillData()
        {
            saleGlobalViewModelBindingSource.Clear();
            var products = await _service.GetAllAsync();

            foreach (var i in products)
            {
                saleDetailsViewModelBindingSource.Add(new SaleDetailsViewModel()
                {
                    Id = i.Id,
                    CashName = i.CashName,
                    PaymentType = (Domain.Constant.PaymentType)i.PaymentType,
                    CashAmount = i.CashAmount,
                    CardAmount = i.CardAmount,
                    TotalSale = i.TotalSalePrice,
                    Change = i.change,
                    Discount = i.DiscountPrice,
                    TransactionDate = i.TransactionDate
                });
            }
            dataGridView1.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
