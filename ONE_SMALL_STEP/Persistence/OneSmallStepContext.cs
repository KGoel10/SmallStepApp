using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ONE_SMALL_STEP.Persistence.EntityConfigurations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace ONE_SMALL_STEP.Core.Domain
{
    public class OneSmallStepContext : DbContext
    {
        //

        public OneSmallStepContext()
            : base("DefaultConnection")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            Database.Log = s => Debug.WriteLine(s);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<OneSmallStepContext, MessageBoardMigrationsConfiguration>());
            //Database.SetInitializer<OneSmallStepContext>(new DropCreateDatabaseIfModelChanges<OneSmallStepContext>());
        }

        public DbSet<Message> Message { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonType> PersonType { get; set; }
        public DbSet<MessageType> MessageType { get; set; }
        public DbSet<PersonMessage> PersonMessage { get; set; }
        public DbSet<SourceType> SourceType { get; set; }
        public DbSet<Source> Source { get; set; }
        



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new PersonTypeMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new MessageTypeMap());
            modelBuilder.Configurations.Add(new PersonMessageMap());
            modelBuilder.Configurations.Add(new SourceTypeMap());
            modelBuilder.Configurations.Add(new SourceMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      

     



            //modelBuilder.Entity<Person>().Property(c => c.createdDate)
            //    .HasDefaultValueSql()
            //    //.Property(p => p.createdDate).hasdef


            //modelBuilder
            //    .Entity<Person>()

            //    .HasRequired(pt => pt.PersonType)
            //    .WithMany(p => p.per)

            //.HasMany(pt => pt.PersonType)
            //.WithRequired(p => p.personTypeId)
            //.has


            //.HasRequired(p => p.PersonType)
            //.WithMany(pt => pt.personTypeId)


            //.WithMany(pt => pt.personTypeId)





            //modelBuilder.Entity<Person>(entity =>
            //{




            //     modelBuilder.Entity<Person>()
            //.HasRequired(pt => pt.PersonType)
            //.WithMany(pt => pt.Persons)
            //         .HasForeignKey(p => p.personTypeId)
            //         .WillCascadeOnDelete(false)
            //         .HasConstraintName("ForeignKey_Post_Blog");






            //});
            //base.OnModelCreating(modelBuilder);

        }

    }
  
}