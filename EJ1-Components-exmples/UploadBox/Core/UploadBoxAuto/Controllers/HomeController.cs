using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private IHostingEnvironment hostingEnv;

        public HomeController(IHostingEnvironment env)
        {
            this.hostingEnv = env;
        }
        public IActionResult SaveUrl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveData(FormClass model)
        {
            var files = HttpContext.Request.Form.Files;
            return View();
        }


        [HttpPost]
        public IActionResult removeUrl(string[] fileNames)
        {
            foreach (var fullName in fileNames)
            {
                var filename = hostingEnv.WebRootPath + $@"\{fullName}"; //get file path
                if (System.IO.File.Exists(filename))
                {
                    System.IO.File.Delete(filename); //delete the file 
                }
            }

            return Content("");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
