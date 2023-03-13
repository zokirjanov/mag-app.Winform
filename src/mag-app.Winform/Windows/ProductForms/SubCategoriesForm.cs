using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.SubCategoryService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class SubCategoriesForm : Form
    {
        private SubCategoryService _service;
        public static SubCategoriesForm subCategoryParent;
        public long Id { get; set; }
        public SubCategoriesForm(AppDbContext appDbContext)
        {
            _service = new SubCategoryService(appDbContext);
            subCategoryParent = this;
            InitializeComponent();
        }

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
            primaryButton.Width = 200;
            primaryButton.BorderRadius = 5;
            primaryButton.Click += (s, e) =>
            {
                AddSbCategoryForm addSbCategoryForm = new AddSbCategoryForm(new AppDbContext());
                addSbCategoryForm.ShowDialog();
            };
            var items = await _service.GetAllAsync(CategoriesForm.categoryParent.Id);
            if (items is null)
            {
                MessageBox.Show("Sub-Categories not found");
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
                Width = 200,
                Height = 75,
                BackColor = Color.LightSkyBlue,
                Font = new Font("Times New Roman", 14),
            };
            subCategoryFlowPanel.Controls.Add(button);
            button.Click += async (s, e) =>
            {
                Id = await _service.GetByName(button.Text);
                StoreProductsForm.storeProductParent.openChildForm(new ProductManageForm());
                StoreProductsForm.storeProductParent.titleLabel.Text = button.Text;
                StoreProductsForm.storeProductParent.backBtn.Hide();
            };
            var update = new Button()
            {
                Parent = button,
                Width = button.Width / 8,
                Height = button.Height / 3,
                Location = new Point(170, 13),
                BackColor = Color.LightYellow,
                Image = Image.FromFile(@"D:\shohrux\mag-app\src\mag-app.Winform\Resources\Icons\edit-button.png"),
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
                Image = Image.FromFile(@"D:\shohrux\mag-app\src\mag-app.Winform\Resources\Icons\delete.png")
            };
            delete.Click += async (s, e) =>
            {
                DialogResult dlg = MessageBox.Show("Are you sure to delete Sub-Category?\n" +
                                                   "All Sub-categories and products will be deleted permanently", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg == DialogResult.OK)
                {
                    var res = _service.DeleteAsync(subcategoryName);
                    AutoClosingMessageBox.Show("Succesfully deleted", "Delete", 350);
                    LoadData();
                }
                if (dlg == DialogResult.Cancel)
                {
                    this.Hide();
                }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StoreProductsForm.storeProductParent.openChildForm(new CategoriesForm(new AppDbContext()));
            StoreProductsForm.storeProductParent.backBtn.Show();
            StoreProductsForm.storeProductParent.Title.Remove(StoreProductsForm.storeProductParent.Title.Length -5, 4 );
            StoreProductsForm.storeProductParent.titleLabel.Text = StoreProductsForm.storeProductParent.Title.ToString();
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
}
