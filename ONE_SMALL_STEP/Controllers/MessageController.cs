using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class MessageController : Controller
    {

        //// GET: Message
        //private OneSmallStepContext db = new OneSmallStepContext();
        //public ActionResult Index()
        //{

        //    using (var dbModel = new OneSmallStepContext())
        //    {
        //        return View(dbModel.Message.ToList());
        //    }


        //}



//        // GET: Message
//#pragma warning disable CA3147 // Mark Verb Handlers With Validate Antiforgery Token
//        public ActionResult Index(MessageViewModel messageViewModel)
//#pragma warning restore CA3147 // Mark Verb Handlers With Validate Antiforgery Token
//        {

//            using (var dbModel = new OneSmallStepContext())
//            {
//                //List<MessageType> dbModel.MessageType.ToList();
//                var Message = new Message();
//                Message.MessageName = messageViewModel.MessageName;

//                return View(dbModel.Message.ToList());          
//            }



        //}



        // GET: Message/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //public ActionResult  AddNewMessages()
        //{
        //    ViewBag.MessageTypeID = new SelectList(db.MessageType, "MessageTypeID", "MessageTypeName");
        //    return View();
        //}

        // GET: Message/Create
        public ActionResult Create()
        {
      
     
            return View();
            
        }

        // POST: Message/Create
        [HttpPost]
        public ActionResult AddNewMessages(Message message)
        {
            try
            {
                using (var dbModel = new OneSmallStepContext())
                {
                    dbModel.Message.Add(message);
                    dbModel.SaveChanges();
                    //Console.WriteLine(person.emailAddress);
                    //Console.ReadKey();

                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Message/Edit/5
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

        // GET: Message/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Message/Delete/5
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
