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
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.MaterialSupply = new HashSet<MaterialSupply>();
            this.StockMaterial = new HashSet<StockMaterial>();
            this.UsedMaterial = new HashSet<UsedMaterial>();
        }
    
        public int MaterialID { get; set; }
        public int MaterialType { get; set; }
        public string MaterialName { get; set; }
        public int MaterialCountOfPackage { get; set; }
        public string MaterialUnit { get; set; }
        public string MaterialDescription { get; set; }
        public string MaterialImage { get; set; }
    
        public virtual Materialtype Materialtype1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialSupply> MaterialSupply { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockMaterial> StockMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsedMaterial> UsedMaterial { get; set; }
    }
}
