
using Microsoft.AspNetCore.Mvc;
using project1.Models;
using System.Xml.Linq;
namespace project1.Controllers

{
    public class GetController : Controller
    {
    [Route("get")]
     
    public IActionResult Get1()
        {
            String? name;

            int i = 1;
            //name = Request.Query["name"+i];
             name = Request.Query["name" + i][0];
            //name = Request.Query.ToString();
            Console.WriteLine(name);

            //return Content($"<h4>{name}</h4>", "text/html");
            return Json(new Err_not_found());
             

        }

    }
}


