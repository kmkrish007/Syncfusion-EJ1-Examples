#region Copyright Syncfusion Inc. 2001-2016.
// Copyright Syncfusion Inc. 2001-2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.Models;

namespace drpdwnfor.Controllers
{
    public class HomeController : Controller
    { 
   
        List<DropDownValue> data = new List<DropDownValue>();
        public ActionResult Index()
        {

            data.Add(new DropDownValue { id = 1, Name = "BE", Description = "Behinderte", Checked = true });
            data.Add(new DropDownValue { id = 1, Name = "BL", Description = "Blinde", Checked = true });
            data.Add(new DropDownValue { id = 2, Name = "DE", Description = "Demenz", Checked = true });
            data.Add(new DropDownValue { id = 3, Name = "HO", Description = "Hospiz", Checked = true });
            data.Add(new DropDownValue { id = 4, Name = "PF", Description = "Phase F", Checked = true });
            data.Add(new DropDownValue { id = 5, Name = "PS", Description = "Psycho", Checked = false });
            data.Add(new DropDownValue { id = 6, Name = "TP", Description = "Tagesplege", Checked = false });
            data.Add(new DropDownValue { id = 7, Name = "BA", Description = "Beatmungspflichtig", Checked = true });
            data.Add(new DropDownValue { id = 8, Name = "KP", Description = "Kurzzeitpflege", Checked = true });
            ViewBag.datasource1 = data; 
            DropDownListProperties ddl = new DropDownListProperties();
            ddl.DataSource = data;
            DropDownListFields ddf = new DropDownListFields();
            ddf.Text = "Description";
            ddf.Id = "id";
            ddf.Selected = "Checked";
            ddl.DropDownListFields = ddf;

            ViewData["ddl"] = ddl;
            return View();
        }

       
        } 
  
    public class DropDownValue
    {
        
        public int id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public bool Checked { get; set; }
       
}
    public class DDL
    {
       
        public string auto;
       
        public string name;

        
        public string auto1
        {
            get
            {
                return auto;
            }
            set
            {
                value = auto;
            }
        }
       
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = name;
            }
        }
    }
}