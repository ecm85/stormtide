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
        [Route("SpaceAlertResolver/{*catchall}")]
        public ActionResult SpaceAlertResolver()
        {
            return Redirect("https://space-alert-resolver.stormtide.net");
        }

        [Route("Avery16282Generators")]
        [Route("Avery16282Generators/{*catchall}")]
        public ActionResult Avery16282Generators()
        {
            return Redirect("https://avery-16282-generators.stormtide.net");
        }
    }
}
