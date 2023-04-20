using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Products;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Products;
using mag_app.Service.ViewModels.Stores;
using Microsoft.EntityFrameworkCore;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Return_Product : Form
{
    SaleGlobalService _service;
    ReturnProductService _returnService;

    public Return_Product()
    {
        _service = new SaleGlobalService();
        _returnService = new ReturnProductService();
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
        dataGridView1.Rows.Clear();
        var products = await _service.GetAllAsync(Id);

        foreach (var i in products)
        {
            saleGlobalViewModelBindingSource.Add(new SaleGlobalViewModel()
            {
                Id = i.Id,
                Barcode = i.Barcode,
                Category = i.Category,
                SubCategory = i.SubCategory,
                ProductName = i.ProductName,
                Quantity = i.Quantity,
                TotalPrice = i.TotalPrice,
                Price = i.Price,
                DiscountPrice = i.DiscountPrice,
                IsReturned = i.IsReturned,
            });
        }
        CompareList();
        dataGridView1.ClearSelection();
    }


    private async void CompareList()
    {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.Cells[10].Value != null)
            {
                row.DefaultCellStyle.ForeColor = Color.DarkGray;
            }
        }
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
        if (e.ColumnIndex == 6 && e.RowIndex >= 0)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            MaxQuantity = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            dataGridView1.BeginEdit(true);
        }
    }




    private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
        if (dataGridView1.CurrentCell.ColumnIndex == 6)
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
        if (e.ColumnIndex == 6 && e.RowIndex >= 0)
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
                    MessageBox.Show($"Новое значение не может быть больше старого  ({oldDecimalValue})");
                    cell.Style.ForeColor = Color.Red;
                }
            }
        }
    }





    private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 6 && e.RowIndex >= 0)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.Style.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;

            if (Convert.ToDecimal(cell.Value) != 0 && Convert.ToDecimal(cell.Value) != MaxQuantity)
            {
                DataGridViewCheckBoxCell checkBoxCell = dataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = true;
                }
            }

        }
    }






    private async void button1_Click(object sender, EventArgs e)
    {
        DialogResult dlg = MessageBox.Show("Хотите возврат продукты?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        if (dlg == DialogResult.OK)
        {
            ReturnAll();
        }
        if (dlg == DialogResult.Cancel)
        {
            this.Close();
        }
    }






    public decimal totalReturn = 0;
    private async void ReturnAll()
    {
        List<DataGridViewRow> selectedRows = dataGridView1.Rows.Cast<DataGridViewRow>()
            .Where(row => (row.Cells[0] as DataGridViewCheckBoxCell)?.Value as bool? == true)
            .ToList();

        int count = selectedRows.Count;
        int cnt = 0;


        foreach (DataGridViewRow row in selectedRows)
        {
            if (Convert.ToDecimal(row.Cells[5].Value) == 0)
            {
                return;
            }

            ReturnProductViewModel product = new ReturnProductViewModel()
            {
                Barcode = row.Cells[1].Value.ToString(),
                Category = row.Cells[2].Value.ToString(),
                SubCastegory = row.Cells[3].Value.ToString(),
                SaleGlobalId = Convert.ToInt64(row.Cells[9].Value),
                SgName = row.Cells[4].Value.ToString(),
                SgProductPrice = Convert.ToInt64(row.Cells[5].Value),
                Return = Convert.ToDecimal(row.Cells[6].Value),
                ReturnedPrice = (Convert.ToDecimal(row.Cells[5].Value) * Convert.ToDecimal(row.Cells[6].Value)),
                ReturnDate = TimeHelper.CurrentTime()
            };

            var result = await _returnService.CreateProductAsync(product);
            if (result != null)
            {
                totalReturn += result.ReturnedPrice;
                await Return_SaleGlobalAsync(result);
                cnt++;
            }
        }

        if (cnt == count)
        {
            MessageBox.Show($"Товары были успешно возвращены.\nОбщая сумма возврата: {totalReturn}", "Возврат товаров", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Return_Check.Instance.dataGridView1.Rows.Clear();
            Return_Check.Instance.FillData();
            this.Close();
        }
    }




    private async Task Return_SaleGlobalAsync(ReturnProduct product)
    {
        using (var db = new AppDbContext())
        {
            var result = await db.SaleGlobal.FirstOrDefaultAsync(x => x.Id == product.SaleGlobalId);
            int res = 0;
            if (result != null)
            {
                decimal cnt = result.Quantity - product.Quantity;
                result.Quantity = cnt;
                result.TotalPrice = cnt * result.Price;
                result.IsReturned = product.Id;

                res = await db.SaveChangesAsync();
            }
            if (res != 0)
            {
                await Return_SaleDetailAsync(result);
                await Return_TabProductAsync(result.ProductId, product.Quantity);

            }
        }
    }






    private async Task Return_SaleDetailAsync(SaleGlobal product)
    {
        using (var db = new AppDbContext())
        {
            var result = await db.SaleDetails.FirstOrDefaultAsync(x => x.Id == product.SaleId);

            if (result != null)
            {
                result.TotalSalePrice -= totalReturn;
                result.IsReturned = product.IsReturned;
                await db.SaveChangesAsync();
            }
        }
    }






    private async Task Return_TabProductAsync(long id, decimal quantity)
    {
        using (var db = new AppDbContext())
        {
            var result = await db.AllProducts.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                result.Quantity += quantity;
                await db.SaveChangesAsync();
            }
        }
    }

    string filterField = "ProductName";
    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        var filterText = textBox1.Text;
        saleGlobalViewModelBindingSource.Filter = string.Format("[{0}] LIKE '%{1}%'", "ProductName", filterText);
    }
}
