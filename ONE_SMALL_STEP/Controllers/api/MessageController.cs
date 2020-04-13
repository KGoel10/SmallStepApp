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
    public class MessageController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly OneSmallStepContext _context;


        public MessageController(IUnitOfWork unitOfWork, OneSmallStepContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        [HttpGet]
        [Route("message/{messageId}")]
        //public EditMessageViewModel2 Get(int messageId)
        public EditMessageViewModel Get(int messageId)
        {

            var entities = _unitOfWork.Message.SingleOrDefault(m => m.MessageID == messageId);
            var vm = Mapper.Map<Message, EditMessageViewModel>(entities);
            return (vm);
        }


        [HttpPost]
        [Route("message/create")]
        public IHttpActionResult PostMessageType(Message Message)
        {
   

            _unitOfWork.Message.Add(Message);
            _unitOfWork.Complete();

  
            return Ok(Message.MessageID);

          
        }


        [HttpGet]
        [Route("message")]
        public IEnumerable<MessageViewModel> Get()

        {
            //return _repository.GetProfileForEdit(User.Identity.Name);
            var domainModel = _unitOfWork.Message.Get(null, x => x.OrderBy(z => z.MessageName), includeProperties: "MessageType");

            //return _unitOfWork.Person.Get(null, x => x.OrderBy(z => z.LastName), includeProperties: "PersonType");

            //return View(courses.ToList());

            var vm = Mapper.Map<IEnumerable<Message>, IEnumerable<MessageViewModel>>(domainModel);
            //var vm = Ok(Mapper.Map<IEnumerable<PersonViewModel>>(domainModel));
            //return (PersonViewModel)vm;
            return vm;

        }


        [HttpPut]
        [Route("message/update")]
        public MessageViewModel Update(Message Message)
        {
            //var domainModel = _unitOfWork.Person.Get(x => x.PersonID == personId).FirstOrDefault();

            //_unitOfWork.Person.Update(domainModel);
            _unitOfWork.Message.Update(Message);
            _unitOfWork.Complete();
            //var vm = Mapper.Map<Person, PersonViewModel>(domainModel);
            var vm = Mapper.Map<Message, MessageViewModel>(Message);
            return vm;
        }



        [Route("message/delete/{messageId}")]
        //api/person/delete/" + personId,
        public MessageViewModel Delete(int messageId)
        {
            var domainModel = _unitOfWork.Message.Get(x => x.MessageID == messageId).FirstOrDefault();

            _unitOfWork.Message.Remove(domainModel);
            _unitOfWork.Complete();
            var vm = Mapper.Map<Message, MessageViewModel>(domainModel);
            return vm;
        }


    }


}
