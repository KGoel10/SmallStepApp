using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.EntityConfigurations
{
    public class SourceTypeMap: EntityTypeConfiguration<Core.Domain.SourceType>
    {
        public SourceTypeMap()
        {
            Property(one => one.SourceTypeName)
                .HasMaxLength(30)
                .IsRequired().IsUnicode(false);


             Property(one => one.SourceTypeName)
            .HasMaxLength(30)
            .IsRequired()
            .IsUnicode(false)
            .HasColumnName("SourceType");

        }
    }
}