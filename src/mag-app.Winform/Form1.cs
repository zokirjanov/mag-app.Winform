using mag_app.DataAccess.DbContexts;
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

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}