using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.CategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Properties;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

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
        public string  CategoryTitle { get; set; }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            primaryButton.Text = "добавить категории";
            primaryButton.Width = 205;
            primaryButton.BorderRadius = 5;
            primaryButton.Height = 75;
            categoryFlowPanel.Controls.Clear();
            categoryFlowPanel.Controls.Add(primaryButton);
            primaryButton.Click += (s, e) =>
            {
                AddCategoryForm addCategoryForm = new AddCategoryForm(new AppDbContext());
                addCategoryForm.ShowDialog();
            };
            var items = await _service.GetAllAsync(MyStoreForm.myStoreFormParent.Id);
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
                BackColor = Color.LightGreen,
                Font = new Font("Times New Roman", 14),
            };
            categoryFlowPanel.Controls.Add(w);
            w.Click += async (s, e) =>
            {
                Id = await _service.GetByName(w.Text);
                CategoryTitle = w.Text;
                StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm(new AppDbContext()));
                StoreProductsForm.storeProductParent.backBtn.Hide();
            };

            var update = new Button()
            {
                Parent = w,
                Width = w.Width / 8,
                Height = w.Height /3,
                Location = new Point(170, 13),
                BackColor = Color.LightYellow,
                Image = Image.FromFile(@"D:\shohrux\mag-app\src\mag-app.Winform\Resources\Icons\edit-button.png"),
            };
                update.Click += async (s, e) =>
                {
                    CategoryUpdateForm category = new CategoryUpdateForm(new AppDbContext());
                    category.categoryName = w.Text;
                    category.ShowDialog();
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
                    DialogResult dlg = MessageBox.Show("Are you sure to delete Category?\n" +
                                                       "All Sub-categories and products will be deleted permanently", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        var res = _service.DeleteAsync(w.Text);
                        if (await res == true)
                        {
                            AutoClosingMessageBox.Show("Succesfully deleted", "Delete", 350);
                            LoadData();
                        }
                        else MessageBox.Show("Category can not be deleted");
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Hide();
                    }
                };
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
