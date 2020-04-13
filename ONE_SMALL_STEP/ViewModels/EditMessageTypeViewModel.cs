using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.ViewModels
{
    public class EditMessageTypeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int MessageTypeID { get; set; }

        [Display(Name = "Message Type")]  
        public string MessageTypeName { get; set; }     
 
        [System.ComponentModel.DefaultValue(typeof(DateTime), "")]
        public DateTime CreateDate { get; set; }
    }
}