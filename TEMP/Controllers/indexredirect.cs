using Microsoft.AspNetCore.Mvc;

using System;

namespace project1.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
       
       
        public IActionResult Index()
        {

            Console.WriteLine("Hi");

            //return new ContentResult() { Content = "Hello from Index", ContentType = "text/plain" };

            //return Content("Hello from Index", "text/plain");

            return Redirect("/index.html");
        }

        
    }
}