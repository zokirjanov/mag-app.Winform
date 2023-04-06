using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.Product_Forms;
using System.Security.Cryptography.X509Certificates;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Store_List_Product : Form
    {
        public static Store_List_Product parentInstanse = default!;
        public ProductService _service;
        public Store_List_Product()
        {
            _service = new ProductService();
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
            primaryButton.Width = 318;
            primaryButton.Height = 130;
            primaryButton.BorderRadius = 5;
            primaryButton.Click += (s, e) =>
            {
                Store_Add_Product form = new Store_Add_Product();
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
                Width = 318,
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
                Width = 150,
                TextAlign = ContentAlignment.MiddleLeft,
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
                Width = 150,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = product.Price.ToString(@"#\ ###\ ###\ ###\"),
                Font = new Font("Times New Roman", 12),
                Location = new Point(115, 80)
            }; labelPrice.Click += (sender, args) => InvokeOnClick(w, args);
            var labelQ = new Label()
            {
                Parent = w,
                Text = "количество во всех магазинов:",
                AutoSize = true,
                Font = new Font("Times New Roman", 12),
                Location = new Point(15, 100)
            }; labelQ.Click += (sender, args) => InvokeOnClick(w, args);

            var labelQuantity = new Label()
            {
                Parent = w,
                Text = product.Quantity.ToString(@"#\ ###\ ###\ ###\"),
                Font = new Font("Times New Roman", 12),
                AutoSize= true,
                Location = new Point(230, 100)
            }; labelQuantity.Click += (sender, args) => InvokeOnClick(w, args);


            //
            // Delete && Update Buttons
            //
            var update = new Button()
            {
                Parent = w,
                Width = w.Width / 9,
                Height = w.Height / 4,
                Location = new Point(270, 10),
                BackColor = Color.LightYellow,
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/edit-button.png"),
            };
            update.Click += (s, e) =>
            {
                Edit_Product productUpdateForm = new Edit_Product();
                productUpdateForm.ProductName = product.ProdutName;
                productUpdateForm.ShowDialog();
            };


            var delete = new Button()
            {
                Parent = w,
                Width = w.Width / 9,
                Height = w.Height / 4,
                Location = new Point(235, 10),
                BackColor = Color.Transparent,
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/delete.png")
            };
            delete.Click += async (s, e) =>
            {
                DialogResult dlg = MessageBox.Show("Вы хотите удалить товар?", "Удалить", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    long id = await _service.GetId(product.ProdutName);
                    var res = _service.DeleteAsync(id);


                    if (await res) AutoClosingMessageBox.Show("Успешно удалено", "Удалить", 300);
                    else if (await res == false) MessageBox.Show("Товар не найден");
                    LoadData();

                }
                if (dlg == DialogResult.Cancel)
                {
                    //do nothing
                }
            };
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Store_Product_Form.storeProductParent.openChildForm(new SubCategoriesForm());
            Store_Product_Form.storeProductParent.title1.Controls.RemoveAt(2);
            Store_Product_Form.storeProductParent.title2.Controls.RemoveAt(2);
            Store_Product_Form.storeProductParent.backBtn.Show();
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
