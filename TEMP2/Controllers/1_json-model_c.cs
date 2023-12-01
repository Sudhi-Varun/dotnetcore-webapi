using Microsoft.AspNetCore.Mvc;
using project1.Models;
using System.Xml.Linq;

namespace project1.Controllers
{
    public class Person2Controller : Controller
    {
        [Route("json")]
        [HttpPost]
       // public IActionResult Index([FromBody] Json_model_receive model)
       public async Task<IActionResult> Index([FromBody] Json_model_receive model)
        {


            Console.WriteLine(model.Name_fg);
            Console.WriteLine(model.Age);
            Console.WriteLine(model?.Grp?.Str1);
            Console.WriteLine(model?.Container.Length);

            //Console.WriteLine(model?.Container[1]);

            for(int i = 0;i<model?.Container.Length;i++)
            {
                Console.WriteLine(model?.Container[i]);
            }
            //String[] str1 = new string[5] {"apple","mango","banana","orange","pinapple" };

            List<string> list = new List<string>();
            list.Add("UUapple");
            list.Add("mango");
            list.Add("banana");
            list.Add("orange");
            list.Add("pineapple2");

            String[] str1 = list.ToArray(); 

            Grouped_1 temp = new Grouped_1() { Str1 = "aa", Str2 = "bb" };
            
            Json_model_send obj = new () { StatusBoy = "Successfully received", MessageBoy = $"I received {model?.Name_fg}", Grp2 = temp,Container=str1 };
            

            //Err_not_found obj2 = new Err_not_found() { };
                if (ModelState.IsValid)
                return Json(obj);
                else
                return Content("It's over", "text/plain");
        }
    }
}