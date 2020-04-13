using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.Controllers
{
    public class PersonMessageController : Controller
    {
        // GET: PersonMessage
        //public ActionResult Index()
        //{
        //    //using (var dbModel = new OneSmallStepContext()) 
        //    //{
        //    //   List<Person> person = dbModel.Person.ToList();
        //    //    List<PersonType> personType = dbModel.PersonType.ToList();
                
        //    //    PersonViewModel personViewModel = new PersonViewModel();
        //    //    personViewModel.personTypeList = personType;
        //    //  personViewModel.personlist = person;
        //    //    return View(personViewModel);
        //    //}
        //    //return View();
        //}

        // GET: PersonMessage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonMessage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonMessage/Create
        [HttpPost]
        public ActionResult Create(PersonMessage personMessage)
        {
            try
            {
                using (var dbModel = new OneSmallStepContext())
                {
                    dbModel.PersonMessage.Add(personMessage);
                    dbModel.SaveChanges();

                }
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonMessage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonMessage/Edit/5
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

        // GET: PersonMessage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonMessage/Delete/5
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
