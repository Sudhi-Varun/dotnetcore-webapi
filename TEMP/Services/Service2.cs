using project1.ServiceContracts;

namespace project1.Services
{
    public class MyDependency2 : IMyDependency2
    {
        public async FileStream WriteMessage(string message)
        {
            Stream x = new MemoryStream();
            Console.WriteLine($"MyDependency.WriteMessage Message: {message}");
            return x;
            
        }
    }
}
