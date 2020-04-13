using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class Source
    {
        public int SourceID { get; set; }
        public string SourceName { get; set; }
        public int SourceTypeID { get; set; }

        public SourceType SourceType { get; set; }

        public ICollection<Person> Person { get; set; }
    }
}