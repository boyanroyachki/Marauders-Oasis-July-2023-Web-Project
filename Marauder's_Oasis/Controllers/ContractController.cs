using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marauder_s_Oasis.Controllers
{
	public class ContractController : BaseController
	{
		[AllowAnonymous]
		public async Task<IActionResult> All()
		{
			
			return View();
		}
	}
}
