using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms;

public partial class SubCategoriesForm : Form
{
    public static SubCategoriesForm subCategoryParent;
    private SubCategoryService _service;

    public SubCategoriesForm(AppDbContext appDbContext)
    {
        _service = new SubCategoryService(appDbContext);
        subCategoryParent = this;
        InitializeComponent();
    }
    public long Id { get; set; }
    public string Title { get; set; }




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
        primaryButton.Height = 75;
        primaryButton.Width = 205;
        primaryButton.BorderRadius = 5;
        primaryButton.Click += (s, e) =>
        {
            AddSbCategoryForm addSbCategoryForm = new AddSbCategoryForm(new AppDbContext());
            addSbCategoryForm.ShowDialog();
        };
        var items = await _service.GetAllAsync(CategoriesForm.categoryParent.Id, IdentitySingelton.GetInstance().EmployeeId);
        if (items is null)
        {
            MessageBox.Show("Подкатегории не найдены");
        }
        else
        {
            foreach (var item in items)
            {
                AddItem(item.SubCategoryName);
            }
        }
    }





    public void AddItem(string subcategoryName)
    {
        var button = new Button()
        {
            Text = subcategoryName,
            Width = 205,
            Height = 75,
            BackColor = Color.LightSkyBlue,
            Font = new Font("Times New Roman", 14),
        };
        subCategoryFlowPanel.Controls.Add(button);
        button.Click += async (s, e) =>
        {
            Id = await _service.GetByNameAsync(button.Text);
            Title = button.Text;
            StoreProductsForm.storeProductParent.openChildForm(new Store_Create_ProductForm(new AppDbContext()));
            StoreProductsForm.storeProductParent.AddTitle(button.Text, "›подкатегория");
            StoreProductsForm.storeProductParent.backBtn.Hide();
        };
        var update = new Button()
        {
            Parent = button,
            Width = button.Width / 8,
            Height = button.Height / 3,
            Location = new Point(170, 13),
            BackColor = Color.LightYellow,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/edit-button.png"),
        };
        update.Click += async (s, e) =>
        {
            SubCategoryUpdateForm category = new SubCategoryUpdateForm(new AppDbContext());
            category.categoryName = button.Text;
            category.ShowDialog();
        };
        var delete = new Button()
        {
            Parent = button,
            Width = button.Width / 8,
            Height = button.Height / 3,
            Location = new Point(170, 40),
            BackColor = Color.Transparent,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/delete.png")
        };
        delete.Click += async (s, e) =>
        {
            DialogResult dlg = MessageBox.Show("Вы уверены, что хотите удалить подкатегорию?\n" +
                                               "Все подкатегории и продукты будут удалены безвозвратно.",
                                               "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = _service.DeleteAsync(subcategoryName);
                if (await res == true)
                {
                    AutoClosingMessageBox.Show("Успешно удалено", "Delete", 350);
                    LoadData();
                }
                else MessageBox.Show("Подкатегория не может быть удалена!");
            }
            if (dlg == DialogResult.Cancel)
            {
                // do nothing
            }
        };
    }




    private void button2_Click(object sender, EventArgs e)
    {
        StoreProductsForm.storeProductParent.openChildForm(new CategoriesForm(new AppDbContext()));
        StoreProductsForm.storeProductParent.title1.Controls.RemoveAt(1);
        StoreProductsForm.storeProductParent.title2.Controls.RemoveAt(1);
        StoreProductsForm.storeProductParent.backBtn.Show();
    }




    private void subCategoryFlowPanel_Paint(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, subCategoryFlowPanel.ClientRectangle,
        Color.DimGray, 1, ButtonBorderStyle.Solid, // left
        Color.DimGray, 1, ButtonBorderStyle.Solid, // top
        Color.White, 1, ButtonBorderStyle.Solid, // right
        Color.White, 1, ButtonBorderStyle.Solid);// bottom
    }
}
