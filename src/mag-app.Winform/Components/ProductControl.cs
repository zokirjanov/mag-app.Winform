using mag_app.Winform.Windows.Cash_Register_Forms;

namespace mag_app.Winform.Components
{
    public partial class ProductControl : UserControl
    {
        public static ProductControl controlParent = default;
        public decimal _cost;
        public decimal _totalCost;
        public decimal _quantity;
        private bool isColorChanged;

        public ProductControl()
        {
            InitializeComponent();
            controlParent = this;
            ucTitle.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            ucQuantity.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            ucPrice.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            ucTotalPrice.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label2.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label4.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label5.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label6.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label1.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label3.Click += (sender, args) => InvokeOnClick(customPanel1, args);
        }



        private void ProductControl_Load(object sender, EventArgs e)
        {
            this.Width = Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Width - 25;
        }




        public string Title { get => ucTitle.Text; set => ucTitle.Text = value; }
        public decimal Cost { get => _cost; set { _cost = value; ucPrice.Text = _cost.ToString(@"###\ ###\ ###\ ###\"); } }
        public decimal TotalCost { get => _totalCost; set { _totalCost = value; ucTotalPrice.Text = _totalCost.ToString(@"###\ ###\ ###\ ###\"); } }
        public decimal Quantity { get => _quantity; set { _quantity = value; ucQuantity.Text = _quantity.ToString(); } }
        public string Barcode { get; set; }
        public decimal maxQ  { get; set; }





        private void button1_Click(object sender, EventArgs e)
        {
            Edit_ProductQuantity edit_ProductQuantity = new Edit_ProductQuantity();
            edit_ProductQuantity.Quantity = Quantity;
            edit_ProductQuantity.Name = Title;
            edit_ProductQuantity.Price = Cost;
            edit_ProductQuantity.Barcode = Barcode;
            edit_ProductQuantity.maxQ = maxQ;
            edit_ProductQuantity.ShowDialog();
        }




        private void customPanel1_Click(object sender, EventArgs e)
        {
            if (isColorChanged)
            {
                customPanel1.BorderColor = Color.ForestGreen;
                customPanel1.BorderSize = 1;
                isColorChanged = false;
            }
            else
            {
                customPanel1.BorderColor = Color.Tomato;
                customPanel1.BorderSize = 2;
                isColorChanged = true;
            }
        }
    }
}
