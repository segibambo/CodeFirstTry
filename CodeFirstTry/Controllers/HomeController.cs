using CodeFirstTry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstTry.Controllers
{
    public class HomeController : Controller
    {
        Birthday birthdays = new Birthday();
        
        // GET: Home
        public ActionResult Index()
        {
            var birthed = from d in birthdays.Persons
                          where
                            d.DateofBirth != DateTime.Now
                          select d;


            return View(birthed.ToList());
        }

        //
        //GET: /Home/Create
        public ActionResult Create()
        {
            return View();
        }
        //
        //POST: /Home/Create

        [HttpPost]
        public ActionResult Create(PersonModel person)
        {
            if(ModelState.IsValid)
            {
                birthdays.Persons.Add(person);
                birthdays.SaveChanges();

                return RedirectToAction("Index");
            }

            else
            {
                //
            }

            return View();
        }
    }
}