//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lasttry
{
    using System;
    using System.Collections.Generic;
    
    public partial class Производство
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Производство()
        {
            this.Продукция = new HashSet<Продукция>();
        }
    
        public int ID { get; set; }
        public string Наименование { get; set; }
        public Nullable<int> ID_смены { get; set; }
    
        public virtual График_смены График_смены { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Продукция> Продукция { get; set; }
    }
}
