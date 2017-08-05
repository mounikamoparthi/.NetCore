using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojosurvey.Controllers     
{
    public class survey : Controller       //inherits from mvc controller class
    {
            
            [HttpGet]
            [Route("")]
            public IActionResult Index()
            {
                return View();
            }
            [HttpPost]
            [Route("result")]
             public IActionResult Result(string Name, string location, string language,string comment)
            {
                ViewBag.Name = Name;
                ViewBag.location = location;
                ViewBag.language = language;
                ViewBag.comment = comment;
                return View("result");
            }
            // [HttpGet]
            // [Route("back")]
            // public IActionResult back(){
            //     return RedirectToAction("result");
            // }
                
    }
}