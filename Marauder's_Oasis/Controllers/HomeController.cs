using Marauders_Oasis.Web.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Marauder_s_Oasis.Controllers
{
	public class HomeController : BaseController
	{
		public HomeController()
		{
		}

		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Contact()
		{
			if (User.Identity.IsAuthenticated)
			{
				return View();
			}
			else
			{
				return RedirectToAction("Login", "Account");
			}
		}
		[AllowAnonymous]
		public IActionResult Anonymous()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}