using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class WeightFlowRate
    {
        public int WeighFlowRateId { get; set; }
        public string InOutMasterId { get; set; }
        public Nullable<decimal> EachWeight { get; set; }
        public Nullable<System.DateTime> EachWeightTime { get; set; }
        public string InvmasCode { get; set; }
        public Nullable<int> PackageQuantity { get; set; }
        public virtual InOutMaster InOutMaster { get; set; }
        public virtual WarehouseInvma WarehouseInvma { get; set; }
    }
}
