using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.MainWindowForms;

public partial class Stores_Form : Form
{
    private StoreService _service;
    public FlowLayoutPanel panel = default!;
    public static Stores_Form myStoreFormParent = default!;



    public Stores_Form()
    {
        _service = new StoreService();
        myStoreFormParent = this;
        InitializeComponent();
    }
    public long Id { get; set; }
    public string StoreName { get; set; } = string.Empty;


    private void MyStoreForm_Load(object sender, EventArgs e)
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
            Id = await _service.GetId(w.Text);
            StoreName = w.Text;
            MainForm.mainParent.Hide();
            Store_Product_Form storeProductsForm = new Store_Product_Form();
            storeProductsForm.Show();
        };
        //
        // update button
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
            Edit_Store updateForm = new Edit_Store();
            updateForm.storeName = storename;
            updateForm.ShowDialog();
        };
        //
        // delete button
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
            DialogResult dlg = MessageBox.Show("Вы хотите удалить магазин?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                long id = await _service.GetId(storename);
                var res = _service.DeleteAsync(id);
                AutoClosingMessageBox.Show("Успешно удалено", "Delete", 300);
                LoadData();
            }
            if (dlg == DialogResult.Cancel)
            {
                //do nothing
            }
        };
    }



    public async void LoadData()
    {
        //
        // Create button
        //

        PrimaryButton primaryButton = new PrimaryButton();
        flowLayoutPanel1.Controls.Clear();
        flowLayoutPanel1.Controls.Add(primaryButton);
        primaryButton.Text = "добавить магазин";
        primaryButton.Width = 200;
        primaryButton.Height = 80;
        primaryButton.BorderRadius = 5;
        primaryButton.Click += (s, e) =>
        {
            Add_Store form = new Add_Store();
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




    private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, flowLayoutPanel1.ClientRectangle,
          Color.DimGray, 1, ButtonBorderStyle.Solid, // left
          Color.DimGray, 1, ButtonBorderStyle.Solid, // top
          Color.White, 1, ButtonBorderStyle.Solid, // right
          Color.White, 1, ButtonBorderStyle.Solid);// bottom
    }
}
