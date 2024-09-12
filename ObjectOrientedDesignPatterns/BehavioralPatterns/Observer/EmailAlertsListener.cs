using System.Net.Mail;

namespace BehavioralPatterns.Observer
{
	public class EmailAlertsListener : IEventListener
	{
		private const string FROM = "SomeEmail@gmail.com";
		private const string SERVER = "localhost";
		private readonly string _message;
		private readonly MailMessage _email;

		public EmailAlertsListener(string email, string message)
		{
			_message = message;
			_email = new MailMessage(FROM, email);
		}

		public void Update(string filename)
		{
			_email.Subject = "Using the new SMTP client.";
			_email.Body = $"Using this new feature. Updated file {filename}";
			var client = new SmtpClient(SERVER)
			{
				UseDefaultCredentials = true
			};
			client.Send(_email);
		}
	}
}