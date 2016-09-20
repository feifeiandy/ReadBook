using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class SysUser
    {
        public SysUser()
        {
            this.InOutStepInfoes = new List<InOutStepInfo>();
            this.InOutStepInfoes1 = new List<InOutStepInfo>();
            this.InOutStepInfoes2 = new List<InOutStepInfo>();
            this.InOutStepInfoes3 = new List<InOutStepInfo>();
            this.InOutStepInfoes4 = new List<InOutStepInfo>();
            this.InOutStepInfoes5 = new List<InOutStepInfo>();
            this.InOutStepInfoes6 = new List<InOutStepInfo>();
            this.SettlementMasters = new List<SettlementMaster>();
            this.WeightBridges = new List<WeightBridge>();
            this.WeightBridges1 = new List<WeightBridge>();
            this.Warehouses = new List<Warehouse>();
            this.Warehouses1 = new List<Warehouse>();
        }

        public string UserCode { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public bool NeedChangePassword { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public int Sex { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string OfficialPhone { get; set; }
        public string Position { get; set; }
        public bool Stopped { get; set; }
        public bool IsLeader { get; set; }
        public string Remark { get; set; }
        public bool IsOnline { get; set; }
        public byte[] Picture { get; set; }
        public string DepartmentCode { get; set; }
        public virtual ICollection<InOutStepInfo> InOutStepInfoes { get; set; }
        public virtual ICollection<InOutStepInfo> InOutStepInfoes1 { get; set; }
        public virtual ICollection<InOutStepInfo> InOutStepInfoes2 { get; set; }
        public virtual ICollection<InOutStepInfo> InOutStepInfoes3 { get; set; }
        public virtual ICollection<InOutStepInfo> InOutStepInfoes4 { get; set; }
        public virtual ICollection<InOutStepInfo> InOutStepInfoes5 { get; set; }
        public virtual ICollection<InOutStepInfo> InOutStepInfoes6 { get; set; }
        public virtual ICollection<SettlementMaster> SettlementMasters { get; set; }
        public virtual SysDepartment SysDepartment { get; set; }
        public virtual ICollection<WeightBridge> WeightBridges { get; set; }
        public virtual ICollection<WeightBridge> WeightBridges1 { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
        public virtual ICollection<Warehouse> Warehouses1 { get; set; }
    }
}
