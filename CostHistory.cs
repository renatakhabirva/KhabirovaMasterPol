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
    
    public partial class CostHistory
    {
        public int CostHistoryID { get; set; }
        public int CostHistoryProduct { get; set; }
        public decimal CostHistory1 { get; set; }
        public System.DateTime CostHistoryDate { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
