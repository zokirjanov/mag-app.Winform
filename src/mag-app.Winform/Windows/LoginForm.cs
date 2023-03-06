using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Attributes;
using mag_app.Service.Dtos.Accounts;
using mag_app.Service.Service;
using Microsoft.Data.Sqlite;
using System.ComponentModel;

namespace mag_app.Winform.Windows
{
	public partial class LoginForm : Form
	{
		private readonly AppDbContext _dbContex;
		private readonly UserService _service;
		public static LoginForm LoginInstance;
		public TextBox logintxb;
		public TextBox passwordtxb;

		public LoginForm(AppDbContext appDbContext)	
		{
			InitializeComponent();
            _dbContex = appDbContext;
            _service = new UserService(appDbContext);
			LoginInstance = this;
			logintxb = loginlogin;
			passwordtxb = loginPass;
        }

		private void LoginForm_Load(object sender, EventArgs e)
		{
			lastuser();
		}

		private void lastuser()
		{
            string path = "database.txt";
            var result = File.ReadAllText(path);
            string[] tokens = result.Split(':');
            loginlogin.Text = tokens[0];
            loginPass.Text = tokens[1];
        }

		private void loginPassShow_Click(object sender, EventArgs e)
		{
			if (loginPass.UseSystemPasswordChar == PasswordPropertyTextAttribute.No.Password)
			{
				loginPassShow.Image = Image.FromFile("D:\\shohrux\\mag-app\\src\\mag-app.Winform\\Resources\\view.png");

                loginPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
			}
			else
			{
				loginPass.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
				loginPassShow.Image = Image.FromFile("D:\\shohrux\\mag-app\\src\\mag-app.Winform\\Resources\\hide (1).png");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RegisterForm register = new RegisterForm(_dbContex);
			this.Hide();
			register.Show();
		}

		private async void registerBtn_Click(object sender, EventArgs e)
		{

			if (!string.IsNullOrEmpty(loginlogin.Text) && !string.IsNullOrEmpty(loginPass.Text)
			  && loginLoginerror.Text == "")
			{
				LoginDto accountLoginDto = new LoginDto() { Login = loginlogin.Text, Password = loginPass.Text };
				var res = await _service.AccountLoginAsync(accountLoginDto);

				if (res == "False")
				{
					if (rememberMe.Checked)
					{
						var remember = await _service.AccountRememberMeAsync(accountLoginDto);
					}
					else
					{
						_service.AccountLogout();
					}
				}
				else if (res == "True")
				{
					if (rememberMe.Checked)
					{
						var remember = await _service.AccountRememberMeAsync(accountLoginDto);                    
                    }
					else
					{
						_service.AccountLogout();
					}
					Form1 mainForm = new Form1(_dbContex);
					this.Hide();
					mainForm.ShowDialog();

				}
				else MessageBox.Show(res);
			}
		}

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			Application.Exit();
        }

        private void loginlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}