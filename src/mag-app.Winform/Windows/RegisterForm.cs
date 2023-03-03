using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Attributes;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows
{
	public partial class RegisterForm : Form
	{

		private readonly AppDbContext _dbContex;
		private readonly UserService _service;
		public RegisterForm(AppDbContext appDbContext)
		{
			_dbContex = appDbContext;
			_service = new UserService(appDbContext);
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void passwordShowbt_Click(object sender, EventArgs e)
		{
			if (registerPasswordtb.UseSystemPasswordChar == PasswordPropertyTextAttribute.No.Password)
			{
				passwordShowbt.Image = Image.FromFile("D:\\shohrux\\mag-app\\src\\mag-app.Winform\\Resources\\view.png");
				registerPasswordtb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
			}
			else
			{
				registerPasswordtb.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
				passwordShowbt.Image = Image.FromFile("D:\\shohrux\\mag-app\\src\\mag-app.Winform\\Resources\\hide (1).png");
			}
		}

		private void confirmShowbt_Click(object sender, EventArgs e)
		{
			if (registerConfirmtb.UseSystemPasswordChar == PasswordPropertyTextAttribute.No.Password)
			{
				registerConfirmtb.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
				confirmShowbt.Image = Image.FromFile("D:\\shohrux\\mag-app\\src\\mag-app.Winform\\Resources\\view.png");

			}
			else
			{
				registerConfirmtb.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
				confirmShowbt.Image = Image.FromFile("D:\\shohrux\\mag-app\\src\\mag-app.Winform\\Resources\\hide (1).png");
			}
		}

		private async void registerBtn_Click(object sender, EventArgs e)
		{
			if (passwordlabel.Text == "" && emaillabel.Text == "" && confirmlabel.Text == ""
				  && !string.IsNullOrEmpty(registerConfirmtb.Text) && !string.IsNullOrEmpty(registerLogintb.Text) && !string.IsNullOrEmpty(registerPasswordtb.Text))
			{
				RegisterDto registerDto = new RegisterDto()
				{
					Email = registerEmailtb.Text,
					Login = registerLogintb.Text,
					Password = registerPasswordtb.Text,
				};
				var res = await _service.AccountRegisterAsync(registerDto);
				if (res == "true")
				{
					MessageBox.Show("You are successfully registered");
					LoginForm login = new LoginForm(_dbContex);
					
					this.Hide();
					login.ShowDialog();
				}
				else 
				{
					MessageBox.Show("Login Already Exists, try another name");
					registerLogintb.Text = "";
				}

			}
		}

		private void registerLogintb_TextChanged(object sender, EventArgs e)
		{
			var loginAttr = LoginAttributes.IsValid(registerLogintb.Text);
			if(loginAttr == "true")
			{
				loginlabel.Text = "";
			}
			else
			{
				loginlabel.Text = loginAttr.ToString();
			}
		}

		private void registerEmailtb_TextChanged(object sender, EventArgs e)
		{
			var emailAttribute = EmailAttribute.IsValid(registerEmailtb.Text);
			if (emailAttribute == "true")
				emaillabel.Text = "";
			else
			{
				emaillabel.Text = emailAttribute.ToString();
			}
		}

		private void registerPasswordtb_TextChanged(object sender, EventArgs e)
		{
			var passwordAttribute = StrongPasswordAttribute.IsValid(registerPasswordtb.Text);
			if (passwordAttribute == "true")
				passwordlabel.Text = "";
			else
			{
				passwordlabel.Text = passwordAttribute.ToString();

			}

		}

		private void registerConfirmtb_TextChanged(object sender, EventArgs e)
		{
			if (!(registerPasswordtb.Text == registerConfirmtb.Text))
			{
				confirmlabel.Text = "Not confirmed";
			}
			else
			{
				confirmlabel.Text = "";
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			this.Hide();
			LoginForm login = new LoginForm(_dbContex);
			login.ShowDialog();
        }
    }
}
