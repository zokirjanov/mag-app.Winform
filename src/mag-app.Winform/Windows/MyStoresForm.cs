using mag_app.DataAccess.DbContexts;
using mag_app.Service.Services;
using mag_app.Winform.Components;

namespace mag_app.Winform.Windows
{
    public partial class MyStoresForm : Form
    {

        private AppDbContext _dbContex;
        private StoreService _service;
        public FlowLayoutPanel panel;



        public MyStoresForm(AppDbContext appDbContext)
        {
            _dbContex = appDbContext;
            _service = new StoreService(appDbContext);
            InitializeComponent();
        }

        public void MyStoresForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStoreForm form = new AddStoreForm(new AppDbContext());
            form.ShowDialog();
        }

        public void AddItem(string storename, long empCount)
        {
            var w = new storeControl(new AppDbContext())
            {
                StoreName = storename,
                EmployeeCount = empCount,
            };
            flowLayoutPanel1.Controls.Add(w);
        }

        public async void LoadData()
        {
            flowLayoutPanel1.Controls.Clear();
            var items = await _service.GetAllAsync();
            foreach (var item in items)
            {
                AddItem(item.StoreName, item.EmployeeCount);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, flowLayoutPanel1.ClientRectangle,
              Color.DimGray, 1, ButtonBorderStyle.Solid, // left
              Color.DimGray, 1, ButtonBorderStyle.Solid, // top
              Color.White, 1, ButtonBorderStyle.Solid, // right
              Color.White, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
