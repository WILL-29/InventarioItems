//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventarioItems.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Telephones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Telephones()
        {
            this.TBL_History = new HashSet<TBL_History>();
        }
    
        public int ID_Tel { get; set; }
        public Nullable<int> Brand { get; set; }
        public string Model { get; set; }
        public string SN { get; set; }
        public Nullable<int> User_Assigned { get; set; }
        public Nullable<bool> Temporary { get; set; }
        public Nullable<System.DateTime> Return_Date { get; set; }
        public Nullable<int> Status_Tel { get; set; }
        public Nullable<int> Company { get; set; }
        public string Asset_ID { get; set; }
    
        public virtual TBL_Brands TBL_Brands { get; set; }
        public virtual TBL_Companies TBL_Companies { get; set; }
        public virtual TBL_Employees TBL_Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_History> TBL_History { get; set; }
        public virtual TBL_Status TBL_Status { get; set; }
    }
}
