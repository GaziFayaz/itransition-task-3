using Microsoft.AspNetCore.Mvc;

namespace task_3.Controllers
{
	[ApiController]
	[Route("gazifayaz_16694_gmail_com")]
	public class LcmController : ControllerBase
	{
		[HttpGet]
		[Produces("text/plain")]
		public IActionResult CalculateLcm([FromQuery] string? x, [FromQuery] string? y)
		{

			if (string.IsNullOrEmpty(x) || string.IsNullOrEmpty(y))
			{
				return Content("NaN", "text/plain");
			}

			if (!ulong.TryParse(x, out ulong numX) || !ulong.TryParse(y, out ulong numY))
			{
				return Content("NaN", "text/plain");
			}
			Console.WriteLine(x, y);

			if (numX <= 0 || numY <= 0)
			{
				return Content("NaN", "text/plain");
			}

			ulong lcm = CalculateLCM(numX, numY);
			return Content(lcm.ToString(), "text/plain");
		}

		private ulong CalculateLCM(ulong a, ulong b)
		{
			return (a * b) / CalculateGCD(a, b);
		}

		private ulong CalculateGCD(ulong a, ulong b)
		{
			while (b != 0)
			{
				ulong temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
	}

}