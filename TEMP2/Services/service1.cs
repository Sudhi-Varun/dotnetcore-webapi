using project1.ServiceContracts;

namespace project1.Services
{
    public class MyDependency : IMyDependency
    {
        public Task<string>  WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage Message: {message}");
            return Task.FromResult("hdhdhdhdhdhdhdhdh");
        }
    }
}
