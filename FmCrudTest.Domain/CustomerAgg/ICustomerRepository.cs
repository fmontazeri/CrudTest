using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FmCrudTest.Domain.CustomerAgg
{
   public interface ICustomerRepository
   {
       Customer GetById(long id);
       void Add(Customer customer);
       void Update(Customer customer);
       void Delete(long id);
   }
}
