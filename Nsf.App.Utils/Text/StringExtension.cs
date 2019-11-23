using System;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Nsf.App.Utils
{
	public static class StringExtension
	{
		public static bool IsValidEmail(this string email)
		{
			try
			{
				MailAddress m = new MailAddress(email);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public static bool IsValidPhone(this string phone)
		{
			var regex = new Regex(@"(?:^\(\d{2}\)\s)[9]?[1-9]\d{3}[-]\d{4}$", RegexOptions.Compiled);
			return regex.IsMatch(phone);
		}

		public static bool IsValidCpf(this string cpf)
		{
			var regex = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", RegexOptions.Compiled);
			return regex.IsMatch(cpf);
		}

        public static bool IsValidCep(this string cep)
		{
			var regex = new Regex(@"^\d{5}-\d{3}$", RegexOptions.Compiled);
			return regex.IsMatch(cep);
		}

		public static string Numberfy(this string number)
		{
			string pattern = @"\d";

			var sb = new StringBuilder();

			foreach (var match in Regex.Matches(number, pattern))
				sb.Append(match);

			return sb.ToString();
		}

		public static string RemoveSpecial(this string s)
		{
			var sb = new StringBuilder();
			sb.Append(s.ToUpper().Trim());

			sb.Replace(".", string.Empty);

			sb.Replace(".", string.Empty);
			sb.Replace(",", string.Empty);
			sb.Replace(":", string.Empty);
			sb.Replace("*", string.Empty);
			sb.Replace("-", string.Empty);

			return sb.ToString();
		}
	}
}