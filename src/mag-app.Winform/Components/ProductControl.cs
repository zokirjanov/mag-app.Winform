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
        public string _cost;
        public string _totalCost;
        public int _quantity;       

        public ProductControl()
        {
            InitializeComponent();
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {

        }

        public string Title { get => ucTitle.Text; set => ucTitle.Text = value; }
        public string Cost { get => _cost; set { _cost = value; ucPrice.Text = _cost.ToString(); } }
        public string TotalCost { get => _totalCost; set { _totalCost = value; ucTotalPrice.Text = _totalCost.ToString(); } }
        public int Quantity { get => _quantity; set { _quantity = value; ucQuantity.Text = _quantity.ToString(); } }
    }
}
