using mag_app.DataAccess.DbContexts;
using mag_app.Service.Dtos.Stores;
using mag_app.Winform.Components;
using mag_app.Winform.Windows;
using System;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Forms;
#nullable disable

namespace mag_app.Winform
{
	public partial class Form1 : Form
	{
		private readonly AppDbContext _dbContext;
        private AddStoreForm _addStore;
        public static Form1 formInstance;
        public Button btn;
        public Panel pnl;

        public Form1(AppDbContext appDbContext)
		{
			_dbContext = appDbContext;
            _addStore = new AddStoreForm(appDbContext);
            InitializeComponent();
            formInstance= this;
            btn = marketbtn;
            pnl = MainPanel;
		}

        public void marketbtn_Click(object sender, EventArgs e)
		{
            formInstance.openChildForm(new MyStoresForm(new AppDbContext())); 
        }
            
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, MenuPanel.ClientRectangle,
               Color.White, 1, ButtonBorderStyle.Solid, // left
               Color.White, 1, ButtonBorderStyle.Solid, // top
               Color.DimGray, 1, ButtonBorderStyle.Solid, // right
               Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}