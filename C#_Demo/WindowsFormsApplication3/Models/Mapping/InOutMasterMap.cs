using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WindowsFormsApplication3.Models.Mapping
{
    public class InOutMasterMap : EntityTypeConfiguration<InOutMaster>
    {
        public InOutMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.InOutMasterId);

            // Properties
            this.Property(t => t.InOutMasterId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.InvclsCode)
                .HasMaxLength(50);

            this.Property(t => t.InvmasCode)
                .HasMaxLength(50);

            this.Property(t => t.District)
                .HasMaxLength(50);

            this.Property(t => t.CustomerCode)
                .HasMaxLength(50);

            this.Property(t => t.CustomerName)
                .HasMaxLength(50);

            this.Property(t => t.CarrierName)
                .HasMaxLength(50);

            this.Property(t => t.CarrierCardId)
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .HasMaxLength(50);

            this.Property(t => t.TravelNum)
                .HasMaxLength(50);

            this.Property(t => t.ContractId)
                .HasMaxLength(50);

            this.Property(t => t.ContractName)
                .HasMaxLength(50);

            this.Property(t => t.OutWarehouse)
                .HasMaxLength(50);

            this.Property(t => t.OutAllocation)
                .HasMaxLength(50);

            this.Property(t => t.InWarehouse)
                .HasMaxLength(50);

            this.Property(t => t.InAllocation)
                .HasMaxLength(50);

            this.Property(t => t.GradeCode)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("InOutMaster");
            this.Property(t => t.InOutMasterId).HasColumnName("InOutMasterId");
            this.Property(t => t.InOutFlag).HasColumnName("InOutFlag");
            this.Property(t => t.InvclsCode).HasColumnName("InvclsCode");
            this.Property(t => t.InvmasCode).HasColumnName("InvmasCode");
            this.Property(t => t.District).HasColumnName("District");
            this.Property(t => t.CustomerCode).HasColumnName("CustomerCode");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.CarrierName).HasColumnName("CarrierName");
            this.Property(t => t.CarrierCardId).HasColumnName("CarrierCardId");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.TrafficType).HasColumnName("TrafficType");
            this.Property(t => t.TravelNum).HasColumnName("TravelNum");
            this.Property(t => t.ContractId).HasColumnName("ContractId");
            this.Property(t => t.ContractName).HasColumnName("ContractName");
            this.Property(t => t.PackageType).HasColumnName("PackageType");
            this.Property(t => t.EnrolmentCount).HasColumnName("EnrolmentCount");
            this.Property(t => t.WeightMode).HasColumnName("WeightMode");
            this.Property(t => t.ContinuousProcess).HasColumnName("ContinuousProcess");
            this.Property(t => t.NeedOnduty).HasColumnName("NeedOnduty");
            this.Property(t => t.OutWarehouse).HasColumnName("OutWarehouse");
            this.Property(t => t.OutAllocation).HasColumnName("OutAllocation");
            this.Property(t => t.InWarehouse).HasColumnName("InWarehouse");
            this.Property(t => t.InAllocation).HasColumnName("InAllocation");
            this.Property(t => t.WeighBridgeNum).HasColumnName("WeighBridgeNum");
            this.Property(t => t.Gross).HasColumnName("Gross");
            this.Property(t => t.Tare).HasColumnName("Tare");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.PackageQuantity).HasColumnName("PackageQuantity");
            this.Property(t => t.FlowRateWeight).HasColumnName("FlowRateWeight");
            this.Property(t => t.GrainAge).HasColumnName("GrainAge");
            this.Property(t => t.GradeCode).HasColumnName("GradeCode");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.DeductedAmount).HasColumnName("DeductedAmount");
            this.Property(t => t.SettlementWeight).HasColumnName("SettlementWeight");
            this.Property(t => t.SettlementMoney).HasColumnName("SettlementMoney");
            this.Property(t => t.IsOver).HasColumnName("IsOver");
            this.Property(t => t.BegionTime).HasColumnName("BegionTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.RfidCardId).HasColumnName("RfidCardId");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasOptional(t => t.District1)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.District);
            this.HasOptional(t => t.Warehouse)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.InWarehouse);
            this.HasOptional(t => t.WarehouseAllocation)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.InAllocation);
            this.HasOptional(t => t.Warehouse1)
                .WithMany(t => t.InOutMasters1)
                .HasForeignKey(d => d.OutWarehouse);
            this.HasOptional(t => t.WarehouseAllocation1)
                .WithMany(t => t.InOutMasters1)
                .HasForeignKey(d => d.OutAllocation);
            this.HasOptional(t => t.QualityGrade)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.GradeCode);
            this.HasOptional(t => t.RFIDTag)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.RfidCardId);
            this.HasOptional(t => t.SysCompanyInfo)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.CustomerCode);
            this.HasOptional(t => t.WarehouseInvcl)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.InvclsCode);
            this.HasOptional(t => t.WarehouseInvma)
                .WithMany(t => t.InOutMasters)
                .HasForeignKey(d => d.InvmasCode);

        }
    }
}
