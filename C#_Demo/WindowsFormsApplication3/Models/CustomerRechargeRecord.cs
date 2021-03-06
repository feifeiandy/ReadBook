using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class CustomerRechargeRecord
    {
        public int Id { get; set; }
        public int BusinessCustomerId { get; set; }
        public Nullable<decimal> RechargeMoney { get; set; }
        public Nullable<System.DateTime> RechargeDate { get; set; }
        public Nullable<int> RfidID { get; set; }
        public virtual BusinessCustomer BusinessCustomer { get; set; }
        public virtual RFIDTag RFIDTag { get; set; }
    }
}
