
 
namespace project1.Models
{

    public class Grouped_1
    {
        public string? Str1 { get; set; }
        public string? Str2 { get; set; }

    }

    public class Json_model_receive
    {
        
        public string? Name_fg { get; set; }
            public int Age { get; set; }

            public Grouped_1? Grp { get; set; }

        public string[] Container { get; set; }

        public Json_model_receive()
        {
            Container = Array.Empty<string>();
        }
        
    }

    public class Json_model_send
    {

        public string? StatusBoy { get; set; }
        public string? MessageBoy { get; set; }
        
        public string? Standard_response { get; set; }
        public Grouped_1? Grp2 { get; set; }

        public string[] Container { get; set; }
        public Json_model_send()
        {
            Standard_response = "I am here in the standard response";
            Container = Array.Empty<string>();
        }

    }

}
