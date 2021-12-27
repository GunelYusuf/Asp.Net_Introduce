using System;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net_First_Lesson.Controllers
{
    public class HomeController:Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index(int id)
        {
            //return Done();
            //return Json();
            //return Content($"Hi Developer! {id}");
            return View();
        }

        public IActionResult About()
        {
            //return Content("About Developers");
            return View();
        }

        public IActionResult Get()
        {
            //var view = new ViewResult();
            //view.ViewName = "Get";
            //return view;
            return View();

        }

        public IActionResult GetAbout()
        {
            return View();
        }

        public IActionResult GetFile()
        {
            return File("~/image/baku-nights.jpeg","baku-nights/jpg");
        }

        public IActionResult GetLayout()
        {
            return View();
        }
    }
}
