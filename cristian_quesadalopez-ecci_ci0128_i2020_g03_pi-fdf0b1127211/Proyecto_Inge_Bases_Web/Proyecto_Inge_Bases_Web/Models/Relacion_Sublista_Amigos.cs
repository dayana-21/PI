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
    
    public partial class Relacion_Sublista_Amigos
    {
        public string CorreoDueno { get; set; }
        public string CorreoAmigo { get; set; }
        public string CorreoDuenoSublista { get; set; }
        public int SublistaID { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual ListaAmigo ListaAmigo { get; set; }
        public virtual Sublista Sublista { get; set; }
    }
}
