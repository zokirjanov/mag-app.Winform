using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Cash_Register_Main : Form
{

    public static Cash_Register_Main cashRegisterMainParent = default!;
    TabService _service;
    TabProductService _tabProductService;
    ProductService _productService;
    public FlowLayoutPanel flw;



    public Cash_Register_Main()
    {
        _service = new TabService();
        _tabProductService = new TabProductService();
        _productService= new ProductService();
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
            var items = await db.Tabs.OrderByDescending(x => x.Id).ToListAsync();
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
            foreach (Control control in tabFlowPanel.Controls)
            {
                if (control.Margin == new Padding(1, 19, 0, 0))
                {
                    control.Margin = new Padding(1, 6, 0, 0);
                    control.BackColor = Color.Turquoise;
                }
            }
            tabButton.Margin = new Padding(1, 19, 0, 0);
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


        var items = await _tabProductService.GetAllAsync(TabId);

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



    private void AddProductItem(TabProduct product)
    {

        var tabProductButton = new Button
        {
            Text = product.ProductName,
            TextAlign = ContentAlignment.BottomCenter,
            Width = 80,
            Height = 80,
            BackColor = Color.Transparent,
            Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/brand-identity.png"),
        };
        tabProductFlowPanel.Controls.Add(tabProductButton);



        tabProductButton.Click += (ss, e) =>
        {
            var ucProduct = new ProductControl()
            {
                Margin = new Padding(2,2,15,2),
                Width = flowLayoutPanel1.Width - 10,
                Title = product.ProductName,
                Cost = product.Price,
                Quantity = 1,
                TotalCost = product.Price,
                Barcode = product.Barcode,
                maxQ = product.Quantity,
            };


            foreach(Control item in flowLayoutPanel1.Controls)
            {
                var wdg = (ProductControl)item;

                if(wdg.Title == ucProduct.Title)
                {
                    decimal totalPrice = (Convert.ToDecimal(wdg.Quantity) + 1) * wdg.Cost;
                    wdg.Quantity++;
                    wdg.TotalCost = totalPrice;
                    return;
                }
            }


            flowLayoutPanel1.Controls.Add(ucProduct);
        };
    }





    private void textBox1_TextChanged(object sender, EventArgs e)
    {


        if(barcodeTb.Text.Length == 13)
        {
            using (var db = new AppDbContext())
            {
                var tpr = db.Tabproducts.Where(x => x.AllProduct.Barcode == barcodeTb.Text).Include(x => x.AllProduct).ToList();

                foreach (var item in tpr)
                {
                    if (item.AllProduct != null)
                    {
                        customPanel2.BorderColor = Color.Lime;
                    }
                }
            }
        }
        else customPanel2.BorderColor = Color.Cyan;


    }


    private async void primaryButton3_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(barcodeTb.Text) && !string.IsNullOrEmpty(quantityTb.Text) && customPanel2.BorderColor == Color.Lime)
        {
            var product = await _productService.Get(barcodeTb.Text);
            if (product.Quantity <= int.Parse(quantityTb.Text))
            {
                MessageBox.Show($"недостаточно коbтество\n" +
                                $"максимальное количество товара на складе {product.Quantity}");
                return;
            }


            if (product != null)
            {


                var ucProduct = new ProductControl()
                {
                    Title = product.ProdutName,
                    Cost = product.Price,
                    Quantity = int.Parse(quantityTb.Text),
                    TotalCost = product.Price * int.Parse(quantityTb.Text),
                };


                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    var wdg = (ProductControl)item;

                    if (wdg.Title == ucProduct.Title)
                    {
                        decimal totalPrice = (Convert.ToDecimal(wdg.Quantity) + 1) * wdg.Cost;
                        wdg.Quantity += Convert.ToInt32(quantityTb.Text);
                        wdg.TotalCost = totalPrice;
                        quantityTb.Text = "";
                        return;
                    }
                }
                quantityTb.Text = "";
                flowLayoutPanel1.Controls.Add(ucProduct);
            }
            else MessageBox.Show("товар не найден");
        }
        else MessageBox.Show("заполните поле");
    }



    /// <summary>
    ///  Delete Specific controls
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void primaryButton4_Click(object sender, EventArgs e)
    {

        int cnt = 0;


        foreach (Control item in flowLayoutPanel1.Controls)
        {
            var wdg = (ProductControl)item;

            if (wdg.customPanel1.BorderColor == Color.Tomato)
            {
                cnt++;
                break;
            }
        }




        if (cnt > 0)
        {
            
            DialogResult dlg = MessageBox.Show("Хотите удалить товар?", "Очищения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
                {
                    var wdg = (ProductControl)flowLayoutPanel1.Controls[i];

                    if (wdg.customPanel1.BorderColor == Color.Tomato)
                    {
                        flowLayoutPanel1.Controls.RemoveAt(i);
                    }
                }
            }
            if (dlg == DialogResult.Cancel)
            {
                // Do nothing
            }

        }

        else MessageBox.Show("Выбранные продукты недоступны");
      
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
        if(flowLayoutPanel1.Controls.Count == 0)
        {
            return;
        }
        else
        {
            DialogResult dlg = MessageBox.Show("Хотите очистить корзину?", "Очищения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            if (dlg == DialogResult.Cancel)
            {
                // Do nothing
            }
        }
    }




    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }
        // only allow one decimal point
        if ((e.KeyChar == '.') && ((sender as TextBox)!.Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }
        if ((e.KeyChar == '.') && ((sender as TextBox)!.Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

}
