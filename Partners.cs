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
    
    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            this.Request = new HashSet<Request>();
            this.PointSale = new HashSet<PointSale>();
        }
    
        public int PartnersID { get; set; }
        public int PartnersTypeID { get; set; }
        public string PartnersName { get; set; }
        public string PartnersDirectorName { get; set; }
        public string PartnersEmail { get; set; }
        public string PartnersPhone { get; set; }
        public string PartnersAdress { get; set; }
        public string PartnersINN { get; set; }
        public int PartnersRaiting { get; set; }
        public string PartnersLogo { get; set; }
        public Nullable<int> PartnersPointOfSale { get; set; }
    
        public int SalePercent
        {
            get
            {
                int total = 0;
                foreach (Request requests in this.Request)
                {
                    total+= requests.RequestQuantity;
                }
                int sale = 0;
                if (total < 10000)
                {
                    sale = 0;
                }
                else if (total < 50000)
                {
                    sale = 5;
                }
                else if (total < 300000)
                {
                    sale = 10;
                }
                else { sale = 15; }
                return sale;
            }
        }

        public virtual PartnersType PartnersType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointSale> PointSale { get; set; }
    }
}