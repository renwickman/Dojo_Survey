using Microsoft.AspNetCore.Mvc;
using System;

namespace DojoSurvey {

    public class MainController : Controller
    {
        [HttpGet("")]
        public ViewResult Survey()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View();
        }
    }
}