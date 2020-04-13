using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.EntityConfigurations
{
    public class SourceMap : EntityTypeConfiguration<Source>
    {
        public SourceMap ()
        {
           HasRequired(one => one.SourceType)
          .WithMany(one => one.Source)
          .HasForeignKey(one => one.SourceTypeID);


           Property(one => one.SourceName)
          .HasMaxLength(50)
          .IsRequired()
          .IsUnicode(false)
          .HasColumnName("Source");

        }
    }
}