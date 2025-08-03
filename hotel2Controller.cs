using MVC_project__curd_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_project__curd_.Controllers
{
    public class hotel2Controller : Controller
    {
        hotel obj=new hotel();
        // GET: hotel2
        public ActionResult Index()
        {
            var response=obj.gethoteldetails();
            return View(response);
        }

        // GET: hotel2/Details/5
        public ActionResult Details(int id)
        {
            var response = obj.gethoteldetails().Single(a=>a.id==id);
            return View(response); 
        }

       // GET: hotel2/Create
        public ActionResult Create()
        {
            
            TempData["values"] = obj.getamenities();
            TempData.Keep();

            return View();
        }

        // POST: hotel2/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, hotel obj2)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string amenity = string.Empty;
                    var amenities = obj2.getamenities();
                    foreach (var item in amenities)
                    {
                       
                        var checkboxName = "Amenities_" + item.Amenities;
                        if (collection[checkboxName] != null && collection[checkboxName].ToString() == "on")
                        {
                            amenity = amenity + ", " + item.Amenities;
                        }
                    }
               
                    obj2.Amenities = amenity.TrimStart(',');
                    obj.create(obj2);
                   
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: hotel2/Edit/5
        public ActionResult Edit(int id)
        {
           var response= obj.gethoteldetails().Single(a => a.id == id);
           return View();
        }

        // POST: hotel2/Edit/5
        [HttpPost]
        public ActionResult Edit(hotel obj2)
        {
            try
            {
                obj.updatehotel(obj2);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: hotel2/Delete/5
        public ActionResult Delete(int id)
        {
            var response = obj.gethoteldetails().Single(a=>a.id==id);
            return View(response);
        }

        // POST: hotel2/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                obj.deletehotel(id);   

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
