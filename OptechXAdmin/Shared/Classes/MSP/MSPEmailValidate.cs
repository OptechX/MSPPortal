using System;
using System.ComponentModel.DataAnnotations;

namespace OptechXAdmin.Shared.Classes.MSP
{
	public class MSPEmailValidate
	{
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}

