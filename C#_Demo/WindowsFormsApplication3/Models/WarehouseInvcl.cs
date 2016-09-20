using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class WarehouseInvcl
    {
        public WarehouseInvcl()
        {
            this.InOutMasters = new List<InOutMaster>();
            this.WarehouseAmounts = new List<WarehouseAmount>();
            this.WarehouseAmountTransDetails = new List<WarehouseAmountTransDetail>();
            this.WarehouseInvcls1 = new List<WarehouseInvcl>();
            this.WarehouseInvmas = new List<WarehouseInvma>();
        }

        public string InvclsCode { get; set; }
        public string Name { get; set; }
        public string ParentCode { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<InOutMaster> InOutMasters { get; set; }
        public virtual ICollection<WarehouseAmount> WarehouseAmounts { get; set; }
        public virtual ICollection<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
        public virtual ICollection<WarehouseInvcl> WarehouseInvcls1 { get; set; }
        public virtual WarehouseInvcl WarehouseInvcl1 { get; set; }
        public virtual ICollection<WarehouseInvma> WarehouseInvmas { get; set; }
    }
}
