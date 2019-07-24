using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace dotnet_portfolio
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [Route("projects")]
        [HttpGet]
        public ViewResult Projects()
        {
            CultureInfo culture = new CultureInfo("en-US");
            ViewBag.culture = culture; 
            return View();
        }

        [Route("contact")]
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }

    }
}