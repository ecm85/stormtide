using Microsoft.AspNetCore.Mvc;

namespace Stormtide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("SpaceAlertResolver")]
        public ActionResult SpaceAlertResolver()
        {
            return Redirect("https://space-alert-resolver.stormtide.net");
        }

        [Route("Avery16282Generators")]
        public ActionResult Avery16282Generators()
        {
            return Redirect("https://avery-16282-generators.stormtide.net");
        }
    }
}
