using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webexam410716673.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Day(float? name)
        {
            var result = "";
            if(name.HasValue)
            {
                result = "星期" + name;
            }
            ViewBag.Result = result;

            return View();
        }
    }
}