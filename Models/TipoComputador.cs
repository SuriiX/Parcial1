//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parcial1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoComputador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoComputador()
        {
            this.Computadors = new HashSet<Computador>();
        }
    
        public int TipoComputadorID { get; set; }
        public string Nombre { get; set; }
        public string Uso { get; set; }
        public string SistemaOperativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Computador> Computadors { get; set; }
    }
}
