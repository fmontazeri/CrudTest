using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmCrudTest.Data.Context;
using FmCrudTest.Domain.CustomerAgg.Services;

namespace FmCrudTest.Data.Services
{
    public class CustomerService : ICustomerService
    {

        public bool IsValidMobileNumber(string mobileNumber)
        {
            return true;
        }

    }
}
