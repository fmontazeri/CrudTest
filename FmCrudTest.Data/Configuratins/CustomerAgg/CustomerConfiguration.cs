using System.Data.Entity.ModelConfiguration;
using FmCrudTest.Domain.CustomerAgg;

namespace FmCrudTest.Data.Configuratins.CustomerAgg
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            HasKey(m => m.Id);
            Property(m => m.FirstName).HasMaxLength(50);
            Property(m => m.LastName).HasMaxLength(50); 
            Property(m => m.DateOfBirth);
            Property(m => m.PhoneNumber).HasColumnType("varchar");
            Property(m => m.Email).HasMaxLength(50); ;
            Property(m => m.BankAccountNumber);
            ToTable("Customer");
        }
    }
}
