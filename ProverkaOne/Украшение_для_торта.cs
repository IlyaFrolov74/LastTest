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
    
    public partial class Украшение_для_торта
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Украшение_для_торта()
        {
            this.Спецификая_украшения_для_торта = new HashSet<Спецификая_украшения_для_торта>();
        }
    
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public string ЕдиницаИзмерения { get; set; }
        public Nullable<int> Количество { get; set; }
        public string Основной_поставщик { get; set; }
        public byte[] Изображение { get; set; }
        public string Тип_украшения_для_торта { get; set; }
        public decimal Закупочная_цена { get; set; }
        public string Вес { get; set; }
    
        public virtual Поставщик Поставщик { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спецификая_украшения_для_торта> Спецификая_украшения_для_торта { get; set; }
    }
}
