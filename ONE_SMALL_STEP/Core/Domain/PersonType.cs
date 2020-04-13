using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class PersonType
    {
        public int PersonTypeID { get; set; }
        [Display(Name = "Contact Type")]
        public string PersonTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        //look into the option below later (for lazy loading deal)
        //public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<Person> Person { get; set; }

   
        //public PersonType()
        //{
        //    Persons = new Collection<Person>();
        //}


    }
}