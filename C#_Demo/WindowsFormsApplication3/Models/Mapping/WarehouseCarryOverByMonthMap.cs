using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication3.Models.Mapping
{
    public class WarehouseCarryOverByMonthMap : EntityTypeConfiguration<WarehouseCarryOverByMonth>
    {
        public WarehouseCarryOverByMonthMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.WarehouseCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AllocationCode)
                .HasMaxLength(50);

            this.Property(t => t.InvclsCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WarehouseCarryOverByMonth");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CarryOverMonth).HasColumnName("CarryOverMonth");
            this.Property(t => t.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(t => t.AllocationCode).HasColumnName("AllocationCode");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.LastAmount).HasColumnName("LastAmount");
            this.Property(t => t.CurrentInAmount).HasColumnName("CurrentInAmount");
            this.Property(t => t.CurrentOutAmount).HasColumnName("CurrentOutAmount");
            this.Property(t => t.CurrentAmount).HasColumnName("CurrentAmount");
        }
    }
}
