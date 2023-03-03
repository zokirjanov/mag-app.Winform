using mag_app.DataAccess.DbContexts;
using mag_app.Service.Dtos.Stores;
using mag_app.Service.Services;
using mag_app.Winform.Components;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows
{
    public partial class MyStoresForm : Form
    {

        private AppDbContext _dbContex;
        private StoreService _service;

        public MyStoresForm(AppDbContext appDbContext)
        {
            _dbContex = appDbContext;
            _service = new StoreService(appDbContext);
            InitializeComponent();
        }

        private async void MyStoresForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStoreForm form = new AddStoreForm(new DataAccess.DbContexts.AppDbContext());
            form.ShowDialog();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AddItem(string storename, long empCount)
        {
            var w = new storeControl()
            {
                StoreName = storename,
                EmployeeCount = empCount,
            };
            flowLayoutPanel1.Controls.Add(w);
        }

        public async void MyStoresForm_Shown(object sender, EventArgs e)
        {
            var items = await _service.GetAllAsync();
            foreach(var item in items)
            {
                AddItem(item.StoreName, item.EmployeeCount);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, flowLayoutPanel1.ClientRectangle,
              Color.DimGray, 1, ButtonBorderStyle.Solid, // left
              Color.DimGray, 1, ButtonBorderStyle.Solid, // top
              Color.White, 1, ButtonBorderStyle.Solid, // right
              Color.White, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
