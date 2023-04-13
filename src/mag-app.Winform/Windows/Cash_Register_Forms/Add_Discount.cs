using mag_app.Winform.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Add_Discount : Form
    {
        private decimal _quantity;
        private decimal _Cost;

        public Add_Discount()
        {
            InitializeComponent();
        }

        private void Add_Discount_Load(object sender, EventArgs e)
        {

        }

        public decimal Discount { get; set; }
        public string ProductName { get => lblName.Text; set => lblName.Text = value; }
        public decimal Quantity { get => _quantity; set { _quantity = value; lblQuantity.Text = _quantity.ToString(); } }
        public decimal TotalDiscount { get => _Cost; set { _Cost = value; lblDiscount.Text = _Cost.ToString(@"###\ ###\ ###\ ###\") + " сум"; } }
        public decimal TotalCost { get => _Cost; set { _Cost = value; lblCost.Text = _Cost.ToString(@"###\ ###\ ###\ ###\") + " сум"; } }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(discountTb.Text))
            {
                decimal discount = decimal.Parse(discountTb.Text);
                decimal alldiscount = (TotalCost - (discount * TotalDiscount / 100));
                Discount = TotalCost - alldiscount;

                lblPriceWithDiscount.Text = alldiscount.ToString(@"###\ ###\ ###\ ###\") + " сум";
                lblDiscount.Text = (TotalCost - alldiscount).ToString(@"###\ ###\ ###\ ###\") + " сум";
            }
            else
            {
                lblPriceWithDiscount.Text = TotalCost.ToString(@"###\ ###\ ###\ ###\") + " сум";
                lblDiscount.Text = "";
            }
        }




        private void discountTb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox)!.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls)
                {
                    var wdg = (ProductControl)item;

                    if (wdg.Title == ProductName)
                    {
                        wdg.customPanel1.BorderColor = Color.ForestGreen;
                        wdg.customPanel1.BorderSize = 1;
                        wdg.Discount = Discount;
                        wdg.TotalCost = TotalCost - Discount;
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"товар не найден: {ex.Message}");
            }
        }
    }
}
