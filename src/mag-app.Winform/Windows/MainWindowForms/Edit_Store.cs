using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Common.Attributes;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.StoreService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows
{
    public partial class Edit_Store : Form
    {
        private StoreService _service;
        public Edit_Store()
        {
            InitializeComponent();
            _service = new StoreService();
        }


        private void UpdateForm_Load(object sender, EventArgs e)
        {
            oldName = storeName;
            storeNameTb.Text= storeName;
        }



        string oldName;
        public string storeName { get; set; }



        private async void updateBtn_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.StoreName= storeNameTb.Text;

            DialogResult dlg = MessageBox.Show("Хотите отредактировать магазин?", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = await _service.UpdateAsync(store, oldName);
                if (res == "true")
                {
                    this.Close();
                    AutoClosingMessageBox.Show("успешно отредактировано", "редактировать", 300);
                    MainForm.mainParent.pnl.Controls.Clear();
                    MainForm.mainParent.marketbtn_Click(sender, e);
                }
                else if(res == "false")
                {
                    MessageBox.Show("Что-то пошло не так, нет подходящего магазина");
                }
                else
                {
                    MessageBox.Show(res);
                    storeNameTb.Focus();
                    storeNameTb.SelectAll();
                }
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
