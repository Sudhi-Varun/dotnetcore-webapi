
using Microsoft.AspNetCore.Mvc;
using project1.Models;
using System.IO;
using System.Xml.Linq;
namespace project1.Controllers

{
    public class PostController : Controller
    {
        [Route("post")]
        [HttpPost]
        public IActionResult Post1()
        {
            String? name;

            int i = 1;
            //name = Request.Query["name"+i];
            name = Request.Form["name" + i][0];

           // var a = Request.Form.Files["avatar"];

            //Console.WriteLine(a?.Length);

            //var ms = new MemoryStream();
            //a?.CopyTo(ms);
            //var fileBytes = ms.ToArray();


            return Content($"<h4>{name}</h4>", "text/html");

            //return File(fileBytes,"application/pdf");
         
        }

    }
}


