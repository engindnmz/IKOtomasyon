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
    
    public partial class Maas_T
    {
        public Maas_T()
        {
            this.MaasIslem = new HashSet<MaasIslem>();
        }
    
        public int MaasID { get; set; }
        public decimal MaasTutari { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual ICollection<MaasIslem> MaasIslem { get; set; }
    }
}
