using Microsoft.AspNetCore.Mvc;

namespace dotnet_portfolio
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public string Index()
        {
            return $"This is my index, Website land page!";
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