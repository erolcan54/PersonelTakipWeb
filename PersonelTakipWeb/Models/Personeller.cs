//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonelTakipWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        public int PersonelID { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<System.DateTime> IseBaslamaTarihi { get; set; }
        public Nullable<int> DepartmanID { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string TCKimlik { get; set; }
    
        public virtual Departmanlar Departmanlar { get; set; }
    }
}
