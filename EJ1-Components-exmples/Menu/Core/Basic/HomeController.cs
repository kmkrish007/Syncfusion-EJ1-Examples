using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Pages
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<MenuJson> menuitem = new List<MenuJson>();
            menuitem.Add(new MenuJson { pid = 1, mtext = "Product", parent = null });
            menuitem.Add(new MenuJson { pid = 2, mtext = "Support", parent = null });
            menuitem.Add(new MenuJson { pid = 3, mtext = "Purchase", parent = null });
            menuitem.Add(new MenuJson { pid = 4, mtext = "Downloads", parent = null });
            menuitem.Add(new MenuJson { pid = 5, mtext = "Resources", parent = null });
            menuitem.Add(new MenuJson { pid = 6, mtext = "Company", parent = null });
            ViewBag.datasource = menuitem;
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    public class MenuJson
    {
        public string mtext { get; set; }
        public int pid { get; set; }
        public string parent { get; set; }
    }
}