﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public string Name { get; set; }


        private void button13_Click(object sender, EventArgs e)
        {
            quantityTb.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button12.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button11.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button10.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button9.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button8.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button7.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button6.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button5.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button4.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button14.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantityTb.Text += button1.Text;

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
            decimal value = decimal.Parse(quantityTb.Text);
            value++;
            quantityTb.Text = value.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal value = decimal.Parse(quantityTb.Text);
            value--;
            if(value > 0) 
            {
                quantityTb.Text = value.ToString();
            }
            else
            {
                quantityTb.Text = 0.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (quantityTb.Text.Length > 0)
            {
                quantityTb.Text = quantityTb.Text.Substring(0, quantityTb.Text.Length - 1);
            }
        }


    }
}