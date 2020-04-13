using AutoMapper;
using ONE_SMALL_STEP.Core;
using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.Persistence;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Mapster;
using System.Web.Mvc;
using ONE_SMALL_STEP.Persistence.Repositories;
using ONE_SMALL_STEP.App_Start.AutoMapper;

namespace ONE_SMALL_STEP.Controllers
{
    public class HomeController : Controller
    {
               
  
        private readonly OneSmallStepContext _context;   
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork, OneSmallStepContext context)

        {
            _unitOfWork = unitOfWork;
            _context = context;

        }

        public ActionResult Index()
        {

            return View();
            //return PartialView();


        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
 