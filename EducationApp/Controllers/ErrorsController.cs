using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationApp.Controllers
{
    public class ErrorsController : Controller
    {
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Http404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}