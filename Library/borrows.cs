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
    
    public partial class borrows
    {
        public int id_borrow { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_book { get; set; }
        public Nullable<System.DateTime> taken_date { get; set; }
        public Nullable<System.DateTime> return_date { get; set; }
    
        public virtual books books { get; set; }
        public virtual users users { get; set; }
    }
}
