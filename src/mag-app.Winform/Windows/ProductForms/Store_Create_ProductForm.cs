using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Store_Create_ProductForm : Form
    {
        public ProductService _service;
        public Store_Create_ProductForm(AppDbContext appDbContext)
        {
            _service = new ProductService(appDbContext);
            InitializeComponent();
        }
        
        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            create_ProductFlowPanel.Controls.Clear();
            create_ProductFlowPanel.Controls.Add(primaryButton);
            primaryButton.Text = "добавить продукт";
            primaryButton.Width = 270;
            primaryButton.Height = 130;
            primaryButton.BorderRadius = 5;
            primaryButton.Click += (s, e) =>
            {
                Store_Add_ProductForm form = new Store_Add_ProductForm(new AppDbContext());
                form.ShowDialog();
            };

            var items = await _service.GetAllAsync(IdentitySingelton.GetInstance().EmployeeId);
            if (items is null)
            {
                MessageBox.Show("Stores not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item);
                }
            }
        }
        public void AddItem(Product product)
        {
            var w = new Button
            {
                Width = 270,
                Height = 130,
                BackColor = Color.LightSteelBlue,
            };

            // Labels
            var labelname = new Label()
            {
                Parent = w,
                Text = product.ProdutName,
                Font = new Font("Times New Roman", 14),
                Height = 30,
                Width= 150,
                Location = new Point(15, 15),
            };
            var labelPp = new Label()
            {
                Parent = w,
                Text = "себестоимсть:",
                Font = new Font("Times New Roman", 12),
                Location = new Point(15, 60)
            };
                var labelPprice = new Label()
                {
                    Parent = w,
                    Text = product.PurchasedPrice.ToString(),
                    Font = new Font("Times New Roman", 12),
                    Location = new Point(115, 60)
                };
            var labelP = new Label()
            {
                Parent = w,
                Text = "цена:",
                Font = new Font("Times New Roman", 12),
                Location = new Point(15, 80)
            };
                var labelPrice = new Label()
                {
                    Parent = w,
                    Text = product.Price.ToString(),
                    Font = new Font("Times New Roman", 12),
                    Location = new Point(115, 80)
                };
            var labelQ = new Label()
            {
                Parent = w,
                Text = "количество:",
                Font = new Font("Times New Roman", 12),
                Location = new Point(15, 100)
            };
                var labelQuantity = new Label()
                {
                    Parent = w,
                    Text = product.Quantity.ToString(),
                    Font = new Font("Times New Roman", 12),
                    Location = new Point(115, 100)
                };
           
            create_ProductFlowPanel.Controls.Add(w);
            w.Click += async (s, e) =>
            {
                MessageBox.Show("Button Clicked");
            };

            // Delete && Update Buttons
            var update = new Button()
            {
                Parent = w,
                Width = w.Width / 9,
                Height = w.Height / 4,
                Location = new Point(230, 10),
                BackColor = Color.LightYellow,
                Image = Image.FromFile(@"D:\shohrux\mag-app\src\mag-app.Winform\Resources\Icons\edit-button.png"),
            };
            update.Click += async (s, e) =>
            {
                UpdateForm updateForm = new UpdateForm(new AppDbContext());
                updateForm.storeName = product.ProdutName;
                updateForm.ShowDialog();
            };

            var delete = new Button()
            {
                Parent = w,
                Width = w.Width / 9,
                Height = w.Height / 4,
                Location = new Point(200, 10),
                BackColor = Color.Transparent,
                Image = Image.FromFile(@"D:\shohrux\mag-app\src\mag-app.Winform\Resources\Icons\delete.png")
            };
            delete.Click += async (s, e) =>
            {
                DialogResult dlg = MessageBox.Show("Do you want to delete store?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    var res = _service.DeleteAsync(product.ProdutName);
                    AutoClosingMessageBox.Show("Succesfully deleted", "Delete", 300);
                    StoreProductsForm.storeProductParent.openChildForm(new Store_Create_ProductForm(new AppDbContext()));
                }
                if (dlg == DialogResult.Cancel)
                {
                    //do nothing
                }
            };
        }

        private void Store_Create_ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
