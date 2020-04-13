using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Screenshot { get; set; }
        //public DateTime CreatedDate { get; set; }


        private DateTime? _DateCreated = null;

        public DateTime DateCreated
        {
            get
            {
                return this._DateCreated.HasValue
                   ? this._DateCreated.Value
                   : DateTime.Now;
            }

            set { this._DateCreated = value; }
        }

        


        public int PersonTypeID { get; set; }
        public PersonType PersonType { get; set; }
        public ICollection<PersonMessage> PersonMessage { get; set; }

        public int SourceID { get; set; }

        public Source Source { get; set; }



        //[ForeignKey("personTypeId")]
        //public PersonType PersonType { get; set; }
        //public virtual ICollection<PersonType> PersonType { get; set; }
        //public ICollection<Message> Message { get; set; }

        //public int PersonTypeId { get; set; }
        //


        //look into the option below later (for lazy loading deal)

        //public virtual ICollection<PersonMessage> PersonMessages { get; set; }

    }
}