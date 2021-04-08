using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        HospitalContext Context = new HospitalContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAppointment()
        {
            
            return View();
        }
        public ActionResult GetDoctors()
        {

            return View();
        }
    }
}