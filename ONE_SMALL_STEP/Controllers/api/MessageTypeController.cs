using AutoMapper;
using ONE_SMALL_STEP.Core;
using ONE_SMALL_STEP.Core.Domain;
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
    public class MessageTypeController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly OneSmallStepContext _context;


        public MessageTypeController(IUnitOfWork unitOfWork, OneSmallStepContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }





        // POST: Person/Edit/1
        
        [HttpGet]
        [Route("messagetype/{messageTypeId}")]
        public EditMessageTypeViewModel Get(int messageTypeId)
        {

            var entities = _unitOfWork.MessageType.SingleOrDefault(mt => mt.MessageTypeID == messageTypeId);
            //var entities = _unitOfWork.Person.GetByID(p => p.PersonID == id, includeProperties: "PersonType");

            //entities = Mapper.Map<IEnumerable<Person>, IEnumerable<EditPersonViewModel>>(entities);
            //var PersonTypes = _context.PersonType.ToList();
            //var vm = Mapper.Map<Person, EditPersonViewModel>(entities);
            var vm = Mapper.Map<MessageType, EditMessageTypeViewModel>(entities);
            //vm.PersonTypes = PersonTypes;
            //vm.PersonTypes.ToList();


            return (vm);
        }


 


        // POST: api/EmployeesAPI
        //[ResponseType(typeof(Employee))]
        [HttpPost]
        [Route("messagetype/create")]
        public IHttpActionResult PostMessageType(MessageType MessageType)
        //public IHttpActionResult PostPerson(CreatePersonViewModel Person) >> need to switch to this<<<
        //public PersonViewModel PostPerson(Person Person)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //db.Employees.Add(employee);
            //db.SaveChanges();

            _unitOfWork.MessageType.Add(MessageType);
            _unitOfWork.Complete();

            //return Ok(Person);
            return Ok(MessageType.MessageTypeID);

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


        [HttpGet]
        [Route("messagetype")]
        public IEnumerable<MessageTypeViewModel> Get()

        {
            //return _repository.GetProfileForEdit(User.Identity.Name);
            var domainModel = _unitOfWork.MessageType.Get(null, x => x.OrderBy(z => z.MessageTypeName));

            //return _unitOfWork.Person.Get(null, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType");

            //return View(courses.ToList());

            var vm = Mapper.Map<IEnumerable<MessageType>, IEnumerable<MessageTypeViewModel>>(domainModel);
            //var vm = Ok(Mapper.Map<IEnumerable<PersonViewModel>>(domainModel));
            //return (PersonViewModel)vm;
            return vm;

        }


        [HttpPut]
        [Route("messagetype/update")]
        //api/person/delete/" + personId,
        //public PersonViewModel Update(int personId, Person Person)
        public MessageTypeViewModel Update(MessageType MessageType)
        {
            //var domainModel = _unitOfWork.Person.Get(x => x.PersonID == personId).FirstOrDefault();

            //_unitOfWork.Person.Update(domainModel);
            _unitOfWork.MessageType.Update(MessageType);
            _unitOfWork.Complete();
            //var vm = Mapper.Map<Person, PersonViewModel>(domainModel);
            var vm = Mapper.Map<MessageType, MessageTypeViewModel>(MessageType);
            return vm;
        }



        [Route("messagetype/delete/{messageTypeId}")]
        //api/person/delete/" + personId,
        public MessageTypeViewModel Delete(int messageTypeId)
        {
            var domainModel = _unitOfWork.MessageType.Get(x => x.MessageTypeID == messageTypeId).FirstOrDefault();

            _unitOfWork.MessageType.Remove(domainModel);
            _unitOfWork.Complete();
            var vm = Mapper.Map<MessageType, MessageTypeViewModel>(domainModel);
            return vm;
        }


    }
}
