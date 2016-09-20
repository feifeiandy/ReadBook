using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class WarehouseTransactionOperatorLog
    {
        public int Id { get; set; }
        public string Operator { get; set; }
        public int Operate { get; set; }
        public System.DateTime OperateTime { get; set; }
        public string Remark { get; set; }
    }
}
