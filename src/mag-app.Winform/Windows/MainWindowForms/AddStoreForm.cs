using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Services.StoreService;

namespace mag_app.Winform.Windows
{
    public partial class AddStoreForm : Form
    {
        private readonly AppDbContext _dbContex;
        private readonly StoreService _service;

        public AddStoreForm(AppDbContext appDbContext)
        {
            _dbContex = appDbContext;
            _service = new StoreService(appDbContext);
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(storeNametb.Text))
            {
                AddStoreDto storeDto = new AddStoreDto()
                {
                    StoreName = storeNametb.Text,
                    EmployeeID = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateAsync(storeDto);
                if (res == "true")
                {
                    MainForm.mainParent.marketbtn_Click(sender, e);
                    storeNametb.Text = "";
                    DialogResult dlg = MessageBox.Show("Store added successfully \n\nDo you want to add another one?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
