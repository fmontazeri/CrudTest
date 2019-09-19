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
            Property(m => m.DateOfBirth).HasColumnType("date");
            Property(m => m.PhoneNumber).HasColumnType("varchar").HasMaxLength(11);
            Property(m => m.Email).HasMaxLength(50); ;
            Property(m => m.BankAccountNumber);
            ToTable("Customer");
        }
    }
}
