using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JordanHall_Mayborn.Controllers
{
    public class HomeController : Controller
    {
        //retrives index page
        public ActionResult Index()
        {
            return View();
        }

        //Goes to about page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Goes to contract page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
        public void Save(string firstName, string lastName)
        {
            //saves to the user details folder under user
            using (StreamWriter writer = new StreamWriter(Server.MapPath("/UserDetails/user.txt"), true))
            {
                writer.WriteLine($"{firstName} {lastName},");
            }

        }

    }
}