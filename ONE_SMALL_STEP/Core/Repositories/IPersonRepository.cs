using ONE_SMALL_STEP.Core.Domain;
using ONE_SMALL_STEP.Core.Repositories;
using ONE_SMALL_STEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_SMALL_STEP.Persistence.Repositories
{
    public interface IPersonRepository :IBaseRepository<Person>
    {
        IEnumerable<Person> GetTopPersonsWithMostMessages(int count);
        //List<PersonViewModel> GetPersonVM();

        //IEnumerable<PersonViewModel> GetAllView(int count);

        //public IEnumerable<Book> GetBooks()
        //{
        //    return _context.Books.ToList();

        //}
    }
}
