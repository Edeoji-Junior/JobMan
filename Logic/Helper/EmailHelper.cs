using Core.Models;
using Core.ViewModel;
using Logic.IHelper;
using Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Helper
{
    public class EmailHelper: IEmailHelper
    {
		private readonly IEmailServices emailServices;
		private readonly IEmailConfiguration _emailConfiguration;

		public EmailHelper(IEmailServices emailServices, IEmailConfiguration emailConfiguration)
		{
			//_emailService = emailService;
			this.emailServices = emailServices;
			_emailConfiguration = emailConfiguration;
		}

		public bool SendVerificationEmail(ApplicationUser user, string linkToClick)
		{
			if (user != null && linkToClick != null)
			{
				string toEmail = user.Email;
				string subject = "Job Man Company";

				var message = "Dear " + user.FirstName + "," + "</br> " +
				 "This is to notify you, that you have been registered successfully with Job Man Company." + "<br/>" +
				 "Kindly click on the button to verify your email <br/> <br/>" +
				 "<button> <a href='" + linkToClick + "'> Verify </a>" + "</button> <br/>" +
				 "or copy the link " + linkToClick + "to a browser to continue. <br/> <br/>" +
				  "Kind regards,<br/>" +
				  "Job Man Company.";

				var isSent = emailServices.SendEmail(toEmail, subject, message);
				if (isSent)
				{
					return true;
				}
			}
			return false;
		}

		public bool SendAdminEmail(SupportViewModel customer)
		{
			if (customer != null)
			{
				string toEmail = _emailConfiguration.AdminEmail;
				string subject = "Contact Message";

				var message = "Dear Admin" + "," + "</br>" +
				 "This is to notify you, that you have a message from Job Man Company."
				 + "</br> " +
				 "Job Man Company.";

				var isSent = emailServices.SendEmail(toEmail, subject, message);
				if (isSent)
				{
					return true;
				}


			}
			return false;
		}
	}
}
