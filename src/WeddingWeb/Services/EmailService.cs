using Microsoft.Extensions.Configuration;
using SendGrid;
using System.Net;
using System.Threading.Tasks;
using WeddingWeb.DTO;

namespace WeddingWeb.Services
{
	public class EmailService
	{
		private readonly SendGridClient _client;

		public EmailService(IConfiguration configuration)
		{
			_client = new SendGridClient(configuration["SEND-GRID-API-KEY"]);
		}

		public async Task<HttpStatusCode> SendEmail(EmailDTO emailDto)
		{
			var email = EmailDTO.MapFromDto(emailDto);
			var message = email.CreateSendGridMessage();
			var response = await _client.SendEmailAsync(message);
			return response.StatusCode;
		}
	}
}
