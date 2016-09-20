using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class District
    {
        public District()
        {
            this.InOutMasters = new List<InOutMaster>();
            this.WarehouseAmounts = new List<WarehouseAmount>();
        }

        public string DistrictCode { get; set; }
        public string Name { get; set; }
        public string ParentCode { get; set; }
        public virtual ICollection<InOutMaster> InOutMasters { get; set; }
        public virtual ICollection<WarehouseAmount> WarehouseAmounts { get; set; }
    }
}
