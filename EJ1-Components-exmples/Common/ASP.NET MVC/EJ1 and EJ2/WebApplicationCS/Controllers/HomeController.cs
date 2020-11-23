using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationCS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SkillSet> skill = new List<SkillSet>();
            skill.Add(new SkillSet { text = "ASP.NET" });
            skill.Add(new SkillSet { text = "ActionScript" });
            skill.Add(new SkillSet { text = "Basic" });
            skill.Add(new SkillSet { text = "C++" });
            skill.Add(new SkillSet { text = "C#" });
            skill.Add(new SkillSet { text = "dBase" });
            skill.Add(new SkillSet { text = "Delphi" });
            skill.Add(new SkillSet { text = "ESPOL" });
            skill.Add(new SkillSet { text = "F#" });
            skill.Add(new SkillSet { text = "FoxPro" });
            skill.Add(new SkillSet { text = "Java" });
            skill.Add(new SkillSet { text = "J#" });
            skill.Add(new SkillSet { text = "Lisp" });
            skill.Add(new SkillSet { text = "Logo" });
            skill.Add(new SkillSet { text = "PHP" });
            ViewBag.datasource = skill;
            ViewBag.data = new string[] { "BadmHennessey Venominton", "Bugatti Chiron", "Bugatti Veyron Super Sport", "SSC Ultimate Aero", "Koenigsegg CCR", "McLaren F1", "Aston Martin One- 77", "Jaguar XJ220" };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class SkillSet
    {
        public string text { get; set; }
    }
}