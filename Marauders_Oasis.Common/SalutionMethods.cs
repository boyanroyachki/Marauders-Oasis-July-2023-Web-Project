using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marauders_Oasis.Common
{
	public static class SalutionMethods
	{
		//Methods for the entire salution.
		//This is a static class, so it can be called from anywhere in the program, making things easier.
		public static string GetNameFromEmail(string? email)
		{
			if (email == null) return string.Empty;
			else return email.Split('@').FirstOrDefault() ?? string.Empty;
		}
	}
}
