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
    
    public partial class sys_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_user()
        {
            this.sys_role = new HashSet<sys_role>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string sex { get; set; }
        public string email { get; set; }
        public string mark { get; set; }
        public string rank { get; set; }
        public Nullable<System.DateTime> lastLogin { get; set; }
        public string loginIp { get; set; }
        public string imageUrl { get; set; }
        public System.DateTime regTime { get; set; }
        public Nullable<bool> locked { get; set; }
        public string rights { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_role> sys_role { get; set; }
    }
}
