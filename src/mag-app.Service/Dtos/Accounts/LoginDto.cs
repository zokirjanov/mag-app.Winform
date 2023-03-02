using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Dtos.Accounts
{
	public class LoginDto
	{
		public string Login { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
	}
}
