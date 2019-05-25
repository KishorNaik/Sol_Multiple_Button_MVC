using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Multiple_Button.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnSubmit1()
        {
            ViewBag.Submit1Status = "Submit 1 Called";
            return View("Index");
        }

        public IActionResult OnSubmit2()
        {
            ViewBag.Submit2Status = "Submit 2 Called";
            return View("Index");
        }
    }
}