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
    
    public partial class Kullanici
    {
        public Kullanici()
        {
            this.KullaniciSifre = new HashSet<KullaniciSifre>();
        }
    
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public bool AdminMi { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual Personel Personel { get; set; }
        public virtual ICollection<KullaniciSifre> KullaniciSifre { get; set; }
    }
}
