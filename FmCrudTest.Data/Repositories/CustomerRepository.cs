﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmCrudTest.Data.Context;
using FmCrudTest.Domain.CustomerAgg;

namespace FmCrudTest.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly TestDbContext dbContext;

        public CustomerRepository(TestDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Customer GetById(long id)
        {
            return dbContext.Customers.Find(id);
        }

        public void Add(Customer customer)
        {
            dbContext.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            var findCustomer = dbContext.Customers.Find(customer.Id);
            if(findCustomer != null)
            dbContext.Customers.AddOrUpdate(customer);
        }

        public void Delete(long id)
        {
            var customer = dbContext.Customers.Find(id);
            if(customer != null)
            dbContext.Customers.Remove(customer);
        }
    }
}
