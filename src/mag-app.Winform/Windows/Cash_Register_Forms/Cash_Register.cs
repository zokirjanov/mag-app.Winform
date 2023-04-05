using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Cash_Register : Form
{

    private CashService _service;
    public static Cash_Register cashRegisterParent = default!;

    public Cash_Register()
    {
        _service = new CashService();
        cashRegisterParent = this;
        InitializeComponent();
    }




    private void Cash_Register_Load(object sender, EventArgs e)
    {
        LoadData();
    }



    public long Id { get; set; }
    public string CashName { get; set; } = string.Empty;



    public async void LoadData()
    {
        //
        // Create button
        //

        PrimaryButton primaryButton = new PrimaryButton();
        flowLayoutPanel1.Controls.Clear();
        flowLayoutPanel1.Controls.Add(primaryButton);
        primaryButton.Text = "добавить касса";
        primaryButton.Width = 200;
        primaryButton.Height = 80;
        primaryButton.BorderRadius = 5;
        primaryButton.Click += (s, e) =>
        {
            Add_Cash_Register form = new Add_Cash_Register();
            form.ShowDialog();
        };

        var items = await _service.GetAllAsync(MyStoreForm.myStoreFormParent.Id);
        if (items is null)
        {
            MessageBox.Show("касса не найден");
        }
        else
        {
            foreach (var item in items)
            {
                AddItem(item.CashName);
            }
        }
    }


    public void AddItem(string cashName)
    {

        var w = new Button
        {
            Text = cashName,
            Width = 200,
            Height = 80,
            BackColor = Color.LightSteelBlue,
            Font = new Font("Times New Roman", 14),
        };
        flowLayoutPanel1.Controls.Add(w);
        w.Click += async (s, e) =>
        {
            Id = await _service.GetId(w.Text);
            CashName = w.Text;
            StoreProductsForm.storeProductParent.Hide();
            Cash_Register_Main cash_Register_Main = new Cash_Register_Main();
            cash_Register_Main.ShowDialog();
        };

        //
        // update button
        //
        var update = new Button()
        {
            Parent = w,
            Width = w.Width / 8,
            Height = w.Height / 3,
            Location = new Point(165, 13),
            BackColor = Color.LightYellow,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/edit-button.png"),
        };
        update.Click += (s, e) =>
        {
            Edit_Cash_Register updateForm = new Edit_Cash_Register();
            updateForm.cashName = cashName;
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
            Location = new Point(165, 40),
            BackColor = Color.Transparent,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/delete.png")
        };
        delete.Click += async (s, e) =>
        {
            DialogResult dlg = MessageBox.Show("Вы хотите удалить кассу?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                long id = await _service.GetId(cashName);
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



    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, flowLayoutPanel1.ClientRectangle,
          Color.DimGray, 1, ButtonBorderStyle.Solid, // left
          Color.DimGray, 1, ButtonBorderStyle.Solid, // top
          Color.White, 1, ButtonBorderStyle.Solid, // right
          Color.White, 1, ButtonBorderStyle.Solid);// bottom
    }


}
