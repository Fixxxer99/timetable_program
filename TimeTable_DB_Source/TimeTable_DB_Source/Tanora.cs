//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeTable_DB_Source
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tanora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tanora()
        {
            this.Tantargyak = new HashSet<Tantargy>();
        }
    
        public int Id { get; set; }
        public System.DateTime Kezdete { get; set; }
        public int Hossza { get; set; }
    
        public virtual Tanterem Tanterem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tantargy> Tantargyak { get; set; }
    }
}
