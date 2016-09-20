using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication3.Models.Mapping
{
    public class WeightBridgeMap : EntityTypeConfiguration<WeightBridge>
    {
        public WeightBridgeMap()
        {
            // Primary Key
            this.HasKey(t => t.BridgeWeighId);

            // Properties
            this.Property(t => t.BridgeWeighId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InOutMasterId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TravelNum)
                .HasMaxLength(50);

            this.Property(t => t.GrossRegister)
                .HasMaxLength(50);

            this.Property(t => t.TareRegister)
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WeightBridge");
            this.Property(t => t.BridgeWeighId).HasColumnName("BridgeWeighId");
            this.Property(t => t.InOutMasterId).HasColumnName("InOutMasterId");
            this.Property(t => t.TraveId).HasColumnName("TraveId");
            this.Property(t => t.TravelNum).HasColumnName("TravelNum");
            this.Property(t => t.InOutFlag).HasColumnName("InOutFlag");
            this.Property(t => t.WeightMode).HasColumnName("WeightMode");
            this.Property(t => t.NeedOnduty).HasColumnName("NeedOnduty");
            this.Property(t => t.Gross).HasColumnName("Gross");
            this.Property(t => t.GrossTime).HasColumnName("GrossTime");
            this.Property(t => t.GrossRegister).HasColumnName("GrossRegister");
            this.Property(t => t.Tare).HasColumnName("Tare");
            this.Property(t => t.TareTime).HasColumnName("TareTime");
            this.Property(t => t.TareRegister).HasColumnName("TareRegister");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.WeightTime).HasColumnName("WeightTime");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.PackageQuantity).HasColumnName("PackageQuantity");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");

            // Relationships
            this.HasRequired(t => t.InOutMaster)
                .WithMany(t => t.WeightBridges)
                .HasForeignKey(d => d.InOutMasterId);
            this.HasOptional(t => t.SysUser)
                .WithMany(t => t.WeightBridges)
                .HasForeignKey(d => d.GrossRegister);
            this.HasOptional(t => t.SysUser1)
                .WithMany(t => t.WeightBridges1)
                .HasForeignKey(d => d.TareRegister);
            this.HasOptional(t => t.WarehouseInvma)
                .WithMany(t => t.WeightBridges)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
