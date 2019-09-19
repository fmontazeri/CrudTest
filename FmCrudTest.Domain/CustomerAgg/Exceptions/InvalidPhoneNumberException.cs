using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FmCrudTest.Domain.CustomerAgg.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message) : base("The Phone Number is invalid!")
        {
        }
    }
}
