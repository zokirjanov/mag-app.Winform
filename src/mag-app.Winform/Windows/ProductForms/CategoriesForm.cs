using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.CategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Properties;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace mag_app.Winform.Windows.ProductForms;

public partial class CategoriesForm : Form
{
    private readonly CategoryService _service;
    public static CategoriesForm categoryParent = default!;


    public CategoriesForm()
    {
        _service = new CategoryService();
        categoryParent = this;
        InitializeComponent();
    }


    public long Id { get; set; }
    public string CategoryTitle { get; set; } = string.Empty;



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
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
        };

        var items = await _service.GetAllAsync();

        if (items is null)
        {
            MessageBox.Show("Категории не найдены");
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

        //
        // Categories Button
        //
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
            Id = await _service.GetId(w.Text);
            CategoryTitle = w.Text;
            StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm());
            StoreProductsForm.storeProductParent.AddTitle(categoryName, "›категория");
            StoreProductsForm.storeProductParent.backBtn.Hide();
        };
        //
        // Update Category Button
        //
        var update = new Button()
        {
            Parent = w,
            Width = w.Width / 8,
            Height = w.Height / 3,
            Location = new Point(170, 13),
            BackColor = Color.LightYellow,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/edit-button.png"),
        };
        update.Click += (s, e) =>
        {
            CategoryUpdateForm category = new CategoryUpdateForm();
            category.categoryName = w.Text;
            category.ShowDialog();
        };

        //
        // Delete Category Button
        //
        var delete = new Button()
        {
            Parent = w,
            Width = w.Width / 8,
            Height = w.Height / 3,
            Location = new Point(170, 40),
            BackColor = Color.Transparent,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/delete.png")
        };
        delete.Click += async (s, e) =>
        {
            DialogResult dlg = MessageBox.Show("Вы уверены, что хотите удалить категорию?\n" + "Все подкатегории и продукты будут удалены безвозвратно", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                long id = await _service.GetId(w.Text);
                var res = _service.DeleteAsync(id);
                if (await res == true)
                {
                    AutoClosingMessageBox.Show("\r\nУспешно удалено\r\n", "Delete", 350);
                    LoadData();
                }
                else MessageBox.Show("категория не может быть удалена!");
            }
            if (dlg == DialogResult.Cancel)
            {
                //do nothing
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
