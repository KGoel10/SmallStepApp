using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.ViewModels
{
    public class MessageViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int MessageID { get; set; }
        public string MessageName { get; set; }
        //public int MessageTypeID { get; set; }

        [Display(Name = "Message Type")]
        //public PersonType PersonTypeName { get; set; }
        public string MessageType { get; set; }

        public string MessageFileName { get; set; }
        public string MessageLocation { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime DateUpdate { get; set; }




    }
}