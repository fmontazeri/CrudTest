using System.Data.Entity.ModelConfiguration;
using FmCrudTest.Domain.CustomerAgg;

namespace FmCrudTest.Data.Configuratins.CustomerAgg
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            HasKey(m => m.Id);
            Property(m => m.FirstName);
            Property(m => m.LastName);
            Property(m => m.DateOfBirth);
            Property(m => m.PhoneNumber);
            Property(m => m.Email);
            Property(m => m.BankAccountNumber);
            ToTable("Customer");
        }
    }
}
