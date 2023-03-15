using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Product_Info : Form
    {
        public static Product_Info product_Info_Parent;
        private ProductService _service;
        public Product_Info(AppDbContext appDbContext)
        {
            InitializeComponent();
            _service = new ProductService(appDbContext);
        }

        public string Name { get; set; }
        public async void FillInfo(string name)
        {
            var entity = await _service.GetByNameAsync(name, IdentitySingelton.GetInstance().EmployeeId);
            foreach (var item in entity)
            {
                productNameInfo.Text = item.ProdutName;
                productPriceInfo.Text = item.Price.ToString();
                productQuantityInfo.Text = item.Quantity.ToString();
                productDescriptionInfo.Items.Add(item.Description);
            }
        }
        private void Product_Info_Load(object sender, EventArgs e)
        {
            FillInfo(Name);
        }
    }
}
