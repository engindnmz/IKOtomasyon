//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Birim_T
    {
        public Birim_T()
        {
            this.BirimIslem = new HashSet<BirimIslem>();
            this.DepartmanIslem = new HashSet<DepartmanIslem>();
        }
    
        public int ID { get; set; }
        public string BirimAdi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual ICollection<BirimIslem> BirimIslem { get; set; }
        public virtual ICollection<DepartmanIslem> DepartmanIslem { get; set; }
    }
}
