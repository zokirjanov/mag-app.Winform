using mag_app.Service.Services.AllProductService;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Edit_ProductQuantity : Form
    {
        AllProductService _service;
        public Edit_ProductQuantity()
        {
            InitializeComponent();
            button3.CausesValidation = true;
            _service = new AllProductService();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Cash_Register_Main.cashRegisterMainParent.Location.X + 545, Cash_Register_Main.cashRegisterMainParent.Location.Y + 97);
        }

        private async void Edit_ProductQuantity_Load(object sender, EventArgs e)
        {

            quantityTb.Text = Quantity.ToString();
            nameLb.Text = Name;
            lblMaxQ.Text = maxQ.ToString(@"###\ ###\ ###\ ###\");

        }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public new string Name { get; set; } = string.Empty;
        public string Barcode { get; set; }
        public decimal maxQ { get; set; }

        bool commaUsed = false;




        private void button13_Click(object sender, EventArgs e)
        {
            commaUsed = false;
            quantityTb.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CheckandFill(button12.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CheckandFill(button11.Text);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckandFill(button10.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckandFill(button9.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckandFill(button8.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckandFill(button7.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckandFill(button6.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckandFill(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckandFill(button4.Text);
        }


        private void CheckandFill(string number)
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







        bool checkMax = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkMax != true)
            {
                decimal total = decimal.Parse(quantityTb.Text) * Price;

                foreach (Control item in Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls)
                {
                    var wdg = (ProductControl)item;

                    if (wdg.Title == Name)
                    {
                        wdg.customPanel1.BorderColor = Color.ForestGreen;
                        wdg.customPanel1.BorderSize = 1;
                        wdg.TotalCost = total;
                        wdg.Quantity = decimal.Parse(quantityTb.Text);
                    }
                }
                this.Close();
            }
            else MessageBox.Show("Пожалуйста, введите действительное количество");
           
        }





        private async void quantityTb_TextChanged(object sender, EventArgs e)
        {
            decimal max = maxQ;

            int value;

            if (int.TryParse(quantityTb.Text, out value) && value > max)
            {
                errorProvider1.SetError(quantityTb, $"Maximum value is {max}");
                checkMax= true;
            }
            else
            {
                errorProvider1.SetError(quantityTb, "");
                checkMax = false;
            }
        }
    }
}
