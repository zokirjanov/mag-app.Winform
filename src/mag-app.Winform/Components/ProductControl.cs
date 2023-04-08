using mag_app.Winform.Windows.Cash_Register_Forms;
using mag_app.Winform.Windows.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Components
{
    public partial class ProductControl : UserControl
    {
        public static ProductControl controlParent = default;
        public decimal _cost;
        public decimal _totalCost;
        public int _quantity;
        private bool isColorChanged;

        public ProductControl()
        {
            InitializeComponent();
            controlParent = this;
            ucTitle.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            ucQuantity.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            ucPrice.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            ucTotalPrice.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label1.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label2.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label3.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label4.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label5.Click += (sender, args) => InvokeOnClick(customPanel1, args);
            label6.Click += (sender, args) => InvokeOnClick(customPanel1, args); 
        }



        private void ProductControl_Load(object sender, EventArgs e)
        {
        }

        


        public string Title { get => ucTitle.Text; set => ucTitle.Text = value; }
        public decimal Cost { get => _cost; set { _cost = value; ucPrice.Text = _cost.ToString(@"###\ ###\ ###\ ###\"); } }
        public decimal TotalCost { get => _totalCost; set { _totalCost = value; ucTotalPrice.Text = _totalCost.ToString(@"###\ ###\ ###\ ###\"); } }
        public int Quantity { get => _quantity; set { _quantity = value; ucQuantity.Text = _quantity.ToString(); } }





        private void button1_Click(object sender, EventArgs e)
        {
            Edit_ProductQuantity edit_ProductQuantity = new Edit_ProductQuantity();
            edit_ProductQuantity.Quantity = Quantity;
            edit_ProductQuantity.Name = Title;
            edit_ProductQuantity.ShowDialog();
        }




        private void customPanel1_Click(object sender, EventArgs e)
        {
            if (isColorChanged)
            {
                customPanel1.BorderColor = Color.ForestGreen;
                customPanel1.BorderSize = 1;
                isColorChanged = false;
            }
            else
            {
                customPanel1.BorderColor = Color.Tomato;
                customPanel1.BorderSize = 2;
                isColorChanged = true;
            }
        }
    }
}
