using mag_app.DataAccess.DbContexts;
using mag_app.Domain.Entities.Stores;
using mag_app.Service.Services;
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
    public partial class UpdateForm : Form
    {
        private StoreService _service;
        public UpdateForm(AppDbContext appDbContext)
        {
            InitializeComponent();
            _service = new StoreService(appDbContext);
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            oldName = storeName;
            storeNameTb.Text= storeName;
            empCounttb.Text = empCount.ToString();
            empCounttb.Maximum = decimal.MaxValue;
        }


        string oldName;
        public string storeName { get; set; }
        public long empCount { get; set; }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.StoreName= storeNameTb.Text;
            store.EmployeeCount=  long.Parse(empCounttb.Text);


            DialogResult dlg = MessageBox.Show("Do you want to Update store?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = _service.UpdateAsync(store, oldName);
                this.Close();
                Form1.formInstance.pnl.Controls.Clear();
                Form1.formInstance.marketbtn_Click(sender, e);
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        
    }
}
