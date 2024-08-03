using inventory_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inventory_project.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account Model)
        {
            if (string.IsNullOrEmpty(Model.UserName) || string.IsNullOrEmpty(Model.Password) )
                ViewBag.Message = "Input Needed";

            if (Model.UserName == "Shamsuddin" && Model.Password == "123")
            {
                Session["User"] = Model.UserName;
                ViewBag.Message = "Login Success";
                //Response.Redirect();
               // return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                ViewBag.Message = "Login Faild";
            }
            return View();
        }
    }
}