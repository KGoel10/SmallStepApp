using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.ViewModels
{
    public class MessageTypeCreateViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int MessageTypeID { get; set; }
        public string MessageType { get; set; }
        public DateTime CreateDate { get; set; }

    }
}