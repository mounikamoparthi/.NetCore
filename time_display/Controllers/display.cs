using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace time_display.Controllers     
{
    public class display : Controller       //inherits from mvc controller class
    {
            [HttpGet]
            [Route("")]
            public IActionResult Index(){
                return View("index");
            }
    }
}