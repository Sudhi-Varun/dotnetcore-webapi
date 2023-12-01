using Microsoft.AspNetCore.Mvc;
using project1.ServiceContracts;
namespace project1.Controllers
{
    public class Index2Model : Controller
    {
        private readonly IMyDependency _myDependency;
        public Index2Model(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }
        [Route("dep1")]
        public async Task<IActionResult> Index() 
        
        {
             await _myDependency.WriteMessage("Index2Model.OnGet");

            //Console.WriteLine (_myDependency.WriteMessage("Index2Model.OnGet"));
            return Json("test");
        }

    }
}
