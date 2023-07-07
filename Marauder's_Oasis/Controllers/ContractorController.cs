using Microsoft.AspNetCore.Mvc;

namespace Marauder_s_Oasis.Controllers
{
	public class ContractorController : BaseController
	{
		public async Task<IActionResult> BecomeContractor()
		{
			return View();
		}
	}
}
