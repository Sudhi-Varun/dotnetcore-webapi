using Microsoft.AspNetCore.Mvc;
using project1.Models;

namespace project1.Controllers
{
    public class form_2_controller:Controller
    {
     [Route("form2post")]
        public async Task<IActionResult> Index(form_2_Model data)

        {
            Console.WriteLine(data.name1);
            Console.WriteLine(data.name2);
            Console.WriteLine(data.name3);

            Console.WriteLine();
            Console.WriteLine("Processing attached files, if any...");
            Console.WriteLine();
            Console.WriteLine("No of files attached: "+Request.Form.Files.Count);

            string uploads = Path.Combine(path1: @"C:\aspbinbox", path2: "Uploads");
            Directory.CreateDirectory(uploads);

            foreach (var i in Request.Form.Files)
            {
                 Console.WriteLine(i.FileName);
                // Name instead of FileName gives filed id in form.
                 Directory.CreateDirectory(uploads);
                 string filePath = Path.Combine(uploads, DateTime.Now.ToString("dd-MM-yy")+ DateTime.Now.ToString("-hh-mm-ss-") + i.FileName);

                 using Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
               
                 await  i.CopyToAsync(fileStream);
                

            }

            return Ok();
        }
    }
}
