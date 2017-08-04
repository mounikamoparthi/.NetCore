using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace callingcard.Controllers     
{
    public class card : Controller       //inherits from mvc controller class
    {
            [HttpGet]
            [Route("{name}")]
            public string Name(string name)
            {
                return $"Hi {name}";
            }
            [HttpGet]
            [Route("{age}")]
            public int Age(int age)
            {
                return age ;
            }
            [HttpGet]
            [Route("{name}/{age}/{color}")]
            public JsonResult Jsonobj(string Name,int Age, string Favcolor)
            {
                return Json(new{ name = Name, age = Age, color = Favcolor });
                
            }
            [HttpGet]
            [Route("")]
            public IActionResult Index(){
                return View("index");
            }
    }
}