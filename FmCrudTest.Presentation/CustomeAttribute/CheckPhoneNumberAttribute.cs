using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FmCrudTest.Domain;
using PhoneNumbers;

namespace FmCrudTest.Presentation.CustomeAttribute
{
    public class CheckPhoneNumberAttribute : ValidationAttribute
    {
        public string AllowRegion { get; set; }

        public override bool IsValid(object value)
        {
            String numberStr = (string)value;

            var util = PhoneNumberUtil.GetInstance();
            try
            {
                var number = util.Parse(numberStr, AllowRegion);
                bool isValid = util.IsValidNumber(number);
                return isValid;
            }
            catch (NumberParseException)
            {
                return false;
            }

        }

    }
}