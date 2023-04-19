﻿using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using System.Threading.Tasks.Dataflow;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Return_Product : Form
{
    SaleGlobalService _service;

    public Return_Product()
    {
        _service = new SaleGlobalService();
        InitializeComponent();
    }




    private void Return_Product_Load(object sender, EventArgs e)
    {
        FillData();
        dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Turquoise;
        dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

    }


    public long Id { get; set; }
    public decimal MaxQuantity { get; set; }



    public async void FillData()
    {
        saleGlobalViewModelBindingSource.Clear();
        var products = await _service.GetAllAsync(Id);

        foreach (var i in products)
        {
            saleGlobalViewModelBindingSource.Add(new SaleGlobalViewModel()
            {
                Barcode = i.Barcode,
                Category = i.Category,
                SubCategory = i.SubCategory,
                ProductName = i.ProductName,
                Quantity = i.Quantity,
                Price = i.Price,
                DiscountPrice = i.DiscountPrice,
            });
        }
        dataGridView1.ClearSelection();
    }





    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            DataGridViewCheckBoxCell checkboxCell = row.Cells[0] as DataGridViewCheckBoxCell;
            if (checkboxCell != null)
            {
                checkboxCell.Value = checkBox1.Checked;
            }
        }
    }




    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 5 && e.RowIndex >= 0) 
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            MaxQuantity= Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            dataGridView1.BeginEdit(true); 
        }
    }




    private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
        if (dataGridView1.CurrentCell.ColumnIndex == 5)
        {
            TextBox textBox = e.Control as TextBox;

            if (textBox != null)
            {
                textBox.KeyPress -= textBox_KeyPress;
                textBox.KeyPress += textBox_KeyPress;
            }
        }
    }




    private void textBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }

        TextBox textBox = sender as TextBox;
        if (textBox != null && e.KeyChar == '.')
        {
            if (textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }




    private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
        if (e.ColumnIndex == 5 && e.RowIndex >= 0)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string oldValue = cell.Value != null ? cell.Value.ToString() : "";
        
            string newValue = e.FormattedValue.ToString();

            decimal oldDecimalValue, newDecimalValue;

            if (decimal.TryParse(oldValue, out oldDecimalValue) && decimal.TryParse(newValue, out newDecimalValue))
            {
                if (newDecimalValue > oldDecimalValue)
                {
                    e.Cancel = true;
                    MessageBox.Show($"Новое значение не может быть больше старого  ({MaxQuantity})");
                    cell.Style.ForeColor = Color.Red;
                }
            }
        }
    }




    private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 5 && e.RowIndex >= 0)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.Style.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;

            if (!Convert.IsDBNull(cell.Value) && Convert.ToDecimal(cell.Value) != MaxQuantity)
            {
                DataGridViewCheckBoxCell checkBoxCell = dataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = true;
                }
            }
        }

    }
}