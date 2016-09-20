using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class InOutStepInfo
    {
        public string InOutStepId { get; set; }
        public string InOutMasterId { get; set; }
        public Nullable<System.DateTime> EnrolmentTime { get; set; }
        public string EnrolmentRegister { get; set; }
        public Nullable<System.DateTime> AssayTime { get; set; }
        public string AssayRegister { get; set; }
        public Nullable<System.DateTime> StorehouseTime { get; set; }
        public string StorehouseRegister { get; set; }
        public Nullable<System.DateTime> OnDutyTime { get; set; }
        public string OnDutyRegister { get; set; }
        public Nullable<System.DateTime> WeightTime { get; set; }
        public string WeightRegister { get; set; }
        public Nullable<System.DateTime> SettlementTime { get; set; }
        public string SettlementRegister { get; set; }
        public Nullable<System.DateTime> BackEnrolmentTime { get; set; }
        public string BackEnrolmentRegister { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysUser SysUser1 { get; set; }
        public virtual SysUser SysUser2 { get; set; }
        public virtual SysUser SysUser3 { get; set; }
        public virtual SysUser SysUser4 { get; set; }
        public virtual SysUser SysUser5 { get; set; }
        public virtual SysUser SysUser6 { get; set; }
    }
}
