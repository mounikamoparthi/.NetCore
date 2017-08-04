using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace hello.controllers     
{
    public class HelloController : Controller       //inherits from mvc controller class
    {
        // [HttpGetAttribute]
        // public string Index()
        // {
        //     return "Hello World!";
        // }
            [HttpGet]
            [Route("")]
            public string Index()
            {
                return "Hello World!";
            }
            
            // A POST method
            //[HttpPost]
            //[Route("")]
            // public IActionResult Other()
            // {
            //     // Return a view (We'll learn how soon!)
            // }
    }
}