using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication3.Models.Mapping
{
    public class InOutStepInfoMap : EntityTypeConfiguration<InOutStepInfo>
    {
        public InOutStepInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.InOutStepId);

            // Properties
            this.Property(t => t.InOutStepId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InOutMasterId)
                .HasMaxLength(50);

            this.Property(t => t.EnrolmentRegister)
                .HasMaxLength(50);

            this.Property(t => t.AssayRegister)
                .HasMaxLength(50);

            this.Property(t => t.StorehouseRegister)
                .HasMaxLength(50);

            this.Property(t => t.OnDutyRegister)
                .HasMaxLength(50);

            this.Property(t => t.WeightRegister)
                .HasMaxLength(50);

            this.Property(t => t.SettlementRegister)
                .HasMaxLength(50);

            this.Property(t => t.BackEnrolmentRegister)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InOutStepInfo");
            this.Property(t => t.InOutStepId).HasColumnName("InOutStepId");
            this.Property(t => t.InOutMasterId).HasColumnName("InOutMasterId");
            this.Property(t => t.EnrolmentTime).HasColumnName("EnrolmentTime");
            this.Property(t => t.EnrolmentRegister).HasColumnName("EnrolmentRegister");
            this.Property(t => t.AssayTime).HasColumnName("AssayTime");
            this.Property(t => t.AssayRegister).HasColumnName("AssayRegister");
            this.Property(t => t.StorehouseTime).HasColumnName("StorehouseTime");
            this.Property(t => t.StorehouseRegister).HasColumnName("StorehouseRegister");
            this.Property(t => t.OnDutyTime).HasColumnName("OnDutyTime");
            this.Property(t => t.OnDutyRegister).HasColumnName("OnDutyRegister");
            this.Property(t => t.WeightTime).HasColumnName("WeightTime");
            this.Property(t => t.WeightRegister).HasColumnName("WeightRegister");
            this.Property(t => t.SettlementTime).HasColumnName("SettlementTime");
            this.Property(t => t.SettlementRegister).HasColumnName("SettlementRegister");
            this.Property(t => t.BackEnrolmentTime).HasColumnName("BackEnrolmentTime");
            this.Property(t => t.BackEnrolmentRegister).HasColumnName("BackEnrolmentRegister");

            // Relationships
            this.HasOptional(t => t.SysUser)
                .WithMany(t => t.InOutStepInfoes)
                .HasForeignKey(d => d.AssayRegister);
            this.HasOptional(t => t.SysUser1)
                .WithMany(t => t.InOutStepInfoes1)
                .HasForeignKey(d => d.BackEnrolmentRegister);
            this.HasOptional(t => t.SysUser2)
                .WithMany(t => t.InOutStepInfoes2)
                .HasForeignKey(d => d.EnrolmentRegister);
            this.HasOptional(t => t.SysUser3)
                .WithMany(t => t.InOutStepInfoes3)
                .HasForeignKey(d => d.OnDutyRegister);
            this.HasOptional(t => t.SysUser4)
                .WithMany(t => t.InOutStepInfoes4)
                .HasForeignKey(d => d.SettlementRegister);
            this.HasOptional(t => t.SysUser5)
                .WithMany(t => t.InOutStepInfoes5)
                .HasForeignKey(d => d.StorehouseRegister);
            this.HasOptional(t => t.SysUser6)
                .WithMany(t => t.InOutStepInfoes6)
                .HasForeignKey(d => d.WeightRegister);

        }
    }
}
