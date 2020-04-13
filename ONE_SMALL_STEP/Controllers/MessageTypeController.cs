using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.Controllers
{
    public class MessageTypeController : Controller
    {
        // GET: MessageType
        public ActionResult Index(MessageTypeViewModel messageTypeViewModel)
        {
      
            using (var dbModel = new OneSmallStepContext())
            {
                //List<MessageType> dbModel.MessageType.ToList();
                var MessageType = new MessageType();
                MessageType.MessageTypeName = messageTypeViewModel.MessageTypeName;

                return View(dbModel.MessageType.ToList());
            }
        
   
      

       
            
        }

        // GET: MessageType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageType/Create
        [HttpPost]
        public ActionResult Create(MessageTypeViewModel messageTypeViewModel)
        {
            try
            {
                using (var dbModel = new OneSmallStepContext())
                {
                    var messageType = new MessageType();
                    messageType.MessageTypeName = messageTypeViewModel.MessageTypeName;

                    dbModel.MessageType.Add(messageType);
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

        // GET: MessageType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageType/Edit/5
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

        // GET: MessageType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageType/Delete/5
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
