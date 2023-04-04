using mag_app.Domain.Entities.Categories;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.CategoryService;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Update_Cash_Register : Form
    {

        private CashService _service;
        public Update_Cash_Register()
        {
            _service= new CashService();    
            InitializeComponent();
        }

        private void Update_Cash_Register_Load(object sender, EventArgs e)
        {
            oldName = cashName;
            cashNameTb.Text = cashName;
        }


        string oldName;
        public string cashName { get; set; }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();
            cash.CashName = cashNameTb.Text;

            DialogResult dlg = MessageBox.Show("Хотите отредактировать кассу?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await _service.UpdateAsync(cash, oldName);
                if (res == "true")
                {
                    StoreProductsForm.storeProductParent.openChildForm(new Cash_Register());
                    this.Close();
                }
                else if (res == "false")
                {
                    MessageBox.Show("Что-то пошло не так, нет соответствующей категории");
                }
                else
                {
                    MessageBox.Show(res);
                    cashNameTb.Focus();
                    cashNameTb.SelectAll();
                }
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
