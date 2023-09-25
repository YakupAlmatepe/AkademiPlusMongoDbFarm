using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMongoDbFarmWebAppMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OurInfoPartial()
        {
            return PartialView();
        }
        public IActionResult WhatWeDoPartial()
        {
            return View();
        }
        public IActionResult RootWithNaturePartial()
        {
            return View();
        }
        public IActionResult WhyUsPartial()
        {
            return View();
        }
        public IActionResult HappyClientsPartial()
        {
            return View();
        }
        public IActionResult FooterPartial()
        {
            return View();
        }
    }
}
