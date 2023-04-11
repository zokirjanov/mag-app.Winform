using mag_app.Domain.Constant;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Interfaces.Stores;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Payment : Form
    {
        SalesGlobalService salesGlobal;
        SaleDetailService saleDetail;

        public Payment()
        {
            salesGlobal = new SalesGlobalService();
            saleDetail= new SaleDetailService();
            InitializeComponent();
        }

        public decimal TotalAmount { get; set; }
        public PaymentType Type { get; set; }

        bool commaUsed = false;


        private void Payment_Load(object sender, EventArgs e)
        {
            lblActiveSum.Text = TotalAmount.ToString(@"###\ ###\ ###\ ###\");
            lblTotalSum.Text = TotalAmount.ToString(@"###\ ###\ ###\ ###\") + " сум";
            quantityTb.Text = TotalAmount.ToString();
            quantityTb.Focus();
            dataGridView1.ClearSelection();
        }






        private async void btnPay_Click(object sender, EventArgs e)
        {
            decimal check = decimal.Parse(lblActiveSum.Text);

            if (check == 0)
            {
                bool paymentProcessed = await PreparePaymentInfo();
                if (paymentProcessed)
                {
                    AutoClosingMessageBox.Show("Платеж успешно обработан", "Success", 1000);
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
            decimal card=0;
            decimal cash=0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Терминал")
                {
                    card += Convert.ToDecimal(row.Cells[1].Value);
                }
                else if (row.Cells[0].Value.ToString() == "Наличные")
                {
                    cash += Convert.ToDecimal(row.Cells[1].Value);
                }
                
            }

            SalesGlobalViewModel SaleGlobal = new SalesGlobalViewModel()
            {
                TotalSale = card+cash,
                StoreId = Stores_Form.myStoreFormParent.Id,
                StoreName = Stores_Form.myStoreFormParent.StoreName,
                CashId = Cash_Register_List.cashRegisterParent.Id,
                CashName = Cash_Register_List.cashRegisterParent.CashName,
                PaymentType = Type,
                CashAmount= cash,
                CardAmount= card,
            };


            try
            {
                var sg = await salesGlobal.CreateAsync(SaleGlobal);

                if(sg != null)
                {
                    foreach (Control item in Cash_Register_Main.cashRegisterMainParent.flowLayoutPanel1.Controls)
                    {
                        var uc = (ProductControl)item;

                        SaleDetailsViewModel saleDetails = new SaleDetailsViewModel()
                        {
                            SaleId = sg.Id,
                            ProductId = uc.ProductId,
                            ProductName = uc.ProductName,
                            Quantity= uc.Quantity,
                            Price = uc.TotalCost,
                        };
                        await saleDetail.CreateAsync(saleDetails);
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
            FillTypePayment("Наличные");
            if(Type == PaymentType.Card) Type = PaymentType.MixedPayment;
            else Type = PaymentType.Cash;
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            FillTypePayment("Терминал");
            if (Type == PaymentType.Cash) Type = PaymentType.MixedPayment;
            else Type = PaymentType.Card;
        }



        private void FillTypePayment(string type)
        {
            decimal cash = decimal.Parse(quantityTb.Text);
            decimal restCash = decimal.Parse(lblActiveSum.Text);

            if (cash <= restCash && cash != 0)
            {
                dataGridView1.Rows.Add(type, cash);
                dataGridView1.ClearSelection();
                restCash -= cash;
                lblActiveSum.Text = restCash.ToString();
                quantityTb.Text = restCash.ToString();
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
            if(quantityTb.Text.Length == 1)
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
            Color.Black, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.Transparent, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
            Color.Transparent, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.Transparent, 1, ButtonBorderStyle.Solid, // right
            Color.Black, 1, ButtonBorderStyle.Solid);// bottom
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
                decimal cash = decimal.Parse(quantityTb.Text);
                decimal restCash = decimal.Parse(lblActiveSum.Text);

                if (cash <= restCash)
                {
                    lblWarning.Text = "";
                }
                else lblWarning.Text = "недостаточно суммы";
            }
        }
    }
}
