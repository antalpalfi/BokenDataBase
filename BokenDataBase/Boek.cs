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
    
    public partial class Boek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boek()
        {
            this.BoekenAuteurs = new HashSet<BoekenAuteur>();
            this.BoekenGenres = new HashSet<BoekenGenre>();
        }
    
        public int Id { get; set; }
        public string Titel { get; set; }
        public Nullable<int> AntalPaginas { get; set; }
        public Nullable<int> Score { get; set; }
        public string Publicatie { get; set; }
        public Nullable<int> UitgeverId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoekenAuteur> BoekenAuteurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoekenGenre> BoekenGenres { get; set; }
        public virtual Uitgeverijen Uitgeverijen { get; set; }
     
    }
}
