﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmCrudTest.Data.Configuratins.CustomerAgg;
using FmCrudTest.Domain.CustomerAgg;

namespace FmCrudTest.Data.Context
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() : base(@"Data Source=MONTAZERI-PC\SQLDEV;Initial Catalog=FmCrudSample;User Id=sa;Password=1404;")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Configurations.Add(new CustomerMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}