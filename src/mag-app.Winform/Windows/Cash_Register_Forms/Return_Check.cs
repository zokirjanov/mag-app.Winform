using mag_app.Service.Common.Helpers;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;



namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Return_Check : Form
    {

        SaleDetailsService _service;
        int indexRow = 0;


        public Return_Check()
        {
            _service = new SaleDetailsService();
            InitializeComponent();
        }




        private void Return_List_Load(object sender, EventArgs e)
        {
            FillData();
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Turquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
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





        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                Return_Product return_Product = new Return_Product();
                return_Product.Id = Convert.ToInt64(row.Cells[0].Value.ToString());
                return_Product.ShowDialog();
            }
        }
    }
}
