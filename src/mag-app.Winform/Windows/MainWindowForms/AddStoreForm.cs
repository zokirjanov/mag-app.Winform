using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Services.StoreService;

namespace mag_app.Winform.Windows
{
    public partial class AddStoreForm : Form
    {
        private readonly StoreService _service;


        public AddStoreForm()
        {
            _service = new StoreService();
            InitializeComponent();
        }



        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(storeNametb.Text))
            {
                StoreViewModel StoreViewModel = new StoreViewModel()
                {
                    StoreName = storeNametb.Text,
                };

                var res = await _service.CreateAsync(StoreViewModel);
                if (res == "true")
                {
                    MainForm.mainParent.marketbtn_Click(sender, e);
                    storeNametb.Text = "";
                    DialogResult dlg = MessageBox.Show("Магазин успешно добавлен \n\nВы хотите добавить еще один?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
