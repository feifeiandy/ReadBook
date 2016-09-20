using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication3.Models.Mapping
{
    public class CustomerRechargeInforMap : EntityTypeConfiguration<CustomerRechargeInfor>
    {
        public CustomerRechargeInforMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("CustomerRechargeInfor");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessCustomerId).HasColumnName("BusinessCustomerId");
            this.Property(t => t.RfidID).HasColumnName("RfidID");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.ExpenseMoney).HasColumnName("ExpenseMoney");
            this.Property(t => t.Balance).HasColumnName("Balance");
            this.Property(t => t.IsStopped).HasColumnName("IsStopped");

            // Relationships
            this.HasRequired(t => t.BusinessCustomer)
                .WithMany(t => t.CustomerRechargeInfors)
                .HasForeignKey(d => d.BusinessCustomerId);
            this.HasOptional(t => t.RFIDTag)
                .WithMany(t => t.CustomerRechargeInfors)
                .HasForeignKey(d => d.RfidID);

        }
    }
}
