//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Inge_Bases_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListaAmigo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ListaAmigo()
        {
            this.Relacion_Sublista_Amigos = new HashSet<Relacion_Sublista_Amigos>();
        }
    
        public string CorreoDueno { get; set; }
        public string CorreoAmigo { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Registrado Registrado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relacion_Sublista_Amigos> Relacion_Sublista_Amigos { get; set; }
    }
}
