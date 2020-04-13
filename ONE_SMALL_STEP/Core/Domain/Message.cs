using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class Message
    {
        
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


        public virtual ICollection<PersonMessage> PersonMessages { get; set; }
    
        
    }
}