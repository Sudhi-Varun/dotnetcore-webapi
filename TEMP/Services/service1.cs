using project1.ServiceContracts;

namespace project1.Services
{
    public class MyDependency : IMyDependency
    {
        public void  WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage Message: {message}");
        }
    }
}
