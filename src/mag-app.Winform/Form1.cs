using mag_app.DataAccess.DbContexts;
using mag_app.Winform.Components;
using System;

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

        StorePanel storePanel;
		AddSection addSection;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void marketbtn_Click(object sender, EventArgs e)
		{
			storePanel = new StorePanel(this);
			MainFlowPanel.Controls.Clear();
			MainFlowPanel.Controls.Add(storePanel);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            addSection = new AddSection(this);
            MainFlowPanel.Controls.Clear();
            MainFlowPanel.Controls.Add(addSection);
        }
    }
}