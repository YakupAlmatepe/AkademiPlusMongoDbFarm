using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMongoDbFarmWebAppMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
