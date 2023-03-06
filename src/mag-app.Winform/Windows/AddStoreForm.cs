using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Service;
using mag_app.Service.Services;
using mag_app.Winform.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStoreForm_Load(object sender, EventArgs e)
        {
            empNumbertb.Maximum = decimal.MaxValue;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(storeNametb.Text))
            {
                AddStoreDto storeDto = new AddStoreDto()
                {
                    StoreName = storeNametb.Text,
                    EmployeeCount = int.Parse(empNumbertb.Text),
                    EmployeeID = IdentitySingelton.GetInstance().EmployeeId
                };

                var res = await _service.CreateAsync(storeDto);
                if (res == "true")
                {
                    Form1.formInstance.marketbtn_Click(sender,e);
					storeNametb.Text = "";
                    DialogResult dlg = MessageBox.Show("Store added successfully \n\nDo you want to add another one?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg == DialogResult.OK)
                    {
						//do nothing
					}
                    if (dlg == DialogResult.Cancel)
                    {
                        Form1.formInstance.pnl.Controls.Clear();
                        Form1.formInstance.marketbtn_Click(sender, e);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Login Already Exists, try another name");
                    storeNametb.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
