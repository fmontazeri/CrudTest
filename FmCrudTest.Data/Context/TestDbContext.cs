using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmCrudTest.Data.Configuratins;
using FmCrudTest.Data.Configuratins.CustomerAgg;
using FmCrudTest.Domain.CustomerAgg;

namespace FmCrudTest.Data.Context
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() :base("TestDbContext") 
        {
            // Database.SetInitializer<TestDbContext>(new ApplicationDbConfiguration());
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Configurations.Add(new CustomerMapping());

            modelBuilder.Entity<Customer>()
                .HasIndex(p => p.Email)
                .IsUnique(true);
            modelBuilder.Entity<Customer>()
                .HasIndex(p => new { p.FirstName, p.LastName, p.DateOfBirth })
                .IsUnique(true);

          
            base.OnModelCreating(modelBuilder);
        }
       
    }
}
