using System;
using System.ComponentModel.DataAnnotations;

namespace OptechXAdmin.Shared
{
	public class UserLogin
	{
		[EmailAddress]
		[Required(ErrorMessage = "Username required")]
		public string Username { get; set; } = string.Empty;

		[Required(ErrorMessage = "Password required")]
		public string Password { get; set; } = string.Empty;
	}
}

