using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class WarehouseAllocation
    {
        public WarehouseAllocation()
        {
            this.InOutMasters = new List<InOutMaster>();
            this.InOutMasters1 = new List<InOutMaster>();
            this.ManuPlanTaskBatchInWarehouses = new List<ManuPlanTaskBatchInWarehouse>();
            this.ManuPlanTaskBatchOutWarehouses = new List<ManuPlanTaskBatchOutWarehouse>();
            this.ManuPlanTaskBatchTransDetails = new List<ManuPlanTaskBatchTransDetail>();
            this.WarehouseAmounts = new List<WarehouseAmount>();
            this.WarehouseAmountTransDetails = new List<WarehouseAmountTransDetail>();
            this.WarehouseBatchMasters = new List<WarehouseBatchMaster>();
        }

        public string AllocationCode { get; set; }
        public string Name { get; set; }
        public string WarehouseCode { get; set; }
        public bool Stopped { get; set; }
        public string Remark { get; set; }
        public bool NeedBatchManager { get; set; }
        public virtual ICollection<InOutMaster> InOutMasters { get; set; }
        public virtual ICollection<InOutMaster> InOutMasters1 { get; set; }
        public virtual ICollection<ManuPlanTaskBatchInWarehouse> ManuPlanTaskBatchInWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchOutWarehouse> ManuPlanTaskBatchOutWarehouses { get; set; }
        public virtual ICollection<ManuPlanTaskBatchTransDetail> ManuPlanTaskBatchTransDetails { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<WarehouseAmount> WarehouseAmounts { get; set; }
        public virtual ICollection<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
        public virtual ICollection<WarehouseBatchMaster> WarehouseBatchMasters { get; set; }
    }
}
