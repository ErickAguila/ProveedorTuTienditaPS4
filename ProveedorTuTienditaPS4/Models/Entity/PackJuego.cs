//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProveedorTuTienditaPS4.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PackJuego
    {
        public int idPackJuego { get; set; }
        public Nullable<int> idPack { get; set; }
        public string nombreJuego { get; set; }
        public string descripcion { get; set; }
        public Nullable<bool> vigente { get; set; }
        public Nullable<int> estrella { get; set; }
    
        public virtual Pack Pack { get; set; }
    }
}