using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

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