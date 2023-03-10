using mag_app.DataAccess.DbContexts;
using mag_app.Service.Services.SubCategoryService;
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

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class SubCategoriesForm : Form
    {
        private SubCategoryService _service;
        public SubCategoriesForm(AppDbContext appDbContext)
        {
            _service = new SubCategoryService(appDbContext);
            InitializeComponent();
        }

        private void SubCategoriesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            subCategoryFlowPanel.Controls.Clear();
            subCategoryFlowPanel.Controls.Add(primaryButton);
            primaryButton.Text = "Добавить подкатегории";
            primaryButton.Height = 50;
            primaryButton.Width = 200;
            primaryButton.Click += (s, e) =>
            {
                //
            };
         
            var items = await _service.GetAllAsync(CategoriesForm.categoryParent.Id);
            if (items is null)
            {
                MessageBox.Show("Sub-Categories not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item.SubCategoryName);
                }
            }
        }
        public long  Id { get; set; }

        public void AddItem(string subcategoryName)
        {
            var button = new Button()
            {
                Text = subcategoryName,
                Width = 205,
                Height = 50,
                BackColor = Color.LightYellow,
                Font = new Font("Times New Roman", 14),
            };
            subCategoryFlowPanel.Controls.Add(button);
            button.Click += async (s, e) =>
            {
                Id = await _service.GetByName(button.Text);
                StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm(new AppDbContext()));
                StoreProductsForm.storeProductParent.backBtn.Hide();
            };
        }
    }
}
