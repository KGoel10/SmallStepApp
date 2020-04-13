using AutoMapper;
using ONE_SMALL_STEP.Core;
using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.Persistence.Repositories;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ONE_SMALL_STEP.Controllers.api
{
    [RoutePrefix("api")]
    public class PersonController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly OneSmallStepContext _context;

        //public PersonController()
        //{     
        //}

        //public PersonController(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}

        public PersonController(IUnitOfWork unitOfWork, OneSmallStepContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }



        //public IEnumerable<PersonViewModel> GetPerson()
        //public IEnumerable<PersonViewModel> GetPerson()
        //{
        //    //return _unitOfWork.Person.GetAll();
        //    //return _unitOfWork.Person.GetAll().Select(Mapper.CreateMap<Person, PersonViewModel>());
        //}
        //private IPersonRepository _repository;
        //public PersonContoller(IPersonRepository repository)
        //{
        //    _repository = repository;
        //}

        //public PersonViewModel Get()
        //{
        //    return _unitOfWork.Person;
        //}


        //public IEnumerable<PersonViewModel> GetPerson()
        //{
        //    //return _repository.PersonViewModel();
        //}
        //// GET api/<controller>
        //public IEnumerable<PersonViewModel> GetPerson()
        //{
        //    //return new string[] { "value1", "value2" };
        //    //var person = _unitOfWork.Person.GetAll();

        //    var person = _unitOfWork.
        //    //return _unitOfWork


        //    //return View(courses);

        //}
        //[HttpGet]
        [HttpGet]
        [Route("person")]
        public IEnumerable<PersonViewModel> Get()

        {
            //dummy code

            List<PersonViewModel> lst = new List<PersonViewModel>();

            PersonViewModel pp = new PersonViewModel();
            pp.PersonID = 101;
            pp.FirstName = "Test First Name";
            pp.LastName = "Test Last Name";
            pp.EmailAddress = "test@gmail.com";

            lst.Add(pp);

            PersonViewModel pp2 = new PersonViewModel();
            pp2.PersonID = 102;
            pp2.FirstName = "Test2 First Name";
            pp2.LastName = "Test2 Last Name";
            pp2.EmailAddress = "test2@gmail.com";

            lst.Add(pp2);

            return lst;



            //return _repository.GetProfileForEdit(User.Identity.Name);
            ////var domainModel = _unitOfWork.Person.Get(null, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType");

            //return _unitOfWork.Person.Get(null, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType");

            //return View(courses.ToList());

           //// var vm = Mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(domainModel);
            //var vm = Ok(Mapper.Map<IEnumerable<PersonViewModel>>(domainModel));
            //return (PersonViewModel)vm;
           //// return vm;

        }



        //public ActionResult Create()
        //{
        //    var personTypes = _context.PersonType.ToList();
        //    CreatePersonViewModel model = new CreatePersonViewModel();
        //    model.PersonTypes = personTypes;

        //    return View(model);

        //}


        // POST: api/EmployeesAPI
        //[ResponseType(typeof(Employee))]
        [HttpPost]
        [Route("person/create")]
        public IHttpActionResult PostPerson(Person Person)
            //public IHttpActionResult PostPerson(CreatePersonViewModel Person) >> need to switch to this<<<
        //public PersonViewModel PostPerson(Person Person)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //db.Employees.Add(employee);
            //db.SaveChanges();

            _unitOfWork.Person.Add(Person);
            _unitOfWork.Complete();

            //return Ok(Person);
            return Ok(Person.PersonID);

            //return CreatedAtRoute("DefaultApi", new {id = Person.PersonID }, Person);
            //return Request.CreateResponse(HttpStatusCode.OK, 1);
            //if (result > 0)
            //{
            //    return Request.CreateResponse(HttpStatusCode.Created, "Submitted Successfully");
            //}
            //else
            //{
            //    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Something wrong !");
            //}
            //return CreatedAtRoute("DefaultApi", new { id = employee.EmpNo }, employee);
        }


        // POST api/Person  
        public HttpResponseMessage Post(Person Person)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Person.Add(Person);
                _unitOfWork.Complete();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, Person);
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }




        // POST: Person/Edit/1
        [HttpGet]
        [Route("person/{personId}")]
        public EditPersonViewModel Get(int personId)
        {

            var entities = _unitOfWork.Person.SingleOrDefault(p => p.PersonID == personId);
            //var entities = _unitOfWork.Person.GetByID(p => p.PersonID == id, includeProperties: "PersonType");

            //entities = Mapper.Map<IEnumerable<Person>, IEnumerable<EditPersonViewModel>>(entities);
            //var PersonTypes = _context.PersonType.ToList();
            var vm = Mapper.Map<Person, EditPersonViewModel>(entities);
            //vm.PersonTypes = PersonTypes;
            //vm.PersonTypes.ToList();


            return (vm);
        }

        //public IHttpActionResult GetPersonTypes()
        //{
        //    var personType = new PersonType();


        //}

        //[Route("person/update/{personId}")]
        [HttpPut]
        [Route("person/update")]
        //api/person/delete/" + personId,
        //public PersonViewModel Update(int personId, Person Person)
        public PersonViewModel Update(Person Person)
        {
            //var domainModel = _unitOfWork.Person.Get(x => x.PersonID == personId).FirstOrDefault();

            //_unitOfWork.Person.Update(domainModel);
            _unitOfWork.Person.Update(Person);
            _unitOfWork.Complete();
            //var vm = Mapper.Map<Person, PersonViewModel>(domainModel);
            var vm = Mapper.Map<Person, PersonViewModel>(Person);
            return vm;
        }

        [Route("person/delete/{personId}")]
        //api/person/delete/" + personId,
        public PersonViewModel Delete(int personId)
        {
            var domainModel = _unitOfWork.Person.Get(x => x.PersonID == personId).FirstOrDefault();
            
            _unitOfWork.Person.Remove(domainModel);
            _unitOfWork.Complete();
            var vm = Mapper.Map<Person,PersonViewModel>(domainModel);
            return vm;
        }
        [Route("person/personType")]
        public IEnumerable<PersonTypeViewModel> GetPersonTypes()

        {
            //return _repository.GetProfileForEdit(User.Identity.Name);
            //var domainModel = _unitOfWork.PersonType.Get(null, x => x.OrderBy(z => z.PersonTypeName), includeProperties: "PersonType");
            var domainModel = _unitOfWork.PersonType.Get(null, x => x.OrderBy(z => z.PersonTypeName));

            //return _unitOfWork.Person.Get(null, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType");

            var vm = Mapper.Map<IEnumerable<PersonType>, IEnumerable<PersonTypeViewModel>>(domainModel);

            //var vm = Mapper.Map<IEnumerable<PersonType>, IEnumerable<PersonTypeViewModel>>(domainModel);
            //var vm = Ok(Mapper.Map<IEnumerable<PersonTypeViewModel>>(domainModel));
            //return (PersonViewModel)vm;
            //return vm;
            //var personType = _context.PersonType.ToList();
            return vm;

        }


        ////[HttpGet]
        //////[AutoMap(typeof(Person), typeof(DeletePersonViewModel))]
        ////public ActionResult Delete(int id)
        //[Route("person/delete/{personId}")]
        //public IEnumerable<DeletePersonViewModel> Delete(int personId)
        //{
        //    var domainModel = _unitOfWork.Person.Get(p => p.PersonID == personId, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType").FirstOrDefault();

        //    var vm = Mapper.Map<Person, DeletePersonViewModel>(domainModel);


        //    return vm;
        //}



        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    var domainModel = _unitOfWork.Person.Get(x => x.PersonID == id, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType").SingleOrDefault();
        //    //return View(courses.ToList());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    //return Ok(Mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(domainModel));
        //    return Ok(Mapper.Map<Person, PersonViewModel>(domainModel));

        //    //return "value";
    }

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }

