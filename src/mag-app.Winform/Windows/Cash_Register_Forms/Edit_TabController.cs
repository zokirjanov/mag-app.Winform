using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.StoreService;

namespace mag_app.Winform.Windows.Cash_Register_Forms;

public partial class Edit_TabController : Form
{
    TabService _service;
    public Edit_TabController()
    {
        _service = new TabService();
        InitializeComponent();
    }


    private void Edit_TabController_Load(object sender, EventArgs e)
    {
        oldName = TabName;
        tabNameTb.Text = TabName;
    }


    string oldName = "";
    public string TabName { get; set; } = string.Empty;

    private async void updateBtn_Click(object sender, EventArgs e)
    {
        TabController tab = new TabController();
        tab.TabName = tabNameTb.Text;
   

        DialogResult dlg = MessageBox.Show("Хотите отредактировать таб?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        if (dlg == DialogResult.OK)
        {

            var res = await _service.UpdateAsync(tab, oldName);
            if (res == "true")
            {
                
                Cash_Register_Main.cashRegisterMainParent.FillTabs();
                AutoClosingMessageBox.Show("успешно отредактировано", "редактировать", 300);
                this.Close();
            }
            else if (res == "false")
            {
                MessageBox.Show("Что-то пошло не так, нет соответствующей категории");
            }
            else
            {
                MessageBox.Show(res);
                tabNameTb.Focus();
                tabNameTb.SelectAll();
            }
        }
        if (dlg == DialogResult.Cancel)
        {
            this.Close();
        }
    }
}
