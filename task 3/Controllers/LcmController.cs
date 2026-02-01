using System.Numerics;
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

			if (!BigInteger.TryParse(x, out BigInteger numX) || !BigInteger.TryParse(y, out BigInteger numY))
			{
				return Content("NaN", "text/plain");
			}
			Console.WriteLine("x = {0}, y = {1}",  x, y);

			if (numX <= 0 || numY <= 0)
			{
				return Content("NaN", "text/plain");
			}

			BigInteger lcm = CalculateLCM(numX, numY);
			Console.WriteLine("LCM = {0}", lcm);
			return Content(lcm.ToString(), "text/plain");
		}

		private BigInteger CalculateLCM(BigInteger a, BigInteger b)
		{
			return (a * b) / CalculateGCD(a, b);
		}

		private BigInteger CalculateGCD(BigInteger a, BigInteger b)
		{
			while (b != 0)
			{
				BigInteger temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
	}

}