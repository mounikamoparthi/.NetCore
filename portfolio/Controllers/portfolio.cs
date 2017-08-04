using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio.Controllers     
{
    public class portfolio : Controller       //inherits from mvc controller class
    {
            [HttpGet]
            [Route("")]
            public IActionResult Index(){
                return View("index");
            }
    }
}