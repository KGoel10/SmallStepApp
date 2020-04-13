using ONE_SMALL_STEP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.EntityConfigurations
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            
            HasRequired(one => one.MessageType)
           .WithMany(one => one.Message)
           .HasForeignKey(one => one.MessageTypeID);


            Property(one => one.MessageTypeID)
            .HasColumnName("MessageTypeID");


            //Property(one => one.MessageID)
            //.HasColumnOrder(0);

            //Property(one => one.MessageTypeID)
            //.HasColumnOrder(1);

            //Property(one => one.MessageName)
            //.HasColumnOrder(2);

            Property(one => one.MessageDescription)
            .HasMaxLength(30)
            .IsRequired()
            .IsUnicode(false)
            .HasColumnOrder(3);


            Property(one => one.MessageFileName)
            .HasColumnOrder(4);

            Property(one => one.MessageLocation)
            .HasColumnOrder(5);

            Property(one => one.DateCreated)
            .HasColumnOrder(6);

            Property(one => one.DateCreated)
            .HasColumnOrder(7);

            Property(one => one.DateUpdated)
            .HasColumnOrder(8);

        }
    }
}