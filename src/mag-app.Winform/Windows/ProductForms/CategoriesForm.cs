using mag_app.DataAccess.DbContexts;
using mag_app.Service.Services.CategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class CategoriesForm : Form
    {
        private readonly CategoryService _service;
        public static CategoriesForm categoryParent;
        public CategoriesForm(AppDbContext appDbContext)
        {
            _service = new CategoryService(appDbContext);
            InitializeComponent();
            categoryParent = this;
        }
        public long Id { get; set; }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public async void LoadData()
        {
            categoryFlowPanel.Controls.Clear();
            var items = await _service.GetAllAsync(storeControl.storeControlParent.Id);
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
                Font = new Font("Times New Roman", 14),
            };
            categoryFlowPanel.Controls.Add(w);
            w.Click += async (s, e) =>
            {
                Id = await _service.GetByName(w.Text);
                StoreProductsForm.storeProductParent.openChildForm(new ProductManageForm());
                StoreProductsForm.storeProductParent.backBtn.Hide();
                StoreProductsForm.storeProductParent.titleLabel.Text = w.Text;
                StoreProductsForm.storeProductParent.magLabel.Text = "Категории:";
            };
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(new AppDbContext());
            addCategoryForm.ShowDialog();
        }

        private void categoryFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, categoryFlowPanel.ClientRectangle,
            Color.DimGray, 1, ButtonBorderStyle.Solid, // left
            Color.DimGray, 1, ButtonBorderStyle.Solid, // top
            Color.White, 1, ButtonBorderStyle.Solid, // right
            Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
