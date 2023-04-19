using mag_app.Domain.Constant;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Payment : Form
    {
        SaleDetailsService salesGlobal;
        SaleGlobalService saleDetail;
        AllProductService productService;
        TabProductService tabProductService;




        public Payment()
        {
            salesGlobal = new SaleDetailsService();
            saleDetail = new SaleGlobalService();
            productService = new AllProductService();
            tabProductService = new TabProductService();
            InitializeComponent();
        }






        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        bool commaUsed = false;




        private void Payment_Load(object sender, EventArgs e)
        {
            totalSum.Text = TotalAmount.ToString(@"###\ ###\ ###\ ###\");
        }





        private async void btnPay_Click(object sender, EventArgs e)
        {

            decimal check = decimal.Parse(lblActiveSum.Text);
            decimal changeAmount = 0;


            if (check >= TotalAmount && btnPay.BackColor == Color.Turquoise)
            {
                changeAmount = check - TotalAmount;
                bool paymentProcessed = await PreparePaymentInfo(changeAmount);

                if (paymentProcessed)
                {
                    MessageBox.Show($"Платеж успешно обработан\nВаше сдача {check - TotalAmount} сум");
                    Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls.Clear();
                    Cash_Register_Main.cashRegisterMainParent._productTitles.Clear();
                    Cash_Register_Main.cashRegisterMainParent.TabProductsFill();
                    this.Close();
                }
                else
                {
                    AutoClosingMessageBox.Show("Ошибка обработки платежа", "Error", 1000);
                }
            }
            else MessageBox.Show("торговля ведется не корректно");

        }
        




        private async Task<bool> PreparePaymentInfo(decimal changeAmount)
        {


            if (!decimal.TryParse(lblCard.Text, out decimal card)) card = 0;
            if (!decimal.TryParse(lblCash.Text, out decimal cash)) cash = 0;



            PaymentType type = (card != 0 && cash !=0) ? PaymentType.частичная_оплата : (cash != 0 ? PaymentType.наличные : PaymentType.Терминал);



            SaleDetailsViewModel SaleGlobal = new SaleDetailsViewModel()
            {
                CheckNumber = "null",
                TotalSale = card + cash,
                StoreId = Stores_Form.myStoreFormParent.Id,
                StoreName = Stores_Form.myStoreFormParent.StoreName,
                CashId = Cash_Register_List.cashRegisterParent.Id,
                CashName = Cash_Register_List.cashRegisterParent.CashName,
                PaymentType = type,
                CashAmount = cash,
                CardAmount = card,
                Change = changeAmount,
                Discount = TotalDiscount
            };




            try
            {
                var sg = await salesGlobal.CreateAsync(SaleGlobal);

                if (sg != null)
                {
                    foreach (ProductControl item in Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls.OfType<ProductControl>())
                    {
                        SaleGlobalViewModel saleDetails = new SaleGlobalViewModel()
                        {
                            SaleId = sg.Id,
                            ProductId = item.ProductId,
                            ProductName = item.Title,
                            Category = item.Category,
                            SubCategory= item.SubCategory,
                            Quantity = item.Quantity,
                            Price = item.TotalCost,
                            DiscountPrice = item.Discount,
                            Barcode = item.Barcode
                        };
                        var sd = await saleDetail.CreateAsync(saleDetails);

                        await productService.UpdateAsync(sd.ProductId, item.Quantity);
                        await tabProductService.UpdateAsync(sd.Barcode, item.Quantity);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }







        private void UpdatePayment(decimal paymentAmount, Label paymentLabel)
        {
            if (string.IsNullOrEmpty(quantityTb.Text))
            {
                return;
            }


            if (paymentAmount != 0)
            {
                decimal count = decimal.Parse(lblActiveSum.Text) + paymentAmount;
                lblActiveSum.Text = count.ToString(@"###\ ###\ ###\ ###\");

                paymentLabel.Text = paymentAmount.ToString(@"###\ ###\ ###\ ###\");
                quantityTb.Text = "";
            }

            decimal totalAmount = decimal.Parse(lblCard.Text) + decimal.Parse(lblCash.Text);


            if (totalAmount >= TotalAmount)
            {
                btnPay.BackColor = Color.Turquoise;
                lblActiveSum.ForeColor = Color.Green;
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Green;
            }
        }







        private void btnCash_Click(object sender, EventArgs e)
        {
            decimal cashAmount;
            if (decimal.TryParse(quantityTb.Text, out cashAmount))
            {
                UpdatePayment(cashAmount, lblCash);
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            decimal cardAmount;
            if (decimal.TryParse(quantityTb.Text, out cardAmount))
            {
                UpdatePayment(cardAmount, lblCard);
            }
        }








        private void CheckandFill(string number)
        {
            if (quantityTb.SelectionLength > 0)
            {
                quantityTb.Text = number.ToString();
            }
            else if (quantityTb.Text.Length == 1 && quantityTb.Text.Contains("0"))
            {
                quantityTb.Text = number.ToString();
            }
            else
            {
                quantityTb.Text += number.ToString();
            }
        }




        private void btnComa_Click(object sender, EventArgs e)
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



        private void btnZero_Click(object sender, EventArgs e)
        {
            string check = quantityTb.Text;
            if (quantityTb.Text.Length == 1 && check.Contains("0"))
            {
                quantityTb.Text = "0";
            }
            else
            {
                quantityTb.Text += btnZero.Text;
            }
        }




        private void btnDoubleZero_Click(object sender, EventArgs e)
        {
            if ((quantityTb.Text == "0" || quantityTb.Text == ""))
            {
                quantityTb.Text = "0";
            }
            else
            {
                quantityTb.Text += btnDoubleZero.Text;
            }
        }




        private void btn1_Click(object sender, EventArgs e)
        {
            CheckandFill(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CheckandFill(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CheckandFill(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CheckandFill(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CheckandFill(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CheckandFill(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CheckandFill(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CheckandFill(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CheckandFill(btn9.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            commaUsed = false;
            quantityTb.Text = "0";
        }



        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (quantityTb.Text.Length == 1)
            {
                quantityTb.Text = "0";
                return;
            }
            if (quantityTb.Text.Length > 0)
            {
                quantityTb.Text = quantityTb.Text.Substring(0, quantityTb.Text.Length - 1);
            }
            if (quantityTb.Text.EndsWith(","))
            {
                commaUsed = false;
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



        private void quantityTb_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(quantityTb.Text))
            {
                decimal quantity = decimal.Parse(quantityTb.Text);
                lblRepeater.Text = quantity.ToString(@"###\ ###\ ###\ ###\");
            }
            else lblRepeater.Text = "";

        }



        private void customPanel2_Click(object sender, EventArgs e)
        {
            quantityTb.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal leftMoney = TotalAmount - decimal.Parse(lblActiveSum.Text);
            quantityTb.Text = leftMoney.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}




