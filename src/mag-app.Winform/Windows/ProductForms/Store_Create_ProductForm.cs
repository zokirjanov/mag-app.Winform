using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Store_Create_ProductForm : Form
    {
        public static Store_Create_ProductForm parentInstanse = default!;
        public ProductService _service;
        public Store_Create_ProductForm(AppDbContext appDbContext)
        {
            _service = new ProductService(appDbContext);
            parentInstanse = this;
            InitializeComponent();
        }


        private void Store_Create_ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        public async void LoadData()
        {
            PrimaryButton primaryButton = new PrimaryButton();
            create_ProductFlowPanel.Controls.Clear();
            create_ProductFlowPanel.Controls.Add(primaryButton);
            primaryButton.Text = "добавить продукт";
            primaryButton.Font = new Font("Times new roman", 14);
            primaryButton.Width = 270;
            primaryButton.Height = 130;
            primaryButton.BorderRadius = 5;
            primaryButton.Click += (s, e) =>
            {
                Store_Add_ProductForm form = new Store_Add_ProductForm(new AppDbContext());
                form.ShowDialog();
            };
            var items = await _service.GetAllAsync(SubCategoriesForm.subCategoryParent.Id);
            if (items is null)
            {
                MessageBox.Show("Stores not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item);
                }
            }
        }



        public void AddItem(Product product)
        {
            var w = new Button
            {
                Width = 270,
                Height = 130,
                BackColor = Color.LightSteelBlue,
            };
            create_ProductFlowPanel.Controls.Add(w);
            w.Click += (s, e) =>
            {
                MessageBox.Show("Product Clicked");
            };

            // Labels
            var labelname = new Slidinglabel()
            {
                Parent = w,
                Text = product.ProdutName,
                SliteTime = 25,
                Font = new Font("Times New Roman", 14),
                Height = 30,
                Width = 150,
                Location = new Point(15, 15),
                AutoSize = true,
            }; labelname.Click += (sender, args) => InvokeOnClick(w, args);

            var labelPp = new Label()
            {
                Parent = w,
                Text = "себестоимсть:",
                Font = new Font("Times New Roman", 12),
                Location = new Point(15, 60)
            }; labelPp.Click += (sender, args) => InvokeOnClick(w, args);

            var labelPprice = new Label()
            {
                Parent = w,
                AutoSize = true,
                Text = product.PurchasedPrice.ToString(@"#\ ###\ ###\ ###\"),
                Font = new Font("Times New Roman", 12),
                Location = new Point(115, 60)
            }; labelPprice.Click += (sender, args) => InvokeOnClick(w, args);

            var labelP = new Label()
            {
                Parent = w,
                Text = "цена:",
                Font = new Font("Times New Roman", 12),
                Location = new Point(15, 80)
            }; labelP.Click += (sender, args) => InvokeOnClick(w, args);
            var labelPrice = new Label()
            {
                Parent = w,
                AutoSize = true,
                Text = product.Price.ToString(@"#\ ###\ ###\ ###\"),
                Font = new Font("Times New Roman", 12),
                Location = new Point(115, 80)
            }; labelPrice.Click += (sender, args) => InvokeOnClick(w, args);
            var labelQ = new Label()
            {
                Parent = w,
                Text = "количество:",
                Font = new Font("Times New Roman", 12),
                Location = new Point(15, 100)
            }; labelQ.Click += (sender, args) => InvokeOnClick(w, args);
            var labelQuantity = new Label()
            {
                Parent = w,
                Text = product.Quantity.ToString(@" #\ ###\"),
                Font = new Font("Times New Roman", 12),
                Location = new Point(115, 100)
            }; labelQuantity.Click += (sender, args) => InvokeOnClick(w, args);


            //
            // Delete && Update Buttons
            //
            var update = new Button()
            {
                Parent = w,
                Width = w.Width / 9,
                Height = w.Height / 4,
                Location = new Point(230, 10),
                BackColor = Color.LightYellow,
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/edit-button.png"),
            };
            update.Click += (s, e) =>
            {
                ProductUpdateForm productUpdateForm = new ProductUpdateForm(new AppDbContext());
                productUpdateForm.ProductName = product.ProdutName;
                productUpdateForm.ShowDialog();
            };


            var delete = new Button()
            {
                Parent = w,
                Width = w.Width / 9,
                Height = w.Height / 4,
                Location = new Point(200, 10),
                BackColor = Color.Transparent,
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/delete.png")
            };
            delete.Click += async (s, e) =>
            {
                DialogResult dlg = MessageBox.Show("Вы хотите удалить товар?", "Удалить", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    var res = _service.DeleteAsync(product.ProdutName);
                    if (await res == "Успешно удалено") AutoClosingMessageBox.Show(await res, "Удалить", 300);
                    else if (await res == "Товар не найден") MessageBox.Show(await res);
                    else MessageBox.Show(await res);
                    StoreProductsForm.storeProductParent.openChildForm(new Store_Create_ProductForm(new AppDbContext()));
                }
                if (dlg == DialogResult.Cancel)
                {
                    //do nothing
                }
            };
        }



        private void button2_Click(object sender, EventArgs e)
        {
            StoreProductsForm.storeProductParent.openChildForm(new SubCategoriesForm(new AppDbContext()));
            StoreProductsForm.storeProductParent.title1.Controls.RemoveAt(2);
            StoreProductsForm.storeProductParent.title2.Controls.RemoveAt(2);
            StoreProductsForm.storeProductParent.backBtn.Show();
        }



        private void create_ProductFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, create_ProductFlowPanel.ClientRectangle,
            Color.DimGray, 1, ButtonBorderStyle.Solid, // left
            Color.DimGray, 1, ButtonBorderStyle.Solid, // top
            Color.White, 1, ButtonBorderStyle.Solid, // right
            Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
