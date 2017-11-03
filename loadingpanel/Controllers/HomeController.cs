using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace loadingpanel.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult GetData()
        {
            List<string> data = new List<string>();
            for (int i = 0; i < 100000; i++)
                data.Add(string.Format("name {0}", i));
            return Json(data);
        }

    }
}