namespace project1.Models
{
    public class Err_not_found
    {
        public String? Error { get; set; }
        public String? Error_message { get; set; }

        public Err_not_found() 
        {
            Error = "Error";
            Error_message = "The given resource is not found. Please find it else where.";
        }
    }

    public class Err_multiple
    {
        public String? Error { get; set; }
        public String? Error_message { get; set; }

        public Err_multiple()
        {
            Error = "Error2";
            Error_message = "There are repeated instance of the same resource.";
        }
    }
}
