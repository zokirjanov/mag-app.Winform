using mag_app.DataAccess.DbContexts;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.MainWindowForms
{
    public partial class MyStoreForm : Form
    { 
        private AppDbContext _dbContex;
        private StoreService _service;
        public FlowLayoutPanel panel;
        public static MyStoreForm myStoreFormParent;

        public MyStoreForm(AppDbContext appDbContext)
        {
            _dbContex = appDbContext;
            _service = new StoreService(appDbContext);
            myStoreFormParent = this;
            InitializeComponent();
        }
        public long Id { get; set; }
        public string StoreName { get; set; }

        public void MyStoresForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void AddItem(string storename)
        {
            var category = new Button
            {
                Text = storename,
                Width = 200,
                Height = 80,
                BackColor = Color.LightCoral,
                Font = new Font("Times New Roman", 14),
            };
            flowLayoutPanel1.Controls.Add(category);
            category.Click += async (s, e) =>
            {
                Id = await _service.GetByName(category.Text);
                StoreName= category.Text;
                MainForm.mainParent.Hide();
                StoreProductsForm storeProductsForm = new StoreProductsForm();
                storeProductsForm.Title = StoreName;
                storeProductsForm.Show();
            };
        }

        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(primaryButton);
            primaryButton.Text = "добавить магазин";
            primaryButton.Width= 200;
            primaryButton.Height = 80;
            primaryButton.Click += (s, e) =>
            {
                AddStoreForm form = new AddStoreForm(new AppDbContext());
                form.ShowDialog();
            };

            var items = await _service.GetAllAsync();
            if (items is null)
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

        private void MyStoreForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
