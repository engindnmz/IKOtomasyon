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
    
    public partial class Semt_T
    {
        public Semt_T()
        {
            this.PersonelIletisim = new HashSet<PersonelIletisim>();
        }
    
        public int ID { get; set; }
        public string SemtAdi { get; set; }
        public int IlceID { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual Ilce_T Ilce_T { get; set; }
        public virtual ICollection<PersonelIletisim> PersonelIletisim { get; set; }
    }
}
