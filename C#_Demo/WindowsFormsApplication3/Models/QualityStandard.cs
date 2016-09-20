using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class QualityStandard
    {
        public string StandardCode { get; set; }
        public string GBCode { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> Stopped { get; set; }
    }
}
