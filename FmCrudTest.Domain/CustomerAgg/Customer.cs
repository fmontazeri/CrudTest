using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FmCrudTest.Domain.CustomerAgg
{
    public partial class Customer
    {
        protected Customer()
        {
        }

        public long Id { get; private set; }
        public string FirstName { get; private set; }
        public  string  LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public int  BankAccountNumber { get; private set; }
    }
}
