using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Accordion.Models;
using Syncfusion.JavaScript.Models;
using Syncfusion.JavaScript;

namespace Accordion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AccordionProperties obj = new AccordionProperties();
            obj.Items.Add(new AccordionBaseItem() { Text = "ASP.NET", ContentTemplate = new MvcTemplate<AccordionBaseItem> { RazorViewTemplate = (data) => { return "Microsoft ASP.NET is a set of technologies in the Microsoft .NET Framework for building Web applications and XML Web services. ASP.NET pages execute on the server and generate markup such as HTML, WML, or XML that is sent to a desktop or mobile browser. ASP.NET pages use a compiled, event-driven programming model that improves performance and enables the separation of application logic and user interface."; } } });
            obj.Items.Add(new AccordionBaseItem() { Text = "ASP.NET MVC", ContentTemplate = new MvcTemplate<AccordionBaseItem> { RazorViewTemplate = (data) => { return " The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication."; } } });
            obj.Items.Add(new AccordionBaseItem() { Text = "JavaScript", ContentTemplate = new MvcTemplate<AccordionBaseItem> { RazorViewTemplate = (data) => { return "JavaScript (JS) is an interpreted computer programming language."; } } });
            obj.EnableAnimation = true;
            ViewData["accordion"] = obj;
            return View();
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
