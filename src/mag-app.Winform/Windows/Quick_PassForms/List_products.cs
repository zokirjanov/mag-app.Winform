using mag_app.DataAccess.DbContexts;
using mag_app.Service.Dtos.Products;
using mag_app.Service.Services.ProductService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Quick_PassForms
{
    public partial class List_products : Form
    {
        private ProductService _service;

        public List_products(AppDbContext appDbContext)
        {
            _service= new ProductService(appDbContext);
            InitializeComponent();
        }

        private void List_products_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            using (var db =  new AppDbContext())
            {
                var entity = db.Products.ToList();
                foreach(var i in entity)
                {
                    productDtoBindingSource.Add(new ProductDto() {ProdutName = i.ProdutName, Barcode = i.Barcode, EmployeeId = i.EmployeeId, Price=i.Price, PurchasedPrice = i.PurchasedPrice, Quantity = i.Quantity, StoreId = i.StoreId, SubCategoryId = i.SubCategoryId, UpdatedAt = i.UpdatedAt});
                }
            }
        }
    }
}
