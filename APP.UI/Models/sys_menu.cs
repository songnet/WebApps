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
    
    public partial class sys_menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_menu()
        {
            this.sys_permission = new HashSet<sys_permission>();
        }
    
        public int menuId { get; set; }
        public Nullable<int> parentId { get; set; }
        public string menuName { get; set; }
        public string menuIcon { get; set; }
        public string menuUrl { get; set; }
        public string menuType { get; set; }
        public string menuOrder { get; set; }
        public string menuStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_permission> sys_permission { get; set; }
    }
}