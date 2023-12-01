namespace project1.Models
{
    public class Err_not_found
    {
        public String? error { get; set; }
        public String? errorMessage { get; set; }
        public Err_not_found() 
        {
            error = "Error occoured";
            errorMessage = "The requested resource cannot be found";
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
