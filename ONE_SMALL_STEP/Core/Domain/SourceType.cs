using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class SourceType
    {
        public int SourceTypeID { get; set; }
        public string SourceTypeName { get; set; }

        public ICollection<Source> Source { get; set; }
    }
}