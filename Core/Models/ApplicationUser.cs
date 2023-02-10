using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
	public class ApplicationUser:IdentityUser
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? ConfirmPassword { get; set; }
		public string? Address { get; set; }
		public string? MiddleName { get; set; }
		public DateTime Activite { get; set; }
		public bool Deleted { get; set; }
		public bool RememberMe { get; set; }
		public bool IsDeactivated { get; set; }


	}
}
