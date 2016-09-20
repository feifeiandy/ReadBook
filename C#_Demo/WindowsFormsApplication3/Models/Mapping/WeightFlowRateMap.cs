using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication3.Models.Mapping
{
    public class WeightFlowRateMap : EntityTypeConfiguration<WeightFlowRate>
    {
        public WeightFlowRateMap()
        {
            // Primary Key
            this.HasKey(t => t.WeighFlowRateId);

            // Properties
            this.Property(t => t.InOutMasterId)
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("WeightFlowRate");
            this.Property(t => t.WeighFlowRateId).HasColumnName("WeighFlowRateId");
            this.Property(t => t.InOutMasterId).HasColumnName("InOutMasterId");
            this.Property(t => t.EachWeight).HasColumnName("EachWeight");
            this.Property(t => t.EachWeightTime).HasColumnName("EachWeightTime");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.PackageQuantity).HasColumnName("PackageQuantity");

            // Relationships
            this.HasOptional(t => t.InOutMaster)
                .WithMany(t => t.WeightFlowRates)
                .HasForeignKey(d => d.InOutMasterId);
            this.HasOptional(t => t.WarehouseInvma)
                .WithMany(t => t.WeightFlowRates)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
