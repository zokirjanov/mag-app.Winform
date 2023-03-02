using mag_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Domain.Entities.Users;

public class User : Auditable
{
	public string Login { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string PasswordHash { get; set; } = string.Empty;
	public string Salt { get; set; } = string.Empty;

}
