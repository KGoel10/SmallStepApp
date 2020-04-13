using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ONE_SMALL_STEP.Core;
using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.Models;
using ONE_SMALL_STEP.ViewModels;

namespace ONE_SMALL_STEP.Controllers
{
    public class PersonController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly OneSmallStepContext _context;

        public PersonController(IUnitOfWork unitOfWork, OneSmallStepContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }
        

        //IEnumerable<TEntity> GetAll();
        //GET: Person
        //[AutoMap()]
        //public ActionResult Index()
        //{


        //    var domainModel = _unitOfWork.Person.Get(null, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType");
        //    var vm = Mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(domainModel);
        //    //return View(vm);

           
        //    //return View("~/Views/Person/Index.cshtml");
        //    return View("Person2");
        //}


        public ActionResult Index()
        {


            //var domainModel = _unitOfWork.Person.Get(null, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType");
            //var vm = Mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(domainModel);
            ////return View(vm);


            return View();
            //return View("IndexPerson");
        }



        public ActionResult Create()
        {
            var personTypes = _context.PersonType.ToList();
            CreatePersonViewModel model = new CreatePersonViewModel();
            model.PersonTypes = personTypes;

            return View(model);
            
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person Person)
        {
            try
            {
                //Person person = new Person();
                //person.PersonID = createPersonView.PersonID;
                //person.Screenshot = createPersonView.Screenshot;
                //person.EmailAddress = createPersonView.EmailAddress;
                //person.FirstName = createPersonView.FirstName;
                //person.LastName = createPersonView.LastName;
                //person.PersonTypeID = createPersonView.PersonTypeID;
                //person.CreatedDate = DateTime.Now;

                _unitOfWork.Person.Add(Person);
                _unitOfWork.Complete();
                //using (var dbModel = new OneSmallStepContext())
                //{
                //    dbModel.Person.Add(person);
                //    dbModel.SaveChanges();
                //    //Console.WriteLine(person.emailAddress);
                //    //Console.ReadKey();

                //}
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch(DbEntityValidationException e)
            {

                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;

            }
        }
        // POST: Person/Edit/1
        [HttpGet]
        public ActionResult Edit(int id)
        {




            var entities = _unitOfWork.Person.SingleOrDefault(p => p.PersonID == id);
            //var entities = _unitOfWork.Person.GetByID(p => p.PersonID == id, includeProperties: "PersonType");

            //entities = Mapper.Map<IEnumerable<Person>, IEnumerable<EditPersonViewModel>>(entities);
            var PersonTypes = _context.PersonType.ToList();
            var vm = Mapper.Map<Person, EditPersonViewModel>(entities);
            vm.PersonTypes = PersonTypes;
            vm.PersonTypes.ToList();


            return View(vm);
        }

 

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            _unitOfWork.Person.Add(person);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        [HttpGet]
        //[AutoMap(typeof(Person), typeof(DeletePersonViewModel))]
        public ActionResult Delete(int id)
        {                           
            var domainModel = _unitOfWork.Person.Get(p => p.PersonID == id, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType").FirstOrDefault();

            var vm = Mapper.Map<Person, DeletePersonViewModel>(domainModel);

  
            return View(vm);
        }



        [HttpPost]
        public ActionResult Delete (Person person)
        {

            var entities = _unitOfWork.Person.SingleOrDefault(p => p.PersonID == person.PersonID);

            _unitOfWork.Person.Remove(entities);
            //_unitOfWork.Person.Remove(person);
            
            _unitOfWork.Complete();
            return RedirectToAction("Index");
        }


    }
}