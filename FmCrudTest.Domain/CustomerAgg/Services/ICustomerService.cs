using System;

namespace FmCrudTest.Domain.CustomerAgg.Services
{
    public  interface ICustomerService
    {
        bool IsValidMobileNumber(string mobileNumber);
    }
}
