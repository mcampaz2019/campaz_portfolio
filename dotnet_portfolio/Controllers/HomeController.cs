using Microsoft.AspNetCore.Mvc;

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
        public string Projects()
        {
            return $"This are my current projects:";
        }

        [Route("contact")]
        [HttpGet]
        public string Contact()
        {
            return $"This are my current contact info:";
        }

    }
}