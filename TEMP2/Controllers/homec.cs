using Microsoft.AspNetCore.Mvc;
using System;
using project1.Models;

namespace project1.Controllers
{
    public class SecondController : Controller
    {
        [Route("person")]
        public JsonResult Person()
        {
            Person person = new Person() { Id = Guid.NewGuid(), FirstName = "James", LastName = "Smith", Age = 25 };
            //return new JsonResult(person);
            return Json(person);
            //return "{ \"key\": \"value\" }";
        }

    }
}