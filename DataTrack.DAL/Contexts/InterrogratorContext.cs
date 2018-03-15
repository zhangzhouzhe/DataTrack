using DataTrack.DAL.Interrogator;
using System.Data.Entity;

namespace DataTrack.DAL.Contexts
{
    class InterrogratorContext : DbContext
    {
        public DbSet<Source> Sources { get; set; }

        public InterrogratorContext() : base("DataTrack")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
