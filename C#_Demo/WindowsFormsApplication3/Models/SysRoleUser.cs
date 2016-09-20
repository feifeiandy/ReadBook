using System;
using System.Collections.Generic;

namespace WindowsFormsApplication3.Models
{
    public partial class SysRoleUser
    {
        public string RoleCode { get; set; }
        public string UserCode { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}
