using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class QualityGrade
    {
        public QualityGrade()
        {
            this.InOutMasters = new List<InOutMaster>();
        }

        public string GradeCode { get; set; }
        public string Name { get; set; }
        public string StandardCode { get; set; }
        public string InvclsCode { get; set; }
        public string InvmasCode { get; set; }
        public Nullable<decimal> Price { get; set; }
        public bool IsDefault { get; set; }
        public virtual ICollection<InOutMaster> InOutMasters { get; set; }
    }
}
