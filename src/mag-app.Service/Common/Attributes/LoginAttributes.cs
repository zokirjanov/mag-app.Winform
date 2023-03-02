using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mag_app.Service.Common.Attributes;

public class LoginAttributes
{
	public static string IsValid(string value)
	{
		var hasMinimum8Chars = new Regex(@".{8,50}");
		var checkSymbols = new Regex(@"[^A-Za-z0-9]");

		if (value == null) return ("Login can not be null!");

		if (value == "")
		{
			return "";
		}
		else if (checkSymbols.IsMatch(value))
		{
			return "Invalid login, do not use numerical symbols or space";
		}
		else if (!hasMinimum8Chars.IsMatch(value))
		{
			return "Login should not be less than 8 charcters";
		}
		
		else return "";
	}
}
