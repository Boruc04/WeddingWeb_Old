using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using WeddingWeb.DTO;
using WeddingWeb.Services;

namespace WeddingWeb.Controllers
{
	[ApiController]
	[ApiVersion("1.0")]
	[Route("api/email")]
	[Produces("application/json")]
	public class EmailController : ControllerBase
	{
		private readonly EmailService _emailService;

		public EmailController(IConfiguration configuration)
		{
			_emailService = new EmailService(configuration);
		}

		/// <summary>
		/// Validate and send an email.
		/// </summary>
		/// <param name="email"></param>
		[HttpPost]
		[Route("")]
		[MapToApiVersion("1.0")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> SendEmail(EmailDTO email)
		{
			await _emailService.SendEmail(email);
			return Ok();
		}
	}

}
