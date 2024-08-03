using inventory_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inventory_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Dashboard()
        {
            //Equipment.LstEquipment();
            return View();
        }

        
    }
}