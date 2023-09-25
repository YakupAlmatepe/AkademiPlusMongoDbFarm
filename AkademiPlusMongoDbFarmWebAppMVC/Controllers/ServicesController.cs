using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMongoDbFarmWebAppMVC.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
