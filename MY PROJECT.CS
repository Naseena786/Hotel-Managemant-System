using MVC_project__curd_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using static MVC_project__curd_.Models.reg;

namespace MVC_project__curd_.Controllers
{
    public class homeController : Controller
    {
        reg obj=new reg(); 
        // GET: home
        public ActionResult Index()
        { 
                var response = obj.getdetails().OrderBy(a => a.id); 
                return View(response);
                
        }

        // GET: 
        public ActionResult Details(int id)
        {
            var response = obj.getdetails().Single(a=>a.id==id);
            return View(response);
        }

        // GET: 
        public ActionResult Create()
        {
           List<SelectListItem> coulist = new List<SelectListItem>();
            coulist.Add(new SelectListItem() { Text = "select Country", Value = "0" });
            foreach(var item in obj.getcountry().ToList())
            {
                coulist.Add(new SelectListItem() { Text = item.Country });
            }
            TempData["countryvalues"] = coulist;
            TempData.Keep();
            TempData["values"] = obj.getLang();
            
            TempData.Keep();
           
            return View();
        }
         
        // POST:
        [HttpPost]
        public ActionResult Create(FormCollection collection, reg obj2)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string lang = string.Empty;
                    foreach (var item in obj2.getLang())
                    {

                        var checkboxName = "Langknown_" + item.Langknown;
                        if (collection.GetValues(checkboxName) != null)
                        {

                            lang = lang + ", " + item.Langknown;
                        }
                    }
              
                    
                    obj2.Langknown = lang;
                    ViewBag.lang = lang;
                    string Country = obj2.Country;
                    obj.createnew(obj2);
                    return RedirectToAction("Index");
                }
                return View();                                                      
            }
            catch
            {
                return View();
            }
        }
        // GET: home/Edit/5
        public ActionResult Edit(int id)
        {
            var response = obj.getdetails().Single(a => a.id == id);
            return View(response);
        }

        // POST: home/Edit/5
        [HttpPost]
        public ActionResult Edit(reg obj2)
        {
            try
            {
                obj.update(obj2);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      
        public ActionResult Delete(int id)
        {
            var response = obj.getdetails().Single(a => a.id == id);

            return View(response);
        }

   
        [HttpPost]
        public ActionResult Delete(int id,FormCollection collection)
        {
            try
            {
               obj.delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          
        }
       
        
        
    }
}
