using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FmCrudTest.Domain.CustomerAgg
{
    public partial class Customer
    {
        public Customer(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, int bankAccountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            BankAccountNumber = bankAccountNumber;
        }
    }
}
