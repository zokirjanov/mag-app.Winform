using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Cash_Register_Main : Form
{



    private static readonly Image _productImage = Image.FromFile("Data Source= ../../../../../Resources/Icons/brand-identity.png");
    public readonly HashSet<string> _productTitles = new HashSet<string>();
    public static Cash_Register_Main cashRegisterMainParent = default!;
    public FlowLayoutPanel flw;
    TabProductService _tabProductService;
    ProductService _productService;
    TabService _service;



    public Cash_Register_Main()
    {
        _service = new TabService();
        _tabProductService = new TabProductService();
        _productService = new ProductService();
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





    private void btnPayment_Click(object sender, EventArgs e)
    {
        if (flowLayoutPanel1.Controls.Count != 0)
        {

            if (CheckQuantity())
            {
                decimal total;
                decimal totalDiscount;
                Payment(out total, out totalDiscount);
                Payment payment = new Payment();
                payment.TotalAmount = total;
                payment.TotalDiscount = totalDiscount;
                payment.ShowDialog();
            }

        }
        else
        {
            MessageBox.Show("Корзина пуста");
        }
    }





    private void Payment(out decimal total, out decimal totalDiscount)
    {
        total = 0;
        totalDiscount = 0;
        try
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is ProductControl productControl)
                {
                    total += productControl.TotalCost;
                    totalDiscount += productControl.Discount;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"товар не найден: {ex.Message}");
        }
    }







    private bool CheckQuantity()
    {
        int counter = 0;
        foreach (Control item in flowLayoutPanel1.Controls)
        {
            var wdg = (ProductControl)item;
            if (wdg.Quantity > wdg.maxQ)
            {
                counter++;
                wdg.customPanel1.BorderColor = Color.Tomato;
                wdg.customPanel1.BorderSize = 2;
            }
        }

        if (counter > 0)
        {
            MessageBox.Show("недостаточно продуктов");
            return false;
        }
        return true;
    }









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
            Width = 120,
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
            Image = _productImage,
        };
        tabProductFlowPanel.Controls.Add(tabProductButton);

        tabProductButton.Click += (ss, e) =>
        {
            var ucProduct = new ProductControl()
            {
                Margin = new Padding(2, 2, 15, 2),
                Width = flowLayoutPanel1.Width - 10,
                Title = product.ProductName,
                Cost = product.Price,
                Quantity = 1,
                TotalCost = product.Price,
                Barcode = product.Barcode,
                maxQ = product.AllProduct.Quantity,
                ProductId = product.ProductId,
                Category = product.Category,
                SubCategory = product.Subcategory
            };

            if (_productTitles.Contains(ucProduct.Title))
            {
                var existingProduct = flowLayoutPanel1.Controls
                    .OfType<ProductControl>()
                    .FirstOrDefault(pc => pc.Title == ucProduct.Title);

                decimal totalPrice = (Convert.ToDecimal(existingProduct.Quantity) + 1) * existingProduct.Cost;
                existingProduct.Quantity++;
                existingProduct.TotalCost = totalPrice;
            }
            else
            {
                flowLayoutPanel1.Controls.Add(ucProduct);
                _productTitles.Add(ucProduct.Title);
            }
        };
    }






    private void textBox1_TextChanged(object sender, EventArgs e)
    {


        if (barcodeTb.Text.Length == 13)
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
        if (string.IsNullOrEmpty(barcodeTb.Text) || string.IsNullOrEmpty(quantityTb.Text) || customPanel2.BorderColor != Color.Lime)
        {
            MessageBox.Show("заполните поле");
            return;
        }

        var product = await _productService.Get(barcodeTb.Text);

        if (product == null)
        {
            MessageBox.Show("товар не найден");
            return;
        }

        if (product.Quantity <= int.Parse(quantityTb.Text))
        {
            MessageBox.Show($"недостаточно коbтество\n" +
                            $"максимальное количество товара на складе {product.Quantity}");
            return;
        }

        var existingProduct = flowLayoutPanel1.Controls
            .OfType<ProductControl>()
            .FirstOrDefault(pc => pc.Title == product.ProdutName);

        if (existingProduct != null)
        {
            decimal totalPrice = (Convert.ToDecimal(existingProduct.Quantity) + 1) * existingProduct.Cost;
            existingProduct.Quantity += Convert.ToInt32(quantityTb.Text);
            existingProduct.TotalCost = totalPrice;
        }
        else
        {
            var ucProduct = new ProductControl()
            {
                Title = product.ProdutName,
                Cost = product.Price,
                Quantity = int.Parse(quantityTb.Text),
                TotalCost = product.Price * int.Parse(quantityTb.Text),
            };
            flowLayoutPanel1.Controls.Add(ucProduct);
        }

        quantityTb.Text = "";
    }







    private async void primaryButton4_Click(object sender, EventArgs e)
    {
        var productsToRemove = flowLayoutPanel1.Controls
            .OfType<ProductControl>()
            .Where(p => p.customPanel1.BorderColor == Color.Tomato)
            .ToList();

        if (productsToRemove.Count > 0)
        {
            DialogResult dlg = MessageBox.Show("Хотите удалить товар?", "Очищения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dlg == DialogResult.OK)
            {
                foreach (var product in productsToRemove)
                {
                    flowLayoutPanel1.Controls.Remove(product);
                    _productTitles.Remove(product.Title);
                }
            }
        }
        else
        {
            MessageBox.Show("Выбранные продукты недоступны");
        }
    }






    private void primaryButton2_Click(object sender, EventArgs e)
    {
        if (flowLayoutPanel1.Controls.Count == 0)
        {
            return;
        }
        else
        {
            DialogResult dlg = MessageBox.Show("Хотите очистить корзину?", "Очищения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                flowLayoutPanel1.Controls.Clear();
                _productTitles.Clear();
            }
            if (dlg == DialogResult.Cancel)
            {
                // Do nothing
            }
        }
    }









    private void Cash_Register_Main_FormClosed(object sender, FormClosedEventArgs e)
    {
        Store_Product_Form.storeProductParent.Show();
        this.Close();
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






    private void button1_Click(object sender, EventArgs e)
    {
        ProductControl selectedProduct = flowLayoutPanel1.Controls
            .OfType<ProductControl>()
            .FirstOrDefault(pc => pc.customPanel1.BorderColor == Color.Tomato);

        if (selectedProduct == null)
        {
            MessageBox.Show("Пожалуйста, выберите продукт для добавления на скидку");
            return;
        }

        if (flowLayoutPanel1.Controls.OfType<ProductControl>().Count(pc => pc.customPanel1.BorderColor == Color.Tomato) > 1)
        {
            MessageBox.Show("Пожалуйста, выберите только 1 продукт для добавления на скидку");
            return;
        }

        Add_Discount add_Discount = new Add_Discount();
        add_Discount.ProductName = selectedProduct.Title.ToString();
        add_Discount.TotalCost = selectedProduct.TotalCost;
        add_Discount.ShowDialog();
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

    private void button2_Click(object sender, EventArgs e)
    {
        Return_Check return_List = new Return_Check();
        return_List.ShowDialog();
    }
}
