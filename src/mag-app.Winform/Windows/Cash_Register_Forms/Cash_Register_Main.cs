using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Cash_Register_Main : Form
{

    public static Cash_Register_Main cashRegisterMainParent = default!;
    TabService _service;
    TabProductService _productService;
    public FlowLayoutPanel flw;



    public Cash_Register_Main()
    {
        _service = new TabService();
        _productService = new TabProductService();
        cashRegisterMainParent = this;
        InitializeComponent();
        flw = tabFlowPanel;
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


        using (var db = new AppDbContext())
        {
            var items = await db.Tabs.OrderByDescending(x=>x.Id).ToListAsync();
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
           
    }

    private void AddItem(string tabname)
    {
        var tabButton = new Button
        {
            Text = tabname,
            Width = 90,
            Height = 40,
            BackColor = Color.Turquoise,
            Margin = new Padding(1, 6, 0, 0),
            Font = new Font("Times New Roman", 14),
        };
        tabButton.Click += async (s, e) =>
        {
            foreach(Control control in tabFlowPanel.Controls)
            {
                if(control.Margin == new Padding(1, 19, 0, 0))
                {
                    control.Margin = new Padding(1, 6, 0, 0);
                    control.BackColor= Color.Turquoise;
                }
            }
            tabButton.Margin = new Padding(1,19,0,0);
            tabButton.BackColor = Color.White;
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
        settingtab.Click += (s, e) =>
        {

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
                AddProductItem(item);
            }
        }


    }


    List<long> arrayID = new List<long>();

    private void AddProductItem(TabProduct product)
    {
        //arrayID.Add(product.ProductId);

        var tabProductButton = new Button
        {
            Width = 80,
            Height = 80,
            BackColor = Color.Transparent,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/brand-identity.png"),
        };

        var labelName = new Label()
        {
            Text = product.ProductName,
            Parent = tabProductButton,
            Width = 80,
            Height = 20,
            Font = new Font("Times new roman", 9),
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(0, 55),
        };


        labelName.Click += (sender, args) => InvokeOnClick(tabProductButton, args);
    

        tabProductButton.Click += (s, e) =>
        {
            if (!arrayID.Contains(product.ProductId) || arrayID.Count == 0)
            {
                arrayID.Add(product.ProductId);

                var ucProduct = new ProductControl()
                {
                    Title = product.ProductName,
                    Cost = product.Price.ToString(@"###\ ###\ ###\ ###\"),
                    Quantity = 1,
                    TotalCost = product.Price.ToString(@"###\ ###\ ###\ ###\"),
                };
                flowLayoutPanel1.Controls.Add(ucProduct);
            }
        };
        tabProductFlowPanel.Controls.Add(tabProductButton);
    }

    





    private void Cash_Register_Main_FormClosed(object sender, FormClosedEventArgs e)
    {
        Store_Product_Form.storeProductParent.Show();
        this.Close();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
        Color.Black, 1, ButtonBorderStyle.Solid, // left
        Color.Transparent, 1, ButtonBorderStyle.Solid, // top
        Color.Transparent, 1, ButtonBorderStyle.Solid, // right
        Color.Transparent, 1, ButtonBorderStyle.Solid);// bottom
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle,
        Color.Black, 1, ButtonBorderStyle.Solid, // left
        Color.Transparent, 1, ButtonBorderStyle.Solid, // top
        Color.Transparent, 1, ButtonBorderStyle.Solid, // right
        Color.Transparent, 1, ButtonBorderStyle.Solid);// bottom
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
        Color.Black, 1, ButtonBorderStyle.Solid, // left
        Color.Transparent, 1, ButtonBorderStyle.Solid, // top
        Color.Transparent, 1, ButtonBorderStyle.Solid, // right
        Color.Transparent, 1, ButtonBorderStyle.Solid);// bottom
    }

    private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
    {
        ControlPaint.DrawBorder(e.Graphics, flowLayoutPanel1.ClientRectangle,
        Color.Black, 1, ButtonBorderStyle.Solid, // left
        Color.Black, 1, ButtonBorderStyle.Solid, // top
        Color.Transparent, 1, ButtonBorderStyle.Solid, // right
        Color.Black, 1, ButtonBorderStyle.Solid);// bottom
    }

    private void primaryButton2_Click(object sender, EventArgs e)
    {
        DialogResult dlg = MessageBox.Show("Хотите очистить корзину?", "Очищения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        if (dlg == DialogResult.OK)
        {
            flowLayoutPanel1.Controls.Clear();
            arrayID.Clear();
        }
        if (dlg == DialogResult.Cancel)
        {
            // Do nothing
        }
    }
}
