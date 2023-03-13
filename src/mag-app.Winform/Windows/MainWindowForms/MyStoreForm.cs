using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
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
            var w = new Button
            {
                Text = storename,
                Width = 200,
                Height = 80,
                BackColor = Color.LightSteelBlue,
                Font = new Font("Times New Roman", 14),
            };
            flowLayoutPanel1.Controls.Add(w);
            w.Click += async (s, e) =>
            {
                Id = await _service.GetByName(w.Text);
                StoreName= w.Text;
                MainForm.mainParent.Hide();
                StoreProductsForm storeProductsForm = new StoreProductsForm();
                storeProductsForm.Title = StoreName;
                storeProductsForm.Show();
            };

            var update = new Button()
            {
                Parent = w,
                Width = w.Width / 8,
                Height = w.Height / 3,
                Location = new Point(170, 10),
                BackColor = Color.LightYellow,
                Image = Image.FromFile(@"D:\shohrux\mag-app\src\mag-app.Winform\Resources\Icons\edit-button.png"),
            };
            update.Click += async (s, e) =>
            {
                UpdateForm updateForm = new UpdateForm(new AppDbContext());
                updateForm.storeName = storename;
                updateForm.ShowDialog();
            };

            var delete = new Button()
            {
                Parent = w,
                Width = w.Width / 8,
                Height = w.Height / 3,
                Location = new Point(170, 40),
                BackColor = Color.Transparent,
                Image = Image.FromFile(@"D:\shohrux\mag-app\src\mag-app.Winform\Resources\Icons\delete.png")
            };
            delete.Click += async (s, e) =>
            {
                DialogResult dlg = MessageBox.Show("Do you want to delete store?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    var res = _service.DeleteAsync(storename);
                    AutoClosingMessageBox.Show("Succesfully deleted", "Delete", 300);
                    MainForm.mainParent.pnl.Controls.Clear();
                    MainForm.mainParent.marketbtn_Click(s, e);
                }
                if (dlg == DialogResult.Cancel)
                {
                    this.Hide();
                }
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
            primaryButton.BorderRadius = 5;
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
