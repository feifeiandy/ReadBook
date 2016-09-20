using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class SettlementMaster
    {
        public string SettlementMasterId { get; set; }
        public string InOutMasterId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> DeductedAmount { get; set; }
        public Nullable<int> PaymentMode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ContractNum { get; set; }
        public string VoucherNum { get; set; }
        public Nullable<decimal> SettlementWeight { get; set; }
        public Nullable<decimal> SettlementMoney { get; set; }
        public Nullable<System.DateTime> SettlementTime { get; set; }
        public string SettlementRegister { get; set; }
        public virtual InOutMaster InOutMaster { get; set; }
        public virtual SysCompanyInfo SysCompanyInfo { get; set; }
        public virtual SysUser SysUser { get; set; }
    }
}
