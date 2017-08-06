using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace random_passcode.Controllers
{
    public class random : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int? RunCount = HttpContext.Session.GetInt32("RunCount");
            if(RunCount == null)
            {
                RunCount = 0;
            }
            RunCount += 1;
            string PossibleCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string PassCode = "";
            Random Rand = new Random();
            for(int i = 0; i < 14; i++)
            {
                PassCode = PassCode + PossibleCharacters[Rand.Next(0, PossibleCharacters.Length)];
            }
            ViewBag.PassCode = PassCode;
            ViewBag.RunCount = RunCount;
            HttpContext.Session.SetInt32("RunCount", (int)RunCount);
            return View();
        }
    }
}