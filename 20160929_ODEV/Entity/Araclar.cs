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
    
    public partial class Araclar
    {
        public Araclar()
        {
            this.AracPersonel = new HashSet<AracPersonel>();
        }
    
        public int AracID { get; set; }
        public string Plaka { get; set; }
        public int ModelID { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual AracModel AracModel { get; set; }
        public virtual ICollection<AracPersonel> AracPersonel { get; set; }
    }
}
