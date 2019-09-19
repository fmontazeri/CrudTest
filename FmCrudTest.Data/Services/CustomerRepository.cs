using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using FmCrudTest.Data.Context;
using FmCrudTest.Domain.CustomerAgg;

namespace FmCrudTest.Data.Services
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

        public List<Customer> GetAll()
        {
            return dbContext.Customers.ToList();
        }

        public void Add(Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }

        public void Update(Customer customer)
        {
            var findCustomer = dbContext.Customers.Find(customer.Id);
            if (findCustomer != null)
            {
                dbContext.Customers.AddOrUpdate(customer);
                dbContext.SaveChanges();
            }
        }

        public void Delete(long id)
        {
            var customer = dbContext.Customers.Find(id);
            if (customer != null)
            {
                dbContext.Customers.Remove(customer);
                dbContext.SaveChanges();
            }
        }

        
    }
}
