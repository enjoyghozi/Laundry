//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loundry.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jenis_Pakaian
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jenis_Pakaian()
        {
            this.Loundries = new HashSet<Loundry>();
        }
    
        public int ID_Jenis_Pakaian { get; set; }
        public string Nama_Pakaian { get; set; }
        public Nullable<int> Harga { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loundry> Loundries { get; set; }
    }
}
