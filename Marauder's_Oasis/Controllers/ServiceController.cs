using Microsoft.AspNetCore.Mvc;

namespace Marauder_s_Oasis.Controllers
{
    public class ServiceController : BaseController
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
