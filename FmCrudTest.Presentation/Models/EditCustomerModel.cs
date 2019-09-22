using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FmCrudTest.Presentation.CustomeAttribute;

namespace FmCrudTest.Presentation.Models
{
    public class EditCustomerModel
    {
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        [CheckPhoneNumber(AllowRegion = "IR", ErrorMessage = ("Enter your phone number"))]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int BankAccountNumber { get; set; }
    }
}