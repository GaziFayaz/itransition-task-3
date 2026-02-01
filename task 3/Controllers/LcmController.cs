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

			if (!long.TryParse(x, out long numX) || !long.TryParse(y, out long numY))
			{
				return Content("NaN", "text/plain");
			}

			if (numX <= 0 || numY <= 0)
			{
				return Content("NaN", "text/plain");
			}

			long lcm = CalculateLCM(numX, numY);
			return Content(lcm.ToString(), "text/plain");
		}

		private long CalculateLCM(long a, long b)
		{
			return (a * b) / CalculateGCD(a, b);
		}

		private long CalculateGCD(long a, long b)
		{
            while (b != 0)
			{
				long temp = b;
				b = a % b;
				a = temp;
            }
			return a;
		}
	}

}