using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class WarehouseCarryOverByMonth
    {
        public int Id { get; set; }
        public System.DateTime CarryOverMonth { get; set; }
        public string WarehouseCode { get; set; }
        public string AllocationCode { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public decimal LastAmount { get; set; }
        public Nullable<decimal> CurrentInAmount { get; set; }
        public Nullable<decimal> CurrentOutAmount { get; set; }
        public decimal CurrentAmount { get; set; }
    }
}
