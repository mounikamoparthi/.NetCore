using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolio.Controllers     
{
    public class portfolio : Controller       //inherits from mvc controller class
    {
            [HttpGet]
            [Route("Home")]
            public IActionResult Index(string name){
                ViewBag.Example = "Mounika";
                return View("index");
            }
            [HttpGet]
            [Route("Projects")]
            public IActionResult project()
            {
                return View("project") ;
            }
            [HttpGet]
            [Route("Contact")]
            public IActionResult contact(string name)
            {
                 ViewBag.Example = "Mounika";
                return View("contact") ;
            }
    }
}