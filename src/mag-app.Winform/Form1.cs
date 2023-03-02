using mag_app.DataAccess.DbContexts;
using mag_app.Service.Dtos.Stores;
using mag_app.Winform.Components;
using mag_app.Winform.Windows;
using System;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace mag_app.Winform
{
	public partial class Form1 : Form
	{
		private readonly AppDbContext _dbContext;

		public Form1(AppDbContext appDbContext)
		{
			_dbContext = appDbContext;
			InitializeComponent();
		}
        


        private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void marketbtn_Click(object sender, EventArgs e)
		{
            using (var res = new AppDbContext())
            {
                var blogs = _dbContext.Stores.ToList();
            }

            foreach (var items in MainFlowPanel.Controls)
            {
                var wdg = (StoreBrick)items;
                wdg.Visible = true;
            }
        }


		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStoreForm(new AppDbContext()));
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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
    }
}