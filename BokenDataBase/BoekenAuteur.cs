//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BokenDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class BoekenAuteur
    {
        public int Id { get; set; }
        public Nullable<int> BoekId { get; set; }
        public Nullable<int> AuteurId { get; set; }
    
        public virtual Auteur Auteur { get; set; }
        public virtual Boek Boek { get; set; }
    }
}
