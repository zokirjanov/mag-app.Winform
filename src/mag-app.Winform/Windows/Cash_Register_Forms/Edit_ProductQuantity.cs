using mag_app.Winform.Components;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Edit_ProductQuantity : Form
    {
        public Edit_ProductQuantity()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Cash_Register_Main.cashRegisterMainParent.Location.X + 545, Cash_Register_Main.cashRegisterMainParent.Location.Y + 97);
        }
        private void Edit_ProductQuantity_Load(object sender, EventArgs e)
        {
            quantityTb.Text = Quantity.ToString();
            nameLb.Text = Name;
        }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; } = string.Empty;

        bool commaUsed = false;


        private void button13_Click(object sender, EventArgs e)
        {
            commaUsed = false;
            quantityTb.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChechandFill(button12.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChechandFill(button11.Text);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChechandFill(button10.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChechandFill(button9.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChechandFill(button8.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChechandFill(button7.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChechandFill(button6.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChechandFill(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChechandFill(button4.Text);
        }


        private void ChechandFill(string number)
        {
            if (quantityTb.Text.Length == 1 && quantityTb.Text.Contains("0"))
            {
                quantityTb.Text = number.ToString();
            }
            else
            {
                quantityTb.Text += number.ToString();
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            string check = quantityTb.Text;
            if (quantityTb.Text.Length == 1 && check.Contains("0"))
            {
                quantityTb.Text = "0";
            }
            else
            {
                quantityTb.Text += button14.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantityTb.Text))
            {
                quantityTb.Text = "";
                return;
            }
            if (!commaUsed)
            {
                quantityTb.Text += btnComa.Text;
                commaUsed = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if ((quantityTb.Text == "0" || quantityTb.Text == ""))
            {
                quantityTb.Text = "0";
            }
            else
            {
                quantityTb.Text += button1.Text;
            }
        }



        private void quantityTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox)!.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }



        private void button17_Click(object sender, EventArgs e)
        {
            if (quantityTb.Text == "") quantityTb.Text = "0";
            decimal value = decimal.Parse(quantityTb.Text);
            value++;
            quantityTb.Text = value.ToString();
        }



        private void button16_Click(object sender, EventArgs e)
        {
            if (quantityTb.Text == "") return;
            decimal value = decimal.Parse(quantityTb.Text);
            value = Math.Max(value - 1, 0);
            quantityTb.Text = value.ToString();
        }



        private void button15_Click(object sender, EventArgs e)
        {
            if (quantityTb.Text.Length > 0)
            {
                quantityTb.Text = quantityTb.Text.Substring(0, quantityTb.Text.Length - 1);
            }
            if (quantityTb.Text.EndsWith(","))
            {
                commaUsed = false;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(quantityTb.Text) * Price;

            foreach (Control item in Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls)
            {
                var wdg = (ProductControl)item;

                if (wdg.Title == Name)
                {
                    wdg.TotalCost = total;
                    wdg.Quantity = int.Parse(quantityTb.Text);
                }
            }
            this.Close();
        }
    }
}
