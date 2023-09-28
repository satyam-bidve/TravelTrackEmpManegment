using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrackEmpManegment.Models;

namespace TravelTrackEmpManegment.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogoutPage()
        {
            return View();
        }

        public ActionResult CreateEmployee() // Regster 
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEmployee(LogEmp emp) // Regster 
        {
            return View();
        }
    }
}