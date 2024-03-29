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
    
    public partial class demand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public demand()
        {
            this.Deal = new HashSet<Deal>();
        }
    
        public int IdDemand { get; set; }
        public Nullable<int> IdClient { get; set; }
        public Nullable<int> IdRealtor { get; set; }
        public Nullable<int> TypePropetry { get; set; }
        public Nullable<int> MinPrice { get; set; }
        public Nullable<int> MaxPrice { get; set; }
    
        public virtual Apartment Apartment { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deal> Deal { get; set; }
        public virtual House House { get; set; }
        public virtual Land Land { get; set; }
        public virtual Realtor Realtor { get; set; }
    }
}
