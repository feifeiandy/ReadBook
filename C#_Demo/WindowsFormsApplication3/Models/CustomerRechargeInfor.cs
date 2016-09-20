using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class CustomerRechargeInfor
    {
        public int Id { get; set; }
        public int BusinessCustomerId { get; set; }
        public Nullable<int> RfidID { get; set; }
        public Nullable<decimal> TotalMoney { get; set; }
        public Nullable<decimal> ExpenseMoney { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public bool IsStopped { get; set; }
        public virtual BusinessCustomer BusinessCustomer { get; set; }
        public virtual RFIDTag RFIDTag { get; set; }
    }
}
