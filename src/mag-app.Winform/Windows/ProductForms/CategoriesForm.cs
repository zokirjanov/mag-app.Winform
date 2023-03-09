using mag_app.DataAccess.DbContexts;
using mag_app.Service.Services.CategoryService;
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
    public partial class CategoriesForm : Form
    {
        private readonly CategoryService _service;
        public CategoriesForm(AppDbContext appDbContext)
        {
            _service = new CategoryService(appDbContext);
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public async void LoadData()
        {
            categoryFlowPanel.Controls.Clear();
            var items = await _service.GetAllAsync();
            if (items is null)
            {
                MessageBox.Show("Categories not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item.CategoryName);
                }
            }
        }

        public void AddItem(string categoryName)
        {
            var w = new Button()
            {
                Text = categoryName,
                Width = 205,
                Height = 75,
                BackColor = Color.LightYellow,
                Font = new Font("Times New Roman", 12)
            };
            categoryFlowPanel.Controls.Add(w);
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(new AppDbContext());
            addCategoryForm.ShowDialog();
        }
    }
}
