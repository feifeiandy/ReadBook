using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class WeightBridge
    {
        public string BridgeWeighId { get; set; }
        public string InOutMasterId { get; set; }
        public Nullable<int> TraveId { get; set; }
        public string TravelNum { get; set; }
        public Nullable<int> InOutFlag { get; set; }
        public Nullable<int> WeightMode { get; set; }
        public Nullable<bool> NeedOnduty { get; set; }
        public Nullable<decimal> Gross { get; set; }
        public Nullable<System.DateTime> GrossTime { get; set; }
        public string GrossRegister { get; set; }
        public Nullable<decimal> Tare { get; set; }
        public Nullable<System.DateTime> TareTime { get; set; }
        public string TareRegister { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<System.DateTime> WeightTime { get; set; }
        public string InvmasCode { get; set; }
        public Nullable<int> PackageQuantity { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public virtual InOutMaster InOutMaster { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysUser SysUser1 { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
