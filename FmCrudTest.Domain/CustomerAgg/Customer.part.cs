using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FmCrudTest.Domain.CustomerAgg.Exceptions;

namespace FmCrudTest.Domain.CustomerAgg
{
    public partial class Customer
    {
        public Customer(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, int bankAccountNumber)
        {
            GuardAgainstEmptyPhoneNumber(phoneNumber);
            //GuardAgainstInvalidPhoneNumber(GetProperPhoneNumber(phoneNumber));

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber.Trim();
            Email = email;
            BankAccountNumber = bankAccountNumber;
        }

      

        public  Customer Update(string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, int bankAccountNumber)
        {
            GuardAgainstEmptyPhoneNumber(phoneNumber);

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber.Trim();
            Email = email;
            BankAccountNumber = bankAccountNumber;
            return this;
        }

        private void GuardAgainstEmptyPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrWhiteSpace(phoneNumber))
                throw new InvalidPhoneNumberException("Enter Youe phone number , please");
        }
        private void GuardAgainstInvalidPhoneNumber(string phoneNumber)
        {
            if (!int.TryParse(phoneNumber, out int validPhoneNumber))
                throw new InvalidPhoneNumberException("Enter Your phone number in correct format");
        }

        private string GetProperPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "");
        }
    }
}
