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
    
    public partial class HaziFeladat
    {
        public int Id { get; set; }
        public System.DateTime HataridoNap { get; set; }
        public string Tipusa { get; set; }
        public string Leirasa { get; set; }
    
        public virtual Tantargy Tantargyak { get; set; }
    }
}