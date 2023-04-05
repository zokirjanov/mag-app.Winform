using mag_app.Service.Services.StoreService;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Cash_Register_Main : Form
{

    public static Cash_Register_Main cashRegisterMainParent = default!;
    TabService _service;
    TabProductService _productService;

    public Cash_Register_Main()
    {
        _service = new TabService();
        _productService = new TabProductService();
        cashRegisterMainParent = this;
        InitializeComponent();
    }

    private void Cash_Register_Main_Load(object sender, EventArgs e)
    {
        FillTabs();
    }


    public long TabId { get; set; }
    public string TabName { get; set; } = string.Empty;





    /// <summary>
    /// Tab Controllers Dynamically
    /// </summary>
    public async void FillTabs()
    {
        tabFlowPanel.Controls.Clear();
        Panel firstpanel = new Panel()
        {
            Width = 80,
            Height = tabFlowPanel.Height,
        };
        Button settingtab = new Button()
        {
            Parent = firstpanel,
            Height = 40,
            Width = 40,
            BackColor = Color.Azure,
            Location = new Point(0, 3),
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/cogwheel.png"),
        };
        settingtab.Click += (s, e) =>
        {
            if (!string.IsNullOrEmpty(TabName))
            {
                Edit_TabController edit_TabController = new Edit_TabController();
                edit_TabController.TabName = TabName;
                edit_TabController.ShowDialog();
            }
            else MessageBox.Show("выберите вкладку!");

        };
        Button addTab = new Button()
        {
            Parent = firstpanel,
            Height = 40,
            Width = 40,
            BackColor = Color.Azure,
            Location = new Point(40, 3),
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/plus.png"),
        };
        addTab.Click += (s, e) =>
        {
            Add_TabControl add_TabControl = new Add_TabControl();
            add_TabControl.ShowDialog();
        };

        tabFlowPanel.Controls.Add(firstpanel);

        var items = await _service.GetAllAsync();
        if (items is null)
        {
            MessageBox.Show("Tabs not found");
        }
        else
        {
            foreach (var item in items)
            {
                AddItem(item.TabName);
            }
        }
    }

    private void AddItem(string tabname)
    {
        var tabButton = new Button
        {
            Text = tabname,
            Width = 90,
            Height = 40,
            BackColor = Color.WhiteSmoke,
            Margin = new Padding(1, 6, 0, 0),
            Font = new Font("Times New Roman", 14),
        };
        tabButton.Click += async (s, e) =>
        {
            foreach(Control control in tabFlowPanel.Controls)
            {
                if(control.Margin == new Padding(1,19,0,0))
                control.Margin = new Padding(1,6,0,0);
            }
            tabButton.Margin = new Padding(1,19,0,0);
            TabId = await _service.GetId(tabname);
            TabName = tabname;
            TabProductsFill();
        };

        tabFlowPanel.Controls.Add(tabButton);
    }




    /// <summary>
    /// Fill Tab Products
    /// </summary>
    public async void TabProductsFill()
    {
        tabProductFlowPanel.Controls.Clear();
        Panel firstpanel = new Panel()
        {
            Width = 160,
            Height = 80,
        };
        Button settingtab = new Button()
        {
            Parent = firstpanel,
            Height = firstpanel.Height,
            Width = firstpanel.Width / 2,
            BackColor = Color.Azure,
            Location = new Point(0, 0),
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/cogwheel.png"),
        };
        Button addTab = new Button()
        {
            Parent = firstpanel,
            Height = firstpanel.Height,
            Width = firstpanel.Width / 2,
            BackColor = Color.Azure,
            Location = new Point(80, 0),
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/plus.png"),
        };
        addTab.Click += (s, e) =>
        {
            Add_TabProduct add_TabProduct = new Add_TabProduct();
            add_TabProduct.ShowDialog();
        };

        tabProductFlowPanel.Controls.Add(firstpanel);

        var items = await _productService.GetAllAsync(TabId);
        if (items is null)
        {
            MessageBox.Show("Tab Products not found");
        }
        else
        {
            foreach (var item in items)
            {
                AddProductItem(item.ProductName);
            }
        }
    }


    private void AddProductItem(string name)
    {
        var tabProductButton = new Button
        {
            Width = 80,
            Height = 80,
            BackColor = Color.Transparent,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/brand-identity.png"),
        };
        var labelName = new Label()
        {
            Text = name,
            Parent = tabProductButton,
            Width = 80,
            Height = 20,
            Font = new Font("Times new roman", 9),
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(0, 55),
        };
        labelName.Click += (sender, args) => InvokeOnClick(tabProductButton, args);

        tabProductFlowPanel.Controls.Add(tabProductButton);
    }




    private void Cash_Register_Main_FormClosed(object sender, FormClosedEventArgs e)
    {
        StoreProductsForm.storeProductParent.Show();
        this.Close();
    }
}
