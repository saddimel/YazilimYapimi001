//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BorsaProjesiAraSinav
{
    using System;
    using System.Collections.Generic;
    
    public partial class KullaniciUrun
    {
        public int Id { get; set; }
        public string Kullaniciadi { get; set; }
        public Nullable<int> UrunId { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        public virtual Urun Urun { get; set; }
    }
}