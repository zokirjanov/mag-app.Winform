using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Add_Cash_Register : Form
    {

        private readonly CashService _service;
        public Add_Cash_Register()
        {
            _service = new CashService();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(storeNametb.Text))
            {
                CashViewModel cashViewModel = new CashViewModel()
                {
                    CashName = storeNametb.Text,
                    StoreId = Stores_Form.myStoreFormParent.Id,
                    StoreName = Stores_Form.myStoreFormParent.Name
                };

                var res = await _service.CreateAsync(cashViewModel);
                if (res == "true")
                {
                    Store_Product_Form.storeProductParent.openChildForm(new Cash_Register_List());
                    storeNametb.Text = "";
                    DialogResult dlg = MessageBox.Show("Касса успешно добавлен \n\nВы хотите добавить еще один?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        storeNametb.Focus();
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(res);
                    storeNametb.Text = "";
                }
            }
        }
    }
}
