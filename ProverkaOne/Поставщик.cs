//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProverkaOne
{
    using System;
    using System.Collections.Generic;
    
    public partial class Поставщик
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщик()
        {
            this.Ингредиент = new HashSet<Ингредиент>();
            this.Украшение_для_торта = new HashSet<Украшение_для_торта>();
        }
    
        public string Наименование { get; set; }
        public string Адресс { get; set; }
        public string СрокДоставки { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ингредиент> Ингредиент { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Украшение_для_торта> Украшение_для_торта { get; set; }
    }
}
