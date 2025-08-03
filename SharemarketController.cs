using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVC_project__curd_.Controllers
{
    public class SharemarketController : Controller
    {
        // GET: Sharemarket
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Graph()
        {
            string[] xAxis = { "Paytm", "HDFC", "Kotak", "TCS" };
            string[] yAxis = { "1000", "4000", "3000", "2500" };
            var bytes = new Chart(width: 600, height: 600).AddSeries(chartType: "column",
                xValue: xAxis, yValues: yAxis).GetBytes("png");
            return File(bytes, "image/png");

        }
    }
}