using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.ProductService;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.Quick_PassForms;
using Microsoft.EntityFrameworkCore;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Edit_Product : Form
    {
        ProductService _product;
        public Edit_Product()
        {
            InitializeComponent();
            _product = new ProductService();
        }

        public string oldName { get; set; } = string.Empty;
        public new string ProductName { get; set; } = string.Empty;




        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            oldName = ProductName;
            FillPoles(ProductName);
        }





        public async void FillPoles(string productname)
        {
            using (var db = new AppDbContext())
            {
                var entity = await db.Products.Where(x => x.ProdutName == productname).ToListAsync();
                if (entity != null)
                {
                    foreach (var item in entity)
                    {
                        productNameTb.Text = item.ProdutName;
                        purchasePriceTb.Text = item.PurchasedPrice.ToString();
                        productPriceTb.Text = item.Price.ToString();
                        barcodeTb.Text = item.Barcode.ToString();
                    }
                }
            }
        }






        private async void updateBtn_Click(object sender, EventArgs e)
        {
            bool checkname = false;
            if (oldName == productNameTb.Text)
            {
                checkname = true;
            }
            else checkname = false;


            ProductViewModel product = new ProductViewModel()
            {
                ProdutName = productNameTb.Text,
                PurchasedPrice = decimal.Parse(purchasePriceTb.Text),
                Price = decimal.Parse(productPriceTb.Text),
                Quantity = 0,
                Barcode = barcodeTb.Text,
            };



            DialogResult dlg = MessageBox.Show("Хотите отредактировать продукт?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {


                var res1 = await _product.UpdateAsync(product, checkname);


                if (res1.message == "true")
                {

                    using (var db = new AppDbContext())
                    {
                        var products = db.AllProducts.Where(e => barcodeTb.Text.Contains(e.Barcode)).ToList();
                        products.ForEach(a =>
                        {
                            a.ProdutName = product.ProdutName;
                            a.PurchasedPrice = product.PurchasedPrice;
                            a.Price = product.Price;
                        });
                        db.SaveChanges();
                        AutoClosingMessageBox.Show("успешно отредактировано", "редактировать", 350);
                        Store_Product_Form.storeProductParent.openChildForm(new Store_List_Product());
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так, нет подходящего продукта");
                }
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }






        private void purchasePriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox)!.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }



        private void productPriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox)!.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
