using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EducationApp.Controllers
{
    public class ResponseController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var result = await Task.Run(() =>
            {
                int count = 0;
                for (int i = 0; i < 10; i++)
                {
                    count++;
                }
                return count;
            });
            return View(result);
        } 
    }
}