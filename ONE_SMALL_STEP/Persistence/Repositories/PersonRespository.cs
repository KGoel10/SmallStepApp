using AutoMapper;
using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.Core.Repositories;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.Repositories
{
    public class PersonRespository : Repository<Person>, IPersonRepository
    {
        public PersonRespository(OneSmallStepContext context)
            :base(context)
        {
        }
        //public IEnumerable<Person> GetTopPersonsWithMostMessages(int count)
        //{
        //    //throw new NotImplementedException();
        //    return OneSmallStepContext.Person
        //        //.Include(c => c.PersonType)
        //        .ToList();
        //}

        public OneSmallStepContext OneSmallStepContext
        {
            get { return Context as OneSmallStepContext; }
        }



    //    var vm = _context.Person
    //.Include("PersonType")
    //.ToList().Select(Mapper.Map<Person, PersonViewModel>);



        //public void Add(Person entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddRange(IEnumerable<Person> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Person> Find(Expression<Func<Person, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<PersonViewModel> GetPersonVM()
        //{
        //    //throw new NotImplementedException();
        //    //return 
        //    //var query = OneSmallStepContext.Person.ToList().Select(Mapper.CreateMap<Person, PersonViewModel>());
        //    //var query = OneSmallStepContext.Person.ToList().Select(Mapper.CreateMap<Person, PersonViewModel>());
        //    var person = OneSmallStepContext.Person.ToList();

        //    //var personVM = Mapper.Map<List<Person>, List<PersonViewModel>>(person);
        //    var personVM = Mapper.Map<List<PersonViewModel>>(person);
        //    return personVM;
        //}

        //public IEnumerable<PersonViewModel> GetPersonVM()
        //{
        //    //var PersonViewModel = new PersonViewModel();

        //    //return PersonViewModel.to .ToList();     
        //    IEnumerable<PersonViewModel> personVM = OneSmallStepContext.Person.ma
        //    //throw new NotImplementedException();
        //}

        public IEnumerable<Person> GetTopPersonsWithMostMessages(int count)
        {
            throw new NotImplementedException();
        }

        //public void Remove(Person entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRange(IEnumerable<Person> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public Person SingleOrDefault(Expression<Func<Person, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //Person IBaseRepository<Person>.Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

   
        //IEnumerable<Person> IBaseRepository<Person>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}