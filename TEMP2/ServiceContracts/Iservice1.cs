namespace project1.ServiceContracts
{
    public interface IMyDependency
    {
        Task<string> WriteMessage(string message);
    }

}

