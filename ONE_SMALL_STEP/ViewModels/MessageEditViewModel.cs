using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONE_SMALL_STEP.ViewModels
{
    public class MessageEditViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int MessageID { get; set; }
        //public int PersonTypeID { get; set;}

        public int MessageTypeID { get; set; }
        [Display(Name = "Type")]
        public IEnumerable<MessageType> MessageTypes { get; set; }

        [Display(Name = "Name")]
        public string MessageName { get; set; }
        [Display(Name = "Description")]
        public string MessageDescription { get; set; }
        public string MessageFileName { get; set; }

        public string MessageLocation { get; set; }
        //public string Screenshot { get; set; }
        //[System.ComponentModel.DefaultValue(typeof(DateTime), "")]
        //public DateTime CreateDate { get; set; }

        [System.ComponentModel.DefaultValue(typeof(DateTime), "")]
        public DateTime DateCreated { get; set; }


        [System.ComponentModel.DefaultValue(typeof(DateTime), "")]
        public DateTime DateUpdated { get; set; }


        /*
        public int MessageID { get; set; }
        public int MessageTypeID { get; set; }
        public string MessageName { get; set; }
        public string MessageDescription { get; set; }
        public MessageType MessageType { get; set; }
        public string MessageFileName { get; set; }
        public string MessageLocation { get; set; }

        private DateTime? _dateCreated = null;
        public DateTime DateCreated
        {
            get
            {
                return this._dateCreated.HasValue
                   ? this._dateCreated.Value
                   : DateTime.Now;
            }

            set { this._dateCreated = value; }
        }

        private DateTime? _dateUpdated = null;
        public DateTime DateUpdated

        {
            get
            {
                return this._dateUpdated.HasValue
                   ? this._dateUpdated.Value
                   : DateTime.Now;
            }

            set { this._dateUpdated = value; }
        }

    */

    }
}