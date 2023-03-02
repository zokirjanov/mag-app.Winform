using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mag_app.Service.Common.Attributes
{
	public class StrongPasswordAttribute
	{
		public static string IsValid(string value)
		{
			if (String.IsNullOrEmpty(value)) return "Password can not be null!";
			else
			{
				string password = value.ToString()!;
				if (password.Length < 8)
					return "Password must be at least 8 characters!";
				else if (password.Length > 50)
					return "Password must be less than 50 characters!";
				var result = IsStrong(password);

				if (result.IsValid is false) return result.Message;
				return "true";
			}
		}

		public static (bool IsValid, string Message) IsStrong(string password)
		{
			bool isDigit = password.Any(x => char.IsDigit(x));
			bool isLower = password.Any(x => char.IsLower(x));
			bool isUpper = password.Any(x => char.IsUpper(x));
			bool isSymbol = password.Any(x => "!@#$%^&*_".Contains(x));
			if (isSymbol)
				return (IsValid: false, Message: "Invalid password! please do not use numeric symbols");
			if (!isLower)
				return (IsValid: false, Message: "Password must be at least one lower letter!");
			if (!isUpper)
				return (IsValid: false, Message: "Password must be at least one upper letter!");
			if (!isDigit)
				return (IsValid: false, Message: "Password must be at least one digit!");
		return (IsValid: true, Message: "Password is strong");
		}
	}
}
