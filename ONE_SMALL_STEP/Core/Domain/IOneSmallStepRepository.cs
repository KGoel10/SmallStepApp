using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_SMALL_STEP.Core.Domain
{
    interface IOneSmallStepRepository
    {
        IQueryable<Person>GetPerson();      
        IQueryable<PersonType> GetPersonType();
    }
}
