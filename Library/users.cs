//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            this.borrows = new HashSet<borrows>();
        }
    
        public int id_user { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<int> id_role { get; set; }
        public Nullable<int> id_address { get; set; }
    
        public virtual address address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<borrows> borrows { get; set; }
        public virtual roles roles { get; set; }
    }
}
