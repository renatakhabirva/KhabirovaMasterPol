//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KhabirovaMasterPol
{
    using System;
    using System.Collections.Generic;
    
    public partial class PointSale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PointSale()
        {
            this.Partners = new HashSet<Partners>();
        }
    
        public int PointSaleID { get; set; }
        public string PointSaleCity { get; set; }
        public string PointSaleStreet { get; set; }
        public string PointSaleHouse { get; set; }
        public string PointSaleFloor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partners> Partners { get; set; }
    }
}
