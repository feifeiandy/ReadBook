using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class SysUserFavorite
    {
        public string UserCode { get; set; }
        public string MenuCode { get; set; }
        public virtual SysMenu SysMenu { get; set; }
    }
}
