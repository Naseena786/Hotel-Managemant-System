using MVC_project__curd_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_project__curd_.Controllers
{
    public class hotelController : Controller
    {
        hotel obj = new hotel();
        // GET: hotel
        public ActionResult Index()
        {
            return RedirectToAction("login");
        }
        public ActionResult login(string username, string password)
        {
            if (Session["username"] != null && Session["password"] != null && username == Session["username"].ToString()
           && password == Session["password"].ToString())
            {
                ViewBag.Message = "login successful" + username;

            }
            else
            {
                ViewBag.Message = "Invalid credentials!";
            }
            return View();

        }
       
       
        
    }
}