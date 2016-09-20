using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class InOutMaster
    {
        public InOutMaster()
        {
            this.SettlementMasters = new List<SettlementMaster>();
            this.WeightBridges = new List<WeightBridge>();
            this.WeightFlowRates = new List<WeightFlowRate>();
        }

        public string InOutMasterId { get; set; }
        public Nullable<int> InOutFlag { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public string District { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CarrierName { get; set; }
        public string CarrierCardId { get; set; }
        public string Tel { get; set; }
        public Nullable<int> TrafficType { get; set; }
        public string TravelNum { get; set; }
        public string ContractId { get; set; }
        public string ContractName { get; set; }
        public Nullable<int> PackageType { get; set; }
        public Nullable<int> EnrolmentCount { get; set; }
        public Nullable<int> WeightMode { get; set; }
        public Nullable<bool> ContinuousProcess { get; set; }
        public Nullable<bool> NeedOnduty { get; set; }
        public string OutWarehouse { get; set; }
        public string OutAllocation { get; set; }
        public string InWarehouse { get; set; }
        public string InAllocation { get; set; }
        public Nullable<int> WeighBridgeNum { get; set; }
        public Nullable<decimal> Gross { get; set; }
        public Nullable<decimal> Tare { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<int> PackageQuantity { get; set; }
        public Nullable<decimal> FlowRateWeight { get; set; }
        public Nullable<int> GrainAge { get; set; }
        public string GradeCode { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> DeductedAmount { get; set; }
        public Nullable<decimal> SettlementWeight { get; set; }
        public Nullable<decimal> SettlementMoney { get; set; }
        public Nullable<bool> IsOver { get; set; }
        public Nullable<System.DateTime> BegionTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> RfidCardId { get; set; }
        public string Remark { get; set; }
        public virtual District District1 { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
        public virtual WarehouseAllocation WarehouseAllocation1 { get; set; }
        public virtual QualityGrade QualityGrade { get; set; }
        public virtual RFIDTag RFIDTag { get; set; }
        public virtual SysCompanyInfo SysCompanyInfo { get; set; }
        public virtual WarehouseInvcl WarehouseInvcl { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
        public virtual ICollection<SettlementMaster> SettlementMasters { get; set; }
        public virtual ICollection<WeightBridge> WeightBridges { get; set; }
        public virtual ICollection<WeightFlowRate> WeightFlowRates { get; set; }
    }
}
