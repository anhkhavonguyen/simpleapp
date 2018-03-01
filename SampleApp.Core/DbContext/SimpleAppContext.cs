namespace SampleApp.Core.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SimpleAppContext : DbContext, ISimpleAppDbContext
    {
        public SimpleAppContext()
            : base("name=SimpleAppContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsFixedLength();
        }
    }
}