//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContoraRealtor
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apartment()
        {
            this.demand = new HashSet<demand>();
        }
    
        public int IdApartment { get; set; }
        public string Floor { get; set; }
        public string NumberOfRooms { get; set; }
        public string square { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<demand> demand { get; set; }
    }
}
