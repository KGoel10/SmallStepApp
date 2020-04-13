using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.Controllers
{
    public class person_oldController : Controller
    {
        OneSmallStepContext db = new OneSmallStepContext();
        // GET: person_old
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.PersonTypeID = new SelectList(db.PersonType, "PersonTypeID", "PersonTypeName");
            return View();
        }
    }
}