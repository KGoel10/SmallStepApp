using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.Controllers
{
    public class PersonTypeController : Controller
    {
        // GET: PersonType
        public ActionResult Index()
        {
            using (var dbModel = new OneSmallStepContext())
            {
                return View(dbModel.PersonType.ToList());
            }
        }


            // GET: PersonType/Details/5
            public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonType/Create
        [HttpPost]
        public ActionResult Create(PersonTypeViewModel personTypeViewModel)
        {
            try
            {
                PersonType personType = new PersonType();
                personType.PersonTypeName = personTypeViewModel.PersonTypeName;
                using (var dbModel = new OneSmallStepContext())
                {
                    dbModel.PersonType.Add(personType);
                    dbModel.SaveChanges();


                }
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonType/Edit/5
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

        // GET: PersonType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonType/Delete/5
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
