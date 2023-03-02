using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mag_app.Service.Common.Attributes
{
	public class EmailAttribute
	{
		public static string IsValid(string value)
		{
			if (value is null) return ("Email can not be null!");

			Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

			if (regex.Match(value.ToString()!).Success)
				return "true";

			return "Enter correct email!";
		}
	}
}
