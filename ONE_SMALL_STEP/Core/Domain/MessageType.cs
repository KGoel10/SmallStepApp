using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class MessageType
    {
        public int MessageTypeID { get; set; }
        public string MessageTypeName { get; set; }  

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

        //public virtual ICollection<Message> Message { get; set; }
        public virtual ICollection<Message> Message { get; set; }

    }
}