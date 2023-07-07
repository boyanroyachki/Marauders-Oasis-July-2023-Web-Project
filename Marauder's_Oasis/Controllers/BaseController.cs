using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Marauder_s_Oasis.Controllers
{
	[Authorize]
	public class BaseController : Controller
	{
	}
}
