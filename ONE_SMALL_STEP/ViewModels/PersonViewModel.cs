using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.ViewModels
{
    public class PersonViewModel
    {
        //public List<PersonType> personTypeList { get; set; }
        //public List<Person> personlist { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int PersonID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
        public string Screenshot { get; set; }
        //public Person person { get; set; }
        [Display(Name = "Contact Type")]
        //public PersonType PersonTypeName { get; set; }
        public string PersonType { get; set; }

        //public int PersonTypeID { get; set; }
        //public PersonType PersonType { get; set; }
        //public ICollection<PersonMessage> PersonMessage { get; set; }


    }
}

