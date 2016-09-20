using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication3.Models.Mapping
{
    public class SettlementMasterMap : EntityTypeConfiguration<SettlementMaster>
    {
        public SettlementMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.SettlementMasterId);

            // Properties
            this.Property(t => t.SettlementMasterId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InOutMasterId)
                .HasMaxLength(50);

            this.Property(t => t.CustomerCode)
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .HasMaxLength(50);

            this.Property(t => t.ContractNum)
                .HasMaxLength(50);

            this.Property(t => t.VoucherNum)
                .HasMaxLength(50);

            this.Property(t => t.SettlementRegister)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SettlementMaster");
            this.Property(t => t.SettlementMasterId).HasColumnName("SettlementMasterId");
            this.Property(t => t.InOutMasterId).HasColumnName("InOutMasterId");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.DeductedAmount).HasColumnName("DeductedAmount");
            this.Property(t => t.PaymentMode).HasColumnName("PaymentMode");
            this.Property(t => t.CustomerCode).HasColumnName("CustomerCode");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.ContractNum).HasColumnName("ContractNum");
            this.Property(t => t.VoucherNum).HasColumnName("VoucherNum");
            this.Property(t => t.SettlementWeight).HasColumnName("SettlementWeight");
            this.Property(t => t.SettlementMoney).HasColumnName("SettlementMoney");
            this.Property(t => t.SettlementTime).HasColumnName("SettlementTime");
            this.Property(t => t.SettlementRegister).HasColumnName("SettlementRegister");

            // Relationships
            this.HasOptional(t => t.InOutMaster)
                .WithMany(t => t.SettlementMasters)
                .HasForeignKey(d => d.InOutMasterId);
            this.HasOptional(t => t.SysCompanyInfo)
                .WithMany(t => t.SettlementMasters)
                .HasForeignKey(d => d.CustomerCode);
            this.HasOptional(t => t.SysUser)
                .WithMany(t => t.SettlementMasters)
                .HasForeignKey(d => d.SettlementRegister);

        }
    }
}
