using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingFizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index(int value)
        {
            for (int i=1; i<=value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    ViewBag.OutPut += "FizzBuzz";
                else if (i % 3 == 0)
                    ViewBag.OutPut += "Fizz";
                else if (i % 5 == 0)
                    ViewBag.OutPut += "Buzz";
                else
                    ViewBag.OutPut += i.ToString();
            }
            
            return View();
        }
    }
}