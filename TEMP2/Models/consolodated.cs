using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace project1.Models
{
    public class Consolodated
    {
        public Stream x {  get; set; }
        public string y { get; set; }

        public Consolodated()
        {
           y = string.Empty;
           x = new MemoryStream();
        }

    }
}
