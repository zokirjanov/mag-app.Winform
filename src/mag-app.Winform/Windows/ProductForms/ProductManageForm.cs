using mag_app.DataAccess.DbContexts;
using mag_app.Service.Interfaces.Products;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class ProductManageForm : Form
    {
        private ProductService _ProductService;
        public ProductManageForm()
        {
            _ProductService = new ProductService(new AppDbContext());
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(new AppDbContext());
            addProductForm.ShowDialog();
        }

        private void ProductManageForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void AddItem(string productName)
        {
            var w = new productControl(new AppDbContext())
            {
                ProductName = productName
            };
            producFlowPanel.Controls.Add(w);
        }

        public async void LoadData()
        {
            producFlowPanel.Controls.Clear();
            var items = await _ProductService.GetAllAsync();
            if (items is null)
            {
                MessageBox.Show("Stores not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item.ProdutName);
                }
            }
        }
        private void producFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, producFlowPanel.ClientRectangle,
             Color.DimGray, 1, ButtonBorderStyle.Solid, // left
             Color.DimGray, 1, ButtonBorderStyle.Solid, // top
             Color.White, 1, ButtonBorderStyle.Solid, // right
             Color.White, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
