using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojosurvey.Controllers     
{
    public class survey : Controller       //inherits from mvc controller class
    {
            
            [HttpGet]
            [Route("")]
            public IActionResult form()
            {
                return View("index");
            }
            [HttpPost]
            [Route("result")]
             public IActionResult result(string Name, string location, string language,string comment)
            {
                ViewBag.Name = Name;
                ViewBag.location = location;
                ViewBag.language = language;
                ViewBag.comment = comment;
                return View("result");
            }
                
    }
}