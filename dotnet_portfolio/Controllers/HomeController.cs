using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using dotnet_portfolio.Models;

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

        [Route("DojoSurvey")]
        [HttpPost]        
        public IActionResult DojoSurvey(string name, string location, string language, string message)
        {                       
                Comment model = new Comment(){
                    Name = name,
                    Location = location,
                    Language = language,
                    Note = message
                };
            
            return View("DojoComment", model);
        }

        [Route("dojocomment")]
        [HttpGet]
        public ViewResult DojoComment(Comment modelObject)
        {
            Comment model = modelObject;
            return View(model);
        }

    }
}