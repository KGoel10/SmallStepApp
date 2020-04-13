using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.ViewModels
{
    public class CreatePersonViewModel
    {
        public int PersonID { get; set; }
        //public int PersonTypeID { get; set;}

        public int PersonTypeID { get; set; }
        [Display(Name = "Contact Type")]
        public IEnumerable<PersonType> PersonTypes { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Screenshot { get; set; }
        [System.ComponentModel.DefaultValue(typeof(DateTime), "")]
        public DateTime CreateDate { get; set; }
        

        //public CreatePersonViewModel()
        //{
        //    PersonID = 0;
        //}


        //public CreatePersonViewModel(Person person)
        //{
        //    PersonID = person.PersonID;
        //    FirstName = person.FirstName;
        //    LastName = person.LastName;
        //    EmailAddress = person.EmailAddress;
        //    Screenshot = person.Screenshot;
        //    PersonTypeID = person.PersonTypeID;         
        //}



        //public Person person { get; set; }



    }
}