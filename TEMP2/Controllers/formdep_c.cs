using Microsoft.AspNetCore.Mvc;
using project1.ServiceContracts;
using project1.Models;
namespace project1.Controllers
{
    public class formdep_c:Controller

    {
        private readonly Iformdep_sc _formdep_sc;
        public formdep_c(Iformdep_sc formdep_sc)
        {
            _formdep_sc=formdep_sc;
        }

        [Route("formdeppost")]
        public async Task<IActionResult> Index(Formdep_Grp1 req1,Formdep_Grp2 req2, Formdep_Grp3 req3)

        {

            Console.WriteLine(req1.name1);
            Console.WriteLine(req1.name2);
            Console.WriteLine(req1.name3);

            


            var str=  await _formdep_sc.process(req2,req3);

            Console.WriteLine(str);


            return Ok();
            
        }
    }
}
