using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace ONE_SMALL_STEP.Controllers
{
    public class Person_Controller_OLD : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            //using (var dbModel = new OneSmallStepContext())
            //{
            //    //return View(dbModel.Person.ToList());

            //    List<Person> person = dbModel.Person.ToList();
            //    List<PersonType> personType = dbModel.PersonType.ToList();

            //    var personDetails = from p in person
            //                        join pt in personType on p.PersonTypeID equals pt.PersonTypeID into t1
            //                        //from p in t1.DefaultIfEmpty()
            //                        select new 
            //}
            return View();
            
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create

        public ActionResult AddNewPerson()
        {
            //ViewBag.PersonTypeID = new SelectList(db.MessageType, "MessageTypeID", "MessageTypeName");
            return View();
        }
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                using (var dbModel = new OneSmallStepContext())
                {
                    dbModel.Person.Add(person);
                    dbModel.SaveChanges();
                    //Console.WriteLine(person.emailAddress);
                    //Console.ReadKey();

                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();  //it will return create vieww , from data is inseted 
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
