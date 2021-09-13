using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PROCESA
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString: "ConnectionString") { }

        public DbSet<Cartorio> Cartorios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("public");
            //modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }
        
    }
}
