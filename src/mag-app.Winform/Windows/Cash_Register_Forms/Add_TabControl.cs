using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Services.StoreService;
using mag_app.Service.ViewModels.Stores;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Product_Forms;
using System.Security.Cryptography.X509Certificates;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Add_TabControl : Form
    {
        TabService _service;
        public Add_TabControl()
        {
            _service= new TabService();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tabNameTb.Text))
            {
                TabController tab = new TabController()
                {
                    TabName = tabNameTb.Text,
                };

                var res = await _service.CreateAsync(tab);
                if (res == "true")
                {
                    tabNameTb.Text = "";
                    DialogResult dlg = MessageBox.Show("Таб успешно добавлен \n\nВы хотите добавить еще один?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
                        tabNameTb.Focus();
                    }
                    if (dlg == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(res);
                    tabNameTb.Text = "";
                }
            }
        }

        private void Add_TabControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cash_Register_Main.cashRegisterMainParent.CreateControl();
        }
    }
}
