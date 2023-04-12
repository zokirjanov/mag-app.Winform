using mag_app.Domain.Constant;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.AllProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Payment : Form
    {
        SalesGlobalService salesGlobal;
        SaleDetailService saleDetail;
        AllProductService productService;

        public Payment()
        {
            salesGlobal = new SalesGlobalService();
            saleDetail = new SaleDetailService();
            productService = new AllProductService();
            InitializeComponent();
        }

        public decimal TotalAmount { get; set; }
        bool commaUsed = false;




        private void Payment_Load(object sender, EventArgs e)
        {

            lblActiveSum.Text = TotalAmount.ToString(@"###\ ###\ ###\ ###\");
            totalSum.Text = TotalAmount.ToString(@"###\ ###\ ###\ ###\");

        }






        private async void btnPay_Click(object sender, EventArgs e)
        {
            decimal check = decimal.Parse(lblActiveSum.Text);

            if (check == 0 && btnPay.BackColor == Color.Lime)
            {
                bool paymentProcessed = await PreparePaymentInfo();
              
                if (paymentProcessed)
                {
                    AutoClosingMessageBox.Show("Платеж успешно обработан", "Success", 1000);
                    Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls.Clear();
                    this.Close();
                }
                else
                {
                    AutoClosingMessageBox.Show("Ошибка обработки платежа", "Error", 1000);
                }
            }
            else MessageBox.Show("торговля ведется не корректно");
        }






        private async Task<bool> PreparePaymentInfo()
        {
            decimal card = decimal.Parse(lblCard.Text);
            decimal cash = decimal.Parse(lblCash.Text);
            PaymentType type = default(PaymentType);



            if(card != 0)      type= PaymentType.Card;
            else if(cash != 0) type= PaymentType.Cash;
            else               type= PaymentType.MixedPayment;



            SalesGlobalViewModel SaleGlobal = new SalesGlobalViewModel()
            {
                TotalSale = card + cash,
                StoreId = Stores_Form.myStoreFormParent.Id,
                StoreName = Stores_Form.myStoreFormParent.StoreName,
                CashId = Cash_Register_List.cashRegisterParent.Id,
                CashName = Cash_Register_List.cashRegisterParent.CashName,
                PaymentType = type,
                CashAmount = cash,
                CardAmount = card,
            };



            try
            {
                var sg = await salesGlobal.CreateAsync(SaleGlobal);

                if (sg != null)
                {
                    foreach (Control item in Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls)
                    {
                        var uc = (ProductControl)item;

                        SaleDetailsViewModel saleDetails = new SaleDetailsViewModel()
                        {
                            SaleId = sg.Id,
                            ProductId = uc.ProductId,
                            ProductName = uc.Title,
                            Quantity = uc.Quantity,
                            Price = uc.TotalCost,
                        };
                        var sd = await saleDetail.CreateAsync(saleDetails);

                        await productService.UpdateAsync(sd.ProductId, uc.Quantity);
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








        private void btnCash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantityTb.Text))
            {
                return;
            }


            decimal cash = decimal.Parse(quantityTb.Text);
            decimal restCash = decimal.Parse(lblActiveSum.Text);

            if (cash <= restCash && cash != 0)
            {
                restCash -= cash;
                lblActiveSum.Text = restCash.ToString();
                lblCash.Text = cash.ToString(@"###\ ###\ ###\ ###\");
                quantityTb.Text = restCash.ToString();
            }

            decimal total = decimal.Parse(lblCard.Text)+decimal.Parse(lblCash.Text);
            if(total == TotalAmount && restCash == 0)
            {
                btnPay.BackColor= Color.Lime;
            }
        }




        private void btnCard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantityTb.Text))
            {
                return;
            }

            decimal cash = decimal.Parse(quantityTb.Text);
            decimal restCash = decimal.Parse(lblActiveSum.Text);

            if (cash <= restCash && cash != 0)
            {
                restCash -= cash;
                lblActiveSum.Text = restCash.ToString();
                lblCard.Text = cash.ToString(@"###\ ###\ ###\ ###\");
                quantityTb.Text = restCash.ToString();
            }

            decimal total = decimal.Parse(lblCard.Text) + decimal.Parse(lblCash.Text);
            if (total == TotalAmount && restCash == 0)
            {
                btnPay.BackColor = Color.Lime;
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

                decimal cash = decimal.Parse(quantityTb.Text);
                decimal restCash = decimal.Parse(lblActiveSum.Text);

                if (cash <= restCash)
                {
                    lblWarning.Text = "";
                }
                else lblWarning.Text = "недостаточно суммa";
            }
            else lblRepeater.Text = "";

        }



        private void customPanel2_Click(object sender, EventArgs e)
        {
            quantityTb.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantityTb.Text = TotalAmount.ToString();
        }

    }
}
