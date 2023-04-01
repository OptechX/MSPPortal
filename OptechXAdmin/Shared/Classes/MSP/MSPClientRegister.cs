using System;
using System.ComponentModel.DataAnnotations;

namespace OptechXAdmin.Shared.Classes.MSP
{
    public class MSPClientRegister
	{
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

		[Required]
		public string MSPCode { get; set; } = string.Empty;

		[Required]
		[StringLength(100, MinimumLength = 1, ErrorMessage = "Must enter business name")]
		public string BusinessName { get; set; } = string.Empty;
		public string ContactName { get; set; } = string.Empty;
		public string TaxId { get; set; } = string.Empty;

		public string Phone { get; set; } = string.Empty;

		public string AddressLine1 { get; set; } = string.Empty;
		public string AddressLine2 { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public string State { get; set; } = string.Empty;
		public string PostCode { get; set; } = string.Empty;
		public string Country { get; set; } = string.Empty;

		public string Plan { get; set; } = string.Empty;
        public string CouponCode { get; set; } = string.Empty;

        [Range(0,30, ErrorMessage = "Between 0-30 days only")]
		public int TrialPeriodDays { get; set; } = 0;

		public DateTime AccountCreated { get; } = DateTime.UtcNow;
		

		[Range(typeof(bool), "true", "true", ErrorMessage = "Acceptance of Terms and Conditions required.")]
		public bool isAcceptTermsConditions { get; set; } = false;
    }
}

