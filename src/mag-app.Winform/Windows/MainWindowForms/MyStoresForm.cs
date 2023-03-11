using mag_app.DataAccess.DbContexts;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using System.Security.Cryptography.X509Certificates;

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

        public void AddItem(string storename)
        {
  
            var w = new storeControl(new AppDbContext())
            {
                StoreName = storename
            };
            flowLayoutPanel1.Controls.Add(w);
        }

        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(primaryButton);
            primaryButton.Text = "добавить магазин";
            primaryButton.Click += (s, e) => 
            {
                AddStoreForm form = new AddStoreForm(new AppDbContext());
                form.ShowDialog();
            };

            var items = await _service.GetAllAsync();
            if(items is null)
            {
                MessageBox.Show("Stores not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item.StoreName);
                }
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
