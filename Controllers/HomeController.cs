using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// This controller is for Emp Actions 
namespace TravelTrackEmpManegment.Controllers
{
    public class HomeController : Controller
    {
        // Options for the employee..
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TripData()
        {
            return View();
        }

        public ActionResult TripDataHandel()
        {
            return View();
        }

    }
}