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
    
    public partial class Сотрудник
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудник()
        {
            this.Турникет = new HashSet<Турникет>();
        }
    
        public int ID { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public Nullable<System.DateTime> Дата_рождения { get; set; }
        public Nullable<int> Паспортные_данные { get; set; }
        public Nullable<int> Реквизиты { get; set; }
        public Nullable<int> ID_смены { get; set; }
    
        public virtual График_смены График_смены { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Турникет> Турникет { get; set; }
    }
}
