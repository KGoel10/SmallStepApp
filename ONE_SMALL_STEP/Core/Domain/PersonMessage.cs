using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class PersonMessage
    {
        public int PersonID { get; set; }
        public virtual Message message { get; set; }
        public int MessageID { get; set; }
        public virtual Person person { get; set; }
        public DateTime CreatedDAte { get; set; }

        //public int PersonID { get; set; }


        //public ICollection<Person> Person { get; set; }
        //public ICollection<Message> Message { get; set; }
    }
}