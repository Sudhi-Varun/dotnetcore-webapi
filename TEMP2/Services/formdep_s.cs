using project1.Models;
using project1.ServiceContracts;

namespace project1.Services
{
    public class formdep_s:Iformdep_sc
    {
       
        public Task<string> process(Formdep_Grp2 req2, Formdep_Grp3 req3)
        {
            Console.WriteLine("Inside the service block");
            Console.WriteLine(req2.name4);
            Console.WriteLine(req2.name5);
            Console.WriteLine(req2.name6);

            Console.WriteLine(req3.name7);
            Console.WriteLine(req3.name8);
            Console.WriteLine(req3.name9);


            return Task.FromResult("message from service block!!!");
        }
        
    }
}
