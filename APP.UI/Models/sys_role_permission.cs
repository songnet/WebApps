//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace APP.UI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sys_role_permission
    {
        public string rpId { get; set; }
        public int roleId { get; set; }
        public int permissionId { get; set; }
    
        public virtual sys_permission sys_permission { get; set; }
        public virtual sys_role sys_role { get; set; }
    }
}
