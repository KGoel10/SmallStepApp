using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.EntityConfigurations
{
    public class PersonMessageMap : EntityTypeConfiguration<PersonMessage>
    {
    
   
        public PersonMessageMap()
        {
            HasKey(c => new { c.PersonID, c.MessageID });
            //HasKey(one => one.PersonID);

        }
    }
}
 
 