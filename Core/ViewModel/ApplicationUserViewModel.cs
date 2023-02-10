using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
	public class ApplicationUserViewModel
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? ConfirmPassword { get; set; }
		public string? Password { get; set; }
		public string? Email { get; set; }
		public string? Address { get; set; }
		public string? MiddleName { get; set; }
		public DateTime Activite { get; set; }
		public bool Deleted { get; set; }
		public bool RememberMe { get; set; }
		public string? UserName { get; set; }
		public bool IsDeactivated { get; set; }
	}
}
