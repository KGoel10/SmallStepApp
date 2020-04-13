using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.EntityConfigurations
{
    public class MessageTypeMap : EntityTypeConfiguration<MessageType>
    {
        public MessageTypeMap()
        {


            Property(one => one.MessageTypeName)
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("MessageType");
        }
    }
}