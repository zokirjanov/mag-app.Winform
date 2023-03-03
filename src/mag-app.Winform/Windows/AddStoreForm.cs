using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Service;
using mag_app.Service.Services;
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

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(storeNametb.Text) && !string.IsNullOrEmpty(empNumbertb.Text))
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
                    MessageBox.Show("Store added successfully ");
                    storeNametb.Text = "";
                    MyStoresForm myStoresForm = new MyStoresForm(new AppDbContext());
                    myStoresForm.Refresh();

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
