using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.ViewModels
{
    public class MessageTypeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int MessageTypeID { get; set; }
        public string MessageTypeName { get; set; }
    }
}